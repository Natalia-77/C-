using System;
using System.Drawing;

namespace FigureDelegate
{
    class Program
    {
        delegate void Draw(ref ConsoleColor color);

        private static void Main(string[] args)
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
         



        }

        

    }
}
