using System;


namespace Figure
{
    class Trapezoid:FigureBase
    {
        double side_a { get; set; }
        double side_b { get; set; }       
        double height { get; set; }


        public Trapezoid(string name, string color, double side_a, double side_b, double height) : base(name,color)
        {
            this.side_a = side_a;
            this.side_b = side_b;            
            this.height = height;
        }
        public double GetBiggestBase()
        {
            if(side_a>side_b)
            {
                return side_a;
            }
            else
            {
                return side_b;
            }
        }

        public override double Area()=> Math.Round((((side_a + side_b) / 2) * height), 2);

        public override void ShowInfo()
        {
            base.ShowInfo();
            Console.Write($"Area: {Area()} \nFirst base side:{side_a}\nSecond base side:{side_b}");
        }

    }
}
