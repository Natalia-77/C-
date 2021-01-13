using System;


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
            Console.Write($"Area: {Area()} \nRadius:{GetRadius()} ");
        }

        public double GetRadius()
        {
            return radius;
        }


    }
}
