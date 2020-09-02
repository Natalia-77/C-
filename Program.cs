//using System;
//using System.Reflection.Metadata.Ecma335;

//namespace ConsoleApp1
//{
//    class Program
//    {
//        static void Main(string[] args)
//        {
            
//           // --------------Плитка----------------
//            Console.WriteLine("Enter the width of the tile (еnter the value in millimeters)");
//            double w=0;
//            //double w = Convert.ToDouble(Console.ReadLine());//ширина плитки
          
//            while (!double.TryParse(Console.ReadLine(), out w)|| w<=0)
//            {
//                Console.WriteLine("Error!Try again!");
//            }


//            Console.Write("Enter the length of the tile (еnter the value in millimeters) \n");
//            double l = 0;
//           // double l = Convert.ToDouble(Console.ReadLine());   // довжина плитки  
//            //while (l <= 0)
//            //{
//            //    Console.WriteLine("Error!Try again!");
//            //    l = Convert.ToDouble(Console.ReadLine());
//            //}
//            while (!double.TryParse(Console.ReadLine(), out l) || l <= 0)
//            {
//                Console.WriteLine("Error!Try again!");
//            }

//            double res =(w * l)/1000000;
//            Console.WriteLine("The area of  tile : {0} square meters\n",res );
//            Console.WriteLine("====================================\n");


//            // ---------------Стіна---------------
//            Console.WriteLine("Enter the width of the wall (еnter the value in meters)");
//            // double q = Convert.ToDouble(Console.ReadLine())*1000;//ширина стіни.
//            double q = 0;

//            while (!double.TryParse(Console.ReadLine(), out q) || q <= 0)
//            {
//                Console.WriteLine("Error!Try again!");
//            }

//            Console.Write("Enter the length of the wall (еnter the value in meters) \n");
//            //double t = Convert.ToDouble(Console.ReadLine())*1000;//довжина стіни.
//            double t = 0;

//            while (!double.TryParse(Console.ReadLine(), out t) || t <= 0)
//            {
//                Console.WriteLine("Error!Try again!");
//            }

//            // double s = (q * t)/1000000;
//            double s = q * t;
//            Console.WriteLine($"The area of wall : {Math.Round(s, 2)} square meters\n", s) ;
//            Console.WriteLine("=====================================\n");

//            if (s < res)
//            {
//                Console.WriteLine("Error!Uncorrect parameters!");
//                return;

//            }
//            else
//            {
//                // --------Кількість плиток всього цілих--------------
//                double quantity = s / res;
//                Console.WriteLine($"On this surface you need whole tiles of everything :{Math.Round(quantity, 0) }\n", quantity);


//                // -------Кількість плиток в ряду--------------

//                double row = (q * 1000) / w;
//                Console.WriteLine("There should be {0} whole tiles in a row\n", (int)row);
//                double col = (t * 1000) / l;
//                Console.WriteLine("There should be {0} whole tiles in a col\n", (int)col);
//                double ost = (row * 100 - (int)row * 100) / 100;
//                if (ost == 0)
//                {
//                    Console.WriteLine("Full line without remainder\n");//повний рядок
//                }
//                else
//                {
//                    double osrw = ost * w;//залишок множу на висоту.
//                    Console.WriteLine($"The last tile in a row has a width {Math.Round(osrw, 0)} мм\n", osrw);
//                }
//                // -------Кількість плиток по висоті--------------

//                double ostcol = (col * 100 - (int)col * 100) / 100;
//                if (ostcol == 0)
//                {
//                    Console.WriteLine("In height a tile without the rest\n"); //в висоту плитка без залишку
//                }
//                else
//                {
//                    double osrc = ostcol * l;//залишок множу на ширину.
//                    Console.WriteLine($"The last tile in a row has a height {Math.Round(osrc, 0) } мм\n", osrc);//остання плитка в ряду має висоту.
//                }

//                // -----------Розрахунок витрати клею---------


//                Console.WriteLine("Enter the thickness of the adhesive layer ,в mm:");//введіть товщину шару клею
//                double glue, val, k;
//                while (!double.TryParse(Console.ReadLine(), out glue) || glue <= 0)
//                {
//                    Console.WriteLine("Error!Try again!");
//                }

//                Console.WriteLine("Enter the consumption of glue in kg per 1m2 :");//Введіть витрату клея в кг на 1м2
//                                                                                   //double val = Convert.ToDouble(Console.ReadLine());
//                while (!double.TryParse(Console.ReadLine(), out val) || val <= 0)
//                {
//                    Console.WriteLine("Error!Try again!");
//                }
//                double finish = (s + res) * glue * val;

//                Console.WriteLine($"It is necessary for the set area {Math.Ceiling(finish) }  kg glue\n", finish);//На задану площу необхідно.
//                Console.WriteLine("Enter how many kg of glue in one bag: :\n");//Введіть,скільки кг клею в одному мішку:
//                while (!double.TryParse(Console.ReadLine(), out k) || k <= 0)
//                {
//                    Console.WriteLine("Error!Try again!");
//                }
//                double total = finish / k;
//                double rest = total * k - finish;
//                Console.WriteLine($"All you need for the specified area :{ Math.Ceiling(total) } bags \n", total);//Всього на вказану площу потрібно
//                Console.WriteLine($"The rest of the glue will be :{Math.Ceiling(total) * k - finish} kg \n", total, k, finish);//Залишок клею становитиме



//            }

//        }
//    }
//}
