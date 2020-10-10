using System;
using System.Text;

namespace Employee
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.OutputEncoding = Encoding.Unicode;
            Console.InputEncoding = Encoding.Unicode;

            Menu menu = new Menu();
            menu.MainMenu();



        }
    }
}
