using System;
using System.Text;

namespace Parking
{

    public enum Model { Audi,Opel,Kia,Lada,BMW};
    public enum Color { Black,Red,White,Yellow,Silver};
    public enum Number { UA,EU,USA,CH,IN,RU,CAN};

    class Program
    {
        static void Main(string[] args)
        {
            Console.OutputEncoding = Encoding.Unicode;
            Console.InputEncoding = Encoding.Unicode;

            //Car car = new Car("Audi", "Black", "FT 2501 HY",06,10,00);
            //Car car1 = new Car("Opel", "Silver", "FG 1258 UU", 07, 00, 00);
            //Car car2 = new Car("KIA", "Red", "WE 6541 BB", 08, 00, 00);

            //string v = car.ToString();
            // Console.WriteLine(v);

            //car.Show();
            //car1.Show();
            //car2.Show();

            Console.WriteLine("----------------\n");
            Car[] cars ={new Car(14,00,00,2),
            new Car(13,10,00,3),new Car(15,00,00,1),new Car(14,22,00,7) };

            
            foreach (Car el in cars )
            {
                el.Show();
                // Car.Conver(el);
                //Timer.Timestart();
                // Timer.Timefinish();
                //Console.WriteLine("{0:g}", timer.Start());//час заїзду на парковку
                // Console.WriteLine("+++{0:g}", timer.End());//час виїзду на парковку.
                //Console.WriteLine(timer.Pay().TotalMinutes);
                Timer timer = new Timer();
                timer.Show();
            }

            



        }
    }
}
