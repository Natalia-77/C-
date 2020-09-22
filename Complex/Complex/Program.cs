using System;
using System.Text;

namespace Complex
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.OutputEncoding = Encoding.Unicode;
            Console.InputEncoding = Encoding.Unicode;

            Complex z = new Complex(2, 3);
            Complex z1;
            z1 = z - (z * z * z - 1) / (3 * z * z);     
            //-----просто перевірки-----
            // z1 = z * z * z;
            //z1 = z * z * z - 1;
            //z1 = z - (z * z * z - 1);
            //z1 = 3 * z * z;            
            Console.WriteLine(" Результат z1 = {0}", z1);
        }
    }
}
