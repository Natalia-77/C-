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

        public string GetModel() => this._model;

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
            this._color = car.GetColors();
            this._letter = car.GetLrtter();
            this._model = car.GetModels();
            this._number = car.GetNumbers();
            this.parkername = Parker.parkername;
            this.start = car.GetTime().GetTimeStart();
            this.end = car.GetTime().GetTimeEnd();
            this.payed = car.GetTime().GetTimePayed();
            this.outstand = car.GetTime().Outstand();

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
            Console.WriteLine($"Модель: {this._model}");
            System.Threading.Thread.Sleep(250);
            Console.WriteLine($"Колір: {this._color}");
            System.Threading.Thread.Sleep(250);
            Console.WriteLine($"Номер: {this._number}");
            System.Threading.Thread.Sleep(250);
            Console.WriteLine($"Час в'їзду: {this.start}");
            System.Threading.Thread.Sleep(250);
            Console.WriteLine($"Час виїзду: {this.end}");
            System.Threading.Thread.Sleep(250);
            Console.WriteLine($"Куплений час: {this.payed}");
            Console.WriteLine($"Час перестою: {this.outstand}");
            Console.WriteLine($"Штраф: {this.fine}");
            Console.WriteLine($"Парковщик: {this.parkername}");
            System.Threading.Thread.Sleep(250);
            Console.WriteLine("**************");

        }

    }
}
