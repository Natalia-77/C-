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
        double side_a { get; set; }
        double side_b { get; set; }
        double side_c { get; set; }

        public Triangle(string name, string color, double a, double b, double c) : base(name, color)
        {
            side_a = a;
            side_b = b;
            side_c = c;
        }

        public override double Area()
        {
            double perim = (side_a + side_b + side_c) / 2;
            return Math.Round(Math.Sqrt(perim*(perim-side_a)*(perim-side_b)*(perim-side_c)), 1);
        }

        public void  GetSide(out double a,out double b,out double c)
        {
            a = this.side_a;
            b = this.side_b;
            c = this.side_c;
        }

        public override void ShowInfo()
        {
            base.ShowInfo();            
            Console.Write($" Area: {Area()} \n Sides:{side_a},{side_b},{side_c} ");
        }
    }
}


