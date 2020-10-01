using System;
using System.Collections.Generic;
using System.Text;

namespace Parking
{
    public class Ticket
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
        private int fine;//штраф.      
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

        public int GetFine() => this.fine;

        public  int ChangeFine()
        {
            finefirst = 30;
            return finefirst;
        }

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
            Console.WriteLine("Ви хочете змінити розмір штрафу за перестой? ");
            Console.WriteLine("Натисніть 1,якщо ТАК ,натисніть 2,якщо НІ ");
            int i;
            i = int.Parse(Console.ReadLine());
            switch (i)
            {
                case 1:
                    Console.WriteLine("Ви вибрали пункт для зміни розміру штрафу");
                    ChangeFine();
                    break;
                case 2:
                    Console.WriteLine("Ви не хочете міняти розмір штрафу.Ну ок...");
                    break;
                default:
                    Console.WriteLine("Помилка,ви не те щось натиснули(");
                    break;
            }
                    //---------розрахунок штрафу----------
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
            Console.WriteLine("-----------------------------------------");
            Console.WriteLine("Якщо ви вибрали змінити ставку штрафу,то діятимуть наступні ставки: ");
            Console.WriteLine("30 грн. за першу чи неповну годину перестою");
            Console.WriteLine("10 грн.за кожну наступну повну чи неповну годину перестою");
            Console.WriteLine("------------------------------------------");
            Console.WriteLine("Якщо ви не змінювали ставку,то розрахунок відбувається за такою шкалою:");
            Console.WriteLine("25 грн. за першу повну чи неповну годину перестою");
            Console.WriteLine("10 грн.за кожну наступну повну чи неповну годину перестою");
            Console.WriteLine("------------------------------------------");
            System.Threading.Thread.Sleep(150);
            Console.WriteLine($"Штраф: {fine}");
            System.Threading.Thread.Sleep(150);
            Console.WriteLine($"Парковщик: {parkername}");
            System.Threading.Thread.Sleep(150);
            Console.WriteLine("Будемо чекати вас знову!");
            Console.WriteLine("===============================================");
            System.Threading.Thread.Sleep(150);
            Console.WriteLine("Дата формування квитанції:" + DateTime.Now);
           

        }

    }
}
