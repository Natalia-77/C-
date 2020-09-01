using System;
using System.Reflection.Metadata.Ecma335;

namespace ConsoleApp1
{
    class Program
    {
        static void Main(string[] args)
        {
            
           // --------------Плитка----------------
            Console.WriteLine("Enter the width of the tile (еnter the value in millimeters)");
            double w=0;
            //double w = Convert.ToDouble(Console.ReadLine());//ширина плитки
          
            while (!double.TryParse(Console.ReadLine(), out w)|| w<=0)
            {
                Console.WriteLine("Помилка!Спробуйте знову ввести дані!");
            }


            Console.Write("Enter the length of the tile (еnter the value in millimeters) \n");
            double l = 0;
           // double l = Convert.ToDouble(Console.ReadLine());   // довжина плитки  
            //while (l <= 0)
            //{
            //    Console.WriteLine("Error!Try again!");
            //    l = Convert.ToDouble(Console.ReadLine());
            //}
            while (!double.TryParse(Console.ReadLine(), out l) || l <= 0)
            {
                Console.WriteLine("Помилка!Спробуйте знову ввести дані!");
            }

            double res =(w * l)/1000000;
            Console.WriteLine("The area of  tile : {0} square meters\n",res );
            Console.WriteLine("====================================\n");


            // ---------------Стіна---------------
            Console.WriteLine("Enter the width of the wall (еnter the value in meters)");
            // double q = Convert.ToDouble(Console.ReadLine())*1000;//ширина стіни.
            double q = 0;

            while (!double.TryParse(Console.ReadLine(), out q) || q <= 0)
            {
                Console.WriteLine("Помилка!Спробуйте знову ввести дані!");
            }

            Console.Write("Enter the length of the wall (еnter the value in meters) \n");
            //double t = Convert.ToDouble(Console.ReadLine())*1000;//довжина стіни.
            double t = 0;

            while (!double.TryParse(Console.ReadLine(), out t) || t <= 0)
            {
                Console.WriteLine("Помилка!Спробуйте знову ввести дані!");
            }

            // double s = (q * t)/1000000;
            double s = q * t;
            Console.WriteLine($"The area of wall : {Math.Round(s, 2)} square meters\n", s) ;
            Console.WriteLine("=====================================\n");

            
            // --------Кількість плиток всього цілих--------------
            double quantity = s / res;
            Console.WriteLine($"On this surface you need whole tiles of everything :{Math.Round(quantity,0) }\n", quantity);
           
              
            // -------Кількість плиток в ряду--------------

            double row = (q*1000) / w;
            Console.WriteLine("There should be {0} whole tiles in a row\n",(int)row);
            double col = (t*1000) / l;
            Console.WriteLine("There should be {0} whole tiles in a col\n", (int)col);
            double ost =(row * 100 - (int)row * 100)/100;
            if (ost == 0)
            {
                Console.WriteLine("Повний рядок без залишку\n");
            }
            else
            {
                double osrw = ost * w;//залишок множу на висоту.
                Console.WriteLine($"Остання плитка в рядку має ширину {Math.Round(osrw,0)} мм", osrw);
            }
            // -------Кількість плиток в колонці--------------
           
            double ostcol = (col * 100 - (int)col * 100) / 100;
            if (ostcol == 0)
            {
                Console.WriteLine("В висоту плитка  без залишку\n");
            }
            else
            {
                double osrc = ostcol * l;//залишок множу на ширину.
                Console.WriteLine($"Остання плитка в рядку має висоту {Math.Round(osrc,0) } мм", osrc);
            }

            // -----------Розрахунок витрати клею---------

                  
            Console.WriteLine("Введіть товщину шару клею,в мм:\n");
            double glue = Convert.ToDouble(Console.ReadLine());
            Console.WriteLine("Введіть витрату клея в кг на 1м2:\n");
            double val = Convert.ToDouble(Console.ReadLine());
            double finish = (s + res) * glue * val;
            Console.WriteLine($"На задану площу необхідно  {Math.Round(finish,0)}  кг клею", finish);
            Console.WriteLine("Введіть,скільки кг клею в одному мішку:\n");
            double k = Convert.ToDouble(Console.ReadLine());
            double total = finish / k;
            Console.WriteLine($"Всього на вказану площу потрібно  :{Math.Round(total, 0) } мішків \n", total);
            






        }
    }
}
