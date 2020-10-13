using System;

namespace FigureDelegate2
{
    class Program
    {
        delegate string  Draw(string color);

        static void Main(string[] args)
        {
            // Можна стрінгом вводити назву кольору.Наприклад,волошкове поле.
            // Тут прив"язка до простого стрінга.
            // Це варіант простіший.
            
            string colorname = "";
            Console.WriteLine("Введіть назву кольору : ");
            string color = Console.ReadLine();
            Figure f = new Figure();
            Draw d = f.DrawRectangle;
            d += f.DrawTriangle;
            colorname = d(color);
        }
    }
}
