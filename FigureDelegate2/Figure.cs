using System;
using System.Collections.Generic;
using System.Text;

namespace FigureDelegate2
{
    class Figure
    {
        public Figure()
        {

        }

        public string DrawTriangle(string color)
        {
            Console.WriteLine("Малює трикутник кольором--> " + color);
            return color;
        }

        public string DrawRectangle(string color)
        {
            Console.WriteLine("Малює прямокутник кольором--> " + color);
            return color;
        }
    }
}
