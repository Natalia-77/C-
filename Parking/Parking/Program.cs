using System;
using System.Collections.Generic;
using System.Text;

namespace Parking
{

    public enum Model { Audi,Opel,Kia,Lada,BMW};
    public enum Color { Black,Red,White,Yellow,Silver};
    public enum Letter { UA,EU,USA,CH,IN,RU,CAN};

    class Program
    {
        static void Main(string[] args)
        {
            Console.OutputEncoding = Encoding.Unicode;
            Console.InputEncoding = Encoding.Unicode;
            Parkingbook park = new Parkingbook(6);
            //List<Car> car = new List<Car>(4);
            //car.Add(new Car());
            //car.Add(new Car());
            //car.Add(new Car());
            //car.Add(new Car());

            //foreach (Car el in car)
            //{
            //    el.Show();
            //    Console.WriteLine(el.ToString());
            //}

            park.AddCar();
            park.AddCar();
            park.AddCar();
            park.PrintAllCar();
            int y;
            Console.WriteLine("Enter hh:");
            y = int.Parse(Console.ReadLine());
            park.DelCar(y);

            //foreach (Car el in car)
            //{
            //    el.Show();
            //    Console.WriteLine(el.ToString());
            //}
            park.PrintAllCar();

            //Console.WriteLine("---------------------");
            //Timer timer = new Timer();
            //Console.WriteLine("Дата і час заїзду: " + timer.GetTimeStart());
            //Console.WriteLine("Дата і час виїзду: " + timer.GetTimeEnd());
            //Console.WriteLine("Фактичні хвилини простою: " + timer.GetF());
            //Console.WriteLine("Оплачені хвилини: " + timer.GetSpanMinutes());
            //Console.WriteLine("Різниця(хвилини),за які потрібно доплатити: " + timer.GetS());








        }
    }
}
