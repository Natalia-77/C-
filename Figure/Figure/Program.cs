using System;
using System.Collections.Generic;
using System.Text;


namespace Figure
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.OutputEncoding = Encoding.Unicode;
            Console.InputEncoding = Encoding.Unicode;
            Random rand = new Random();

            FigureBase[] figures =
            {
                new Triangle("Triangle","yellow",7,7,8),
                new Rectangle("Rectangle","green",5.2,7),
                new Circle ("Circle", "blue", 55),
                new Trapezoid("Trapezoid","orange",15,25,7)

        };
            //All figures in array.
            foreach(FigureBase el in figures)
            {
                el.ShowInfo();
                Console.WriteLine();
                Console.WriteLine("----------------------\n");
                
            }            

            List<FigureBase> f = new List<FigureBase>();

            Console.WriteLine("Enter how many times you need random figures");

            int res = int.Parse(Console.ReadLine());
            
          
            for (int i = 0; i < res; i++)
            {
                int index = rand.Next(figures.Length);
                f.Add(figures[index]);
            }

            foreach(var item in f)
            {
                item.ShowInfo();
                Console.WriteLine();
                Console.WriteLine("-----------------------\n");                
            }        
        }
    }
}
