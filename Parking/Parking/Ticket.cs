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
        static public int finenext{ get; set; } = 10;


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

        public Ticket(Car car)
        {
            _color = car.GetColors();
            _letter = car.GetLrtter();
            _model = car.GetModels();
            _number = car.GetNumbers();
            parkername = Parker.parkername;
            start = car.GetTime().GetTimeStart();
            end = car.GetTime().GetTimeEnd();
            payed = car.GetTime().GetTimePayed();
            outstand = car.GetTime().Outstand();

            double res = car.GetTime().OutstandingTime();

            if(res<60&&res>0)
            {
                fine += finefirst;
            }
            else
            {
                fine += finenext;
            }           
        }

        public Ticket()
        {
        }

        public void PrintTicket()
        {
            Console.WriteLine("*** Ticket ***");
            System.Threading.Thread.Sleep(250);
            Console.WriteLine($"Модель: {_model}");
            System.Threading.Thread.Sleep(250);
            Console.WriteLine($"Колір: {_color}");
            System.Threading.Thread.Sleep(250);
            Console.WriteLine($"Номер: {_number}");
            System.Threading.Thread.Sleep(250);
            Console.WriteLine($"Час в'їзду: {start}");
            System.Threading.Thread.Sleep(250);
            Console.WriteLine($"Час виїзду: {end}");
            System.Threading.Thread.Sleep(250);
            Console.WriteLine($"Куплений час: {payed}");
            Console.WriteLine($"Час перестою: {outstand}");
            Console.WriteLine($"Штраф: {fine}");
            Console.WriteLine($"Парковщик: {parkername}");
            System.Threading.Thread.Sleep(250);
            Console.WriteLine("**************");
           

        }

    }
}
