using System;
using System.Collections.Generic;
using System.IO;
using System.Text;

namespace FileManager
{
    class Table
    {
        public void Tables()
        {
            
            string dirName = "D:\\";
            if (System.IO.Directory.Exists(dirName))
            {

                int count = 0;
                string[] dirs = Directory.GetDirectories(dirName);
               
                Console.BackgroundColor = ConsoleColor.DarkBlue;
                Console.ForegroundColor = ConsoleColor.Black;
                Console.WriteLine($"╔═════════════════════{dirName}══════════════════════╗");
                Console.WriteLine("║     Name        │  Size         │  Date      ║");

                foreach (var s in dirs)
                {
                    if (s.Length > 10)
                    {
                        Console.WriteLine($"║{s.Substring(3, 8) + (char)16,-10}       │               │ {new FileInfo(dirName).CreationTime}           ║");
                        count++;

                    }
                    else
                    {
                        Console.WriteLine($"║{s.Substring(3),-10}       │               │            ║");
                        count++;
                    }


                }
                if (count < 20)
                {
                    for (int i = 0; i < 20 - count; i++)
                    {
                        Console.WriteLine("║                 │               │            ║");
                    }
                    Console.WriteLine("║─────────────────┼───────────────┼────────────║");
                }


                Console.BackgroundColor = ConsoleColor.Black;
                Console.ForegroundColor = ConsoleColor.White;

            }

        }






    }
}
