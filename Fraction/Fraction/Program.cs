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

            if (b == 0 || d == 0)
            {
                throw new Exception("Знаменник не може бути рівним нулю!");
            }

            Console.WriteLine("Дроби,які ви ввели, мають наступний вигляд(у вигляді правильного дробу): ");
            Console.WriteLine(f1.ToString() + "  " + f2.ToString());

            if (f1)
                Console.WriteLine("Перший дріб правильний");
            else
                Console.WriteLine("Перший дріб неправильний ");

            if (f2)
                Console.WriteLine("Другий дріб правильний");
            else
                Console.WriteLine("Другий дріб неправильний ");

            Console.WriteLine("Рівність між першим і другим дробом ");
           
            if (f1 < f2)
                Console.WriteLine("Перший дріб менше другого");
            else
                Console.WriteLine("Перший дріб більше другого ");

            if (f1 > f2)
                Console.WriteLine("Перший дріб більше другого");
            else
                Console.WriteLine("Перший дріб менше другого ");



            //Console.WriteLine("Введіть десятковий дріб(через крапку),який ви хочете додати до першого дробу: ");
            //string s = Console.ReadLine();
            //Fraction f3 = Fraction.Parse(s);
            //Console.WriteLine("Введений вами десятковий дріб має такий вигляд(у вигляды правильного дробу): ");
            //f3.Show();
            //Fraction f4 = f1 + f3;
            //Console.WriteLine("Ваш результат(у вигляді правильного дробу): ");
            //f4.Show();





            //int n = 4;
            //Fraction f3 =n* f1;
            //f3.Show();
            // double m = 1.5;
                        
            //Fraction f3 = f1 / f2;
            //f3.Show();

            //Console.WriteLine($"point1 == point2:{ f1 == f2}"); //

        }
    }
}
