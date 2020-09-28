using System;
using System.Collections.Generic;
using System.Text;

namespace Parking
{
    class Ticket
    {
        private string parkername;//і"мя парковщика.
        private string _model;
        private string _color;
        private int _number;
        private string _letter;
        private DateTime start;
        private DateTime end;
        private DateTime payed;
        private DateTime outstand;
        private double fine;//штраф.      
        static public int finefirst { get; set; } = 25;
        static public int finenext { get; set; } = 10;


        public string DetParkerName() => this.parkername;

        public string GetModel() => _model;

        public string GetColor() => this._color;

        public int GetNum() => this._number;

        public string GetLetter() => this._letter;

        public DateTime GetStartTime() => this.start;

        public DateTime GetEndTime() => this.end;

        public DateTime GetPayTime() => this.payed;

        public DateTime GetOutstand() => this.outstand;

        public double GetFine() => this.fine;

        public Ticket()
        {

        }

        public Ticket(Car car)
        {
            _color = car.GetColors();
            _letter = car.GetLrtter();
            _model = car.GetModels();
            _number = car.GetNumbers();
            parkername = Parker.parkername;
            start = car.GetTime().GetTimeStart();//час заїзду.
            end = car.GetTime().GetTimeEnd();//час виїзду.
            payed = car.GetTime().GetTimePayed();//оплачений час
            outstand = car.GetTime().Outstand();//час перестою,за який треба нарахувати штраф.

            //double res = car.GetTime().OutstandingTime();//час перестою у хвилинах.


            if (outstand.Hour == 0 && outstand.Minute == 0 && outstand.Second == 0)
            {
                fine = 0;
            }
            else
            {
                if ((outstand.Hour == 1 && outstand.Minute < 60) || outstand.Minute < 60)
                {
                    fine += finefirst;
                }
                if ((outstand.Hour > 1 && outstand.Minute < 60) || outstand.Minute < 60)
                {
                    fine += finenext * outstand.Hour;
                }
            }

        }


        public void PrintTicket()
        {
            Console.WriteLine("--------------------------");           
            Console.WriteLine("Розрахункова квитанція:");
            System.Threading.Thread.Sleep(150);
            Console.WriteLine($"Модель: {_model}");
            System.Threading.Thread.Sleep(150);
            Console.WriteLine($"Колір: {_color}");
            System.Threading.Thread.Sleep(150);
            Console.WriteLine($"Номер: {_number}");
            System.Threading.Thread.Sleep(150);
            Console.WriteLine($"Час в'їзду: {start}");
            System.Threading.Thread.Sleep(150);
            Console.WriteLine($"Час виїзду: {end}");
            System.Threading.Thread.Sleep(150);
            Console.WriteLine($"Куплений час: {payed}");
            System.Threading.Thread.Sleep(150);
            Console.WriteLine($"Час перестою: {outstand}");
            System.Threading.Thread.Sleep(150);
            Console.WriteLine($"Штраф: {fine}");
            System.Threading.Thread.Sleep(150);
            Console.WriteLine($"Парковщик: {parkername}");
            System.Threading.Thread.Sleep(150);
            Console.WriteLine("Будемо чекати вас знову!");
            Console.WriteLine("--------------------------");
            System.Threading.Thread.Sleep(150);
            Console.WriteLine("Дата формування квитанції:" + DateTime.Now);
           

        }

    }
}
