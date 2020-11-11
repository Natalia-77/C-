using System;
using System.Collections.Generic;
using System.IO;
using System.Text;

namespace Total_Commander
{
    class Table
    {
       

        /// <summary>
        ///  каркас таблиці для виводу лівої і правої таблиці.
        /// </summary>

        public void MainTab(int x,int y)
        {
            Console.BackgroundColor = ConsoleColor.DarkBlue;
            ///x=0;y=2;
            Console.SetCursorPosition(x, y);
            Console.WriteLine("╔════════════════════╤═══════════╤═════════════╤════════════╗");
            Console.SetCursorPosition(x, y+1);
            Console.Write("║    ");
            Console.ForegroundColor = ConsoleColor.Yellow;
            Console.Write("Name");
            Console.ForegroundColor = ConsoleColor.Cyan;
            Console.Write("            │   ");
            Console.ForegroundColor = ConsoleColor.Yellow;
            Console.Write("Size");
            Console.ForegroundColor = ConsoleColor.Cyan;
            Console.Write("    │  ");
            Console.ForegroundColor = ConsoleColor.Yellow;
            Console.Write("Date");
            Console.ForegroundColor = ConsoleColor.Cyan;
            Console.Write("       │ ");
            Console.ForegroundColor = ConsoleColor.Yellow;
            Console.Write("Time");
            Console.ForegroundColor = ConsoleColor.Cyan;
            Console.Write("       ║");

            for (int i = 1; i < 20; i++)
            {
                Console.SetCursorPosition(x, y + 1 + i);
                Console.WriteLine("║                    │           │             │            ║");
            }
            Console.SetCursorPosition(x,y+21 );
            Console.WriteLine("╟────────────────────┴───────────┴─────────────┴────────────╢");
            Console.SetCursorPosition(x, y + 22);
            Console.WriteLine("║                                                           ║");
            Console.SetCursorPosition(x, y+23);
            Console.WriteLine("╚═══════════════════════════════════════════════════════════╝");
            Console.ResetColor();

        }


        /// <summary>
        ///  Меню з вказаними клавішами в нижній частині основної таблиці.
        /// </summary>
        /// 
        public void Keys(int x,int y)
        {
          
            string[] menu = { "F3 View" ,"F4 Edit", "F5 Copy",
                "F6 Move", "F7 Create", "F8 Rename",
                "F9 Delete", "F10 Exit" };

            int item_width = FilePanel.console_width / menu.Length;
          
            for (int i=0;i<menu.Length;i++)
            {
                Console.BackgroundColor = ConsoleColor.Gray;
                Console.ForegroundColor = ConsoleColor.DarkBlue;
                Console.SetCursorPosition(x+i*item_width, y + 24 );
                Console.Write(menu[i]+'\t');
                Console.ResetColor();
            }

        }

    }
}
