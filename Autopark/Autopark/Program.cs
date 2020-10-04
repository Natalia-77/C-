using Parking;
using System;
using System.Text;

namespace Autopark
{
    class Program
    {
        static void Main()
        {
            Console.OutputEncoding = Encoding.Unicode;
            Console.InputEncoding = Encoding.Unicode;

            Menu menu = new Menu();
            menu.MainMenu();
        }

        
    }
}
