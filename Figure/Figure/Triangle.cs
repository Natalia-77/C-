using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Figure
{
    class Triangle : FigureBase
    {
        /// <summary>
        /// Triangle sides.
        /// </summary>
        double a { get; set; }
        double b { get; set; }
        double c { get; set; }

        public Triangle(string name, string color, double a, double b, double c) : base(name, color)
        {
            this.a = a;
            this.b = b;
            this.c = c;
        }

        public override double Area()
        {
            double perim = (a + b + c) / 2;
            return Math.Round(Math.Sqrt(perim*(perim-a)*(perim-b)*(perim-c)), 1);
        }

        public override void ShowInfo()
        {
            base.ShowInfo();            
            Console.Write($" Area: {Area()} \n Sides:{a},{b},{c} ");
        }
    }
}


