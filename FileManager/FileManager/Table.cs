using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;

namespace FileManager
{
    class Table
    {

        public void MainTableft()
        {
            Console.BackgroundColor = ConsoleColor.DarkBlue;

            Console.SetCursorPosition(0,2);
            Console.WriteLine("╔════════════════════╤═══════════╤═════════════╤════════════╗");
            Console.SetCursorPosition(0,3);
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
                Console.SetCursorPosition(0,3 + i);
                Console.WriteLine("║                    │           │             │            ║");
            }
            Console.SetCursorPosition(0,23);
            Console.WriteLine("╟────────────────────┴───────────┴─────────────┴────────────╢");
            Console.SetCursorPosition(0,24);
            Console.WriteLine("║                                                           ║");
            Console.SetCursorPosition(0,25);
            Console.WriteLine("╚═══════════════════════════════════════════════════════════╝");
            Console.ResetColor();

        }

        public void MainTabright()
        {
            Console.BackgroundColor = ConsoleColor.DarkBlue;

            Console.SetCursorPosition(61, 2);
            Console.WriteLine("╔════════════════════╤═══════════╤═════════════╤════════════╗");
            Console.SetCursorPosition(61, 3);
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
                Console.SetCursorPosition(61, 3 + i);
                Console.WriteLine("║                    │           │             │            ║");
            }
            Console.SetCursorPosition(61, 23);
            Console.WriteLine("╟────────────────────┴───────────┴─────────────┴────────────╢");
            Console.SetCursorPosition(61, 24);
            Console.WriteLine("║                                                           ║");
            Console.SetCursorPosition(61, 25);
            Console.WriteLine("╚═══════════════════════════════════════════════════════════╝");
            Console.ResetColor();
        }

        public void Right()
        {

            string dirName = "D:/SkillUp";
            if (System.IO.Directory.Exists(dirName))
            {


                string[] dirs = Directory.GetDirectories(dirName);//папки.
                var dir = new DirectoryInfo(dirName);
                FileInfo[] files = dir.GetFiles();// файли.              

                Console.BackgroundColor = ConsoleColor.DarkBlue;
                Console.ForegroundColor = ConsoleColor.Yellow;

                for (int j = 0; j < dirs.Length; j++)
                {

                    if (dirs[j].Length > 10)
                    {
                        Console.SetCursorPosition(62, 4 + j);
                        Console.WriteLine(dirs[j].Substring(3, 8) + (char)16);
                    }

                    else
                    {

                        Console.SetCursorPosition(62, 4 + j);
                        Console.WriteLine(dirs[j].Substring(3));

                    }
                }

                for (int i = 0; i < files.Length; i++)
                {

                    if (files[i].Name.Length <= 10)
                    {
                        Console.SetCursorPosition(62, 4 + i + dirs.Length);
                        var extention = Directory.GetFiles(dirName, files[i].Name + ".*").FirstOrDefault();
                        var res = Path.GetFileNameWithoutExtension(files[i].Name);
                        Console.WriteLine($"{res.Substring(0, files[i].Name.Length - 5)}  ");
                        Console.SetCursorPosition(78, 4 + i + dirs.Length);
                        Console.WriteLine($"{ Path.GetExtension(extention).Substring(1)}");
                        Console.SetCursorPosition(84, 4 + i + dirs.Length);
                        Console.WriteLine($"{ files[i].Length,2}");
                        Console.SetCursorPosition(98, 4 + i + dirs.Length);
                        Console.WriteLine(files[i].CreationTime.ToString($"{0:dd/MM/yyyy}"));
                        Console.SetCursorPosition(112, 4 + i + dirs.Length);
                        Console.WriteLine(files[i].CreationTime.ToString($"{0:hh:mm:ss}"));

                    }
                    else
                    {
                        Console.SetCursorPosition(62, 4 + i + dirs.Length);
                        var extention = Directory.GetFiles(dirName, files[i].Name + ".*").FirstOrDefault();
                        var res = Path.GetFileNameWithoutExtension(files[i].Name);
                        Console.WriteLine($"{res.Substring(0, files[i].Name.Length - 6) + (char)16}");
                        Console.SetCursorPosition(78, 4 + i + dirs.Length);
                        Console.WriteLine($"{ Path.GetExtension(extention).Substring(1)}");
                        Console.SetCursorPosition(84, 4 + i + dirs.Length);
                        Console.WriteLine($"{ files[i].Length,2}");
                        Console.SetCursorPosition(98, 4 + i + dirs.Length);
                        Console.WriteLine(files[i].CreationTime.ToString($"{0:dd/MM/yyyy}"));
                        Console.SetCursorPosition(112, 4 + i + dirs.Length);
                        Console.WriteLine(files[i].CreationTime.ToString($"{0:hh:mm:ss}"));

                    }

                }
              
            }
        }

        public void Left()
        {

            string dirName = "D:/SkillUp";
            if (System.IO.Directory.Exists(dirName))
            {
                               

                string[] dirs = Directory.GetDirectories(dirName);//папки.
                var dir = new DirectoryInfo(dirName);
                FileInfo[] files = dir.GetFiles();// файли.              

                Console.BackgroundColor = ConsoleColor.DarkBlue;
                Console.ForegroundColor = ConsoleColor.Yellow;

                for (int j = 0; j < dirs.Length; j++)
                {

                    if (dirs[j].Length > 10)
                    {
                        Console.SetCursorPosition(2, 4 + j);
                        Console.WriteLine(dirs[j].Substring(3, 8) + (char)16);
                    }

                    else
                    {

                        Console.SetCursorPosition(2, 4 + j);
                        Console.WriteLine(dirs[j].Substring(3));

                    }
                }

                for(int i=0;i<files.Length;i++)
                {
                                       
                    if (files[i].Name.Length <= 10)
                    {
                        Console.SetCursorPosition(2, 4 +i+dirs.Length);                       
                        var extention = Directory.GetFiles(dirName, files[i].Name + ".*").FirstOrDefault();
                        var res=Path.GetFileNameWithoutExtension(files[i].Name);
                        Console.WriteLine($"{res.Substring(0, files[i].Name.Length - 5)}  ");
                        Console.SetCursorPosition(16, 4 + i + dirs.Length);
                        Console.WriteLine($"{ Path.GetExtension(extention).Substring(1)}");
                        Console.SetCursorPosition(22, 4+i+dirs.Length );
                        Console.WriteLine($"{ files[i].Length,2}");
                        Console.SetCursorPosition(36, 4+ i+dirs.Length);
                        Console.WriteLine(files[i].CreationTime.ToString($"{0:dd/MM/yyyy}"));
                        Console.SetCursorPosition(50, 4 +i+dirs.Length);
                        Console.WriteLine(files[i].CreationTime.ToString($"{0:hh:mm:ss}"));

                    }
                    else
                    {
                        Console.SetCursorPosition(2, 4 + i + dirs.Length);
                        var extention = Directory.GetFiles(dirName, files[i].Name + ".*").FirstOrDefault();
                        var res = Path.GetFileNameWithoutExtension(files[i].Name);
                        Console.WriteLine($"{res.Substring(0, files[i].Name.Length - 6)+(char)16}");
                        Console.SetCursorPosition(16, 4 + i + dirs.Length);
                        Console.WriteLine($"{ Path.GetExtension(extention).Substring(1)}");
                        Console.SetCursorPosition(22, 4 + i + dirs.Length);
                        Console.WriteLine($"{ files[i].Length,2}");
                        Console.SetCursorPosition(36, 4 + i + dirs.Length);
                        Console.WriteLine(files[i].CreationTime.ToString($"{0:dd/MM/yyyy}"));
                        Console.SetCursorPosition(50, 4 + i + dirs.Length);
                        Console.WriteLine(files[i].CreationTime.ToString($"{0:hh:mm:ss}"));

                    }


                }

            }







       

       
      







        }
    }
}
