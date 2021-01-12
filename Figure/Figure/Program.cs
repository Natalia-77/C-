using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Figure
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.OutputEncoding = Encoding.Unicode;
            Console.InputEncoding = Encoding.Unicode;

            FigureBase[] figures =
            {
                new Triangle("Triangle","yellow",7,7,8),
                new Rectangle("Rectangle","green",5.2,7)
            };

            foreach(FigureBase el in figures)
            {
                el.ShowInfo();
                Console.WriteLine();
                Console.WriteLine("----------------------\n");
            }
            Rectangle t = new Rectangle("Rectangle", "red", 10, 25);
            Console.WriteLine( $"{t.GetBiggestSide()}");




        }
    }
}
