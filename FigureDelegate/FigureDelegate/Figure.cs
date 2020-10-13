
using System;
using System.Collections.Generic;
using System.Text;

namespace FigureDelegate
{
    class Figure
    {

        public Figure()
        {

        }

        public void DrawTriangle(ref ConsoleColor color)
        {
            //color = ConsoleColor.Red;
            Console.ForegroundColor = color;
            Console.WriteLine("Малює трикутник\n");
            for (int i = 0; i < 10; i++)
            {
                for (int j = 0; j < i; j++)
                {

                    Console.Write("*");
                }
                Console.WriteLine(" ");
            }
                Console.ForegroundColor = ConsoleColor.White;
            Console.WriteLine();
        }

        public void DrawRectangle(ref ConsoleColor color)
        {
           // color = ConsoleColor.Yellow;
            Console.ForegroundColor =color;
            Console.WriteLine("Малює прямокутник\n");
            for (int i = 0; i < 10; i++)
            {
                for (int j = 0; j < 10; j++)
                {

                    Console.Write("*");
                }
                Console.WriteLine("*");
                System.Threading.Thread.Sleep(100);
            }

            Console.ForegroundColor = ConsoleColor.White;
            Console.WriteLine();
        }

        //--------------------------------------------
        //public string  DrawTriangle( string color)
        //{            
        //    Console.WriteLine("Малює трикутник кольором--> "+color);
        //    return color;
        //}

        //public string  DrawRectangle(string color)
        //{           
        //    Console.WriteLine("Малює прямокутник кольором--> "+color);
        //    return color;
        //}
    }
}
