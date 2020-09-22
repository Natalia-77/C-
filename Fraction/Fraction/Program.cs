using System;
using System.Text;

namespace Fraction
{
    class Program
    {
        static void Main(string[] args)
        {

            Console.OutputEncoding = Encoding.Unicode;
            Console.InputEncoding = Encoding.Unicode;

            int a, b, c, d;
            Console.WriteLine("Enter a");
            a = Int32.Parse(Console.ReadLine());
            Console.WriteLine("Enter b");
            b = Int32.Parse(Console.ReadLine());
            Console.WriteLine("Enter c");
            c = Int32.Parse(Console.ReadLine());
            Console.WriteLine("Enter d");
            d = Int32.Parse(Console.ReadLine());

            Fraction f1 = new Fraction(a, b);
            Fraction f2 = new Fraction(c, d);
            //Console.WriteLine(f1.ToString() + "  " + f2.ToString());
            f1.Show();
            f2.Show();


            Console.WriteLine("Введіть десятковий дріб(через крапку),який ви хочете додати до першого дробу: ");
            string s = Console.ReadLine();
            Fraction f3 = Fraction.Parse(s);
            Console.WriteLine("Введений вами десятковий дріб має такий вигляд(у вигляды правильного дробу): ");
            f3.Show();
            Fraction f4 = f1 + f3;
            Console.WriteLine("Ваш результат(у вигляді правильного дробу): ");
            f4.Show();
           




            //if(f1)
            //    Console.WriteLine(true);
            //else
            //    Console.WriteLine(false);
            //int n = 4;
            //Fraction f3 =n* f1;
            //f3.Show();

            // double m = 1.5;



            //if (b == 0||d==0)
            //{
            //    throw new Exception("Знаменник не може бути рівним нулю!");
            //}
            //f1.Show();
            //f2.Show();                     
            //Fraction f3 = f1 / f2;
            //f3.Show();

            //Console.WriteLine($"point1 == point2:{ f1 == f2}"); //

        }
    }
}
