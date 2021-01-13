using System;


namespace Figure
{
    class Rectangle:FigureBase
    {
        /// <summary>
        /// Rectangle sides.
        /// </summary>
        double side_first { get; set; }
        double side_second { get; set; }

        public Rectangle(string name,string color,double first,double second):base(name,color)
        {
            side_first = first;
            side_second = second;
        }

        public override double Area() => side_first * side_second;       

        public double GetBiggestSide()
        {
            if(side_second>side_first)
            {
                return side_second;
            }
            else
            {
                return side_first;
            }
        }

        public override void ShowInfo()
        {
            base.ShowInfo();
            Console.WriteLine($"Area: {Area()} \nSides:{side_first},{side_second}\nBiggest side:{GetBiggestSide()}");
            
        }


    }
}
