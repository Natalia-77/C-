using System;
using System.Drawing;

namespace FigureDelegate
{
    class Program
    {
        // delegate string  Draw(string color);
           delegate void Draw(ref ConsoleColor color);

        static void Main(string[] args)

        {         
            Figure f = new Figure();

            // Оголошення делегата.
            Draw d;

            ConsoleColor color = Console.ForegroundColor;

            // Буде малювати фігури зеленим кольором.
            color = ConsoleColor.Green;

            d = f.DrawRectangle;
            d += f.DrawTriangle;

            d(ref  color);
         


            //-----------------------------
            //string colorname = "";
            //string color = Console.ReadLine();
            //Figure f = new Figure();
            //Draw d= f.DrawRectangle;
            //d += f.DrawTriangle;
            //colorname = d(color);
            //---------------------------

        }

        

    }
}
