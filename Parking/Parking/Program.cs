using System;
using System.Collections.Generic;
using System.Text;

namespace Parking
{

    public enum Model { Audi,Opel,Seat,Lada,Jeep};
    public enum Color { Black,Brown,White,Yellow,Silver};
    public enum Letter { UA,EU,US,CH,IN,RU,CAN};

    class Program
    {
        static void Main(string[] args)
        {
            Console.OutputEncoding = Encoding.Unicode;
            Console.InputEncoding = Encoding.Unicode;
            //Parker parker = new Parker();
            //Parker.parkername = "";


            //parker.Info();
            //parker.Add();
            //parker.Add();
            //parker.ShowAllCars();
            //parker.Info();           
            //parker.Del();
            //parker.Info();
            //parker.Statist();

            Menu menu = new Menu();
            menu.MainMenu();





        }
    }
}
//Console.WriteLine("---------------------");
//Timer timer = new Timer();
//Console.WriteLine("Дата і час заїзду: " + timer.GetTimeStart());
//Console.WriteLine("Дата і час виїзду: " + timer.GetTimeEnd());
//Console.WriteLine("Payed time: "+timer.GetTimePayed());
//Console.WriteLine("Оплачені хвилини: " + timer.GetSpanMinutes());
//Console.WriteLine("Різниця(хвилини),за які потрібно доплатити: " + timer.GetS());
