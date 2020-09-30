using System;
using System.Collections.Generic;
using System.Text;

namespace Parking
{

    public enum Model { Audi,Opel,Seat,Lada,Jeep};
    public enum Color { Black,Brown,White,Yellow,Silver};
    public enum Letter { UA,EU,US,CH,IN,RU,CAN};

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

