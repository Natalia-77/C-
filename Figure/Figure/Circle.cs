using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Figure
{
    class Circle:FigureBase
    {
        double radius { get; set; }

        public Circle(string name,string color,double radius):base(name,color)
        {
            this.radius = radius;
        }

        public override double Area() => Math.Round(Math.PI * (radius * radius), 1);
        public override void ShowInfo()
        {
            base.ShowInfo();
            Console.Write($"Area: {Area()} \nRadius:{radius} ");
        }

        public double GetRadius()
        {
            return radius;
        }


    }
}
