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

            Console.SetCursorPosition(50, 2);
            Console.WriteLine("╔════════════╤═════════╤════════╤══════╗");
            Console.SetCursorPosition(50, 3);
            Console.Write("║    ");
            Console.ForegroundColor = ConsoleColor.Yellow;
            Console.Write("Name");
            Console.ForegroundColor = ConsoleColor.Cyan;
            Console.Write("    │   ");
            Console.ForegroundColor = ConsoleColor.Yellow;
            Console.Write("Size");
            Console.ForegroundColor = ConsoleColor.Cyan;
            Console.Write("  │  ");
            Console.ForegroundColor = ConsoleColor.Yellow;
            Console.Write("Date");
            Console.ForegroundColor = ConsoleColor.Cyan;
            Console.Write("  │ ");
            Console.ForegroundColor = ConsoleColor.Yellow;
            Console.Write("Time");
            Console.ForegroundColor = ConsoleColor.Cyan;
            Console.Write(" ║");

            for (int i = 1; i < 20; i++)
            {
                Console.SetCursorPosition(50, 3 + i);
                Console.WriteLine("║               │                │                │             ║");
            }
            Console.SetCursorPosition(50, 23);
            Console.WriteLine("╟────────────┴─────────┴────────┴──────╢");
            Console.SetCursorPosition(50, 24);
            Console.WriteLine("║                                      ║");
            Console.SetCursorPosition(50, 25);
            Console.WriteLine("╚══════════════════════════════════════╝");
            Console.ResetColor();

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
                        //Console.WriteLine($"{res.Substring(0, files[i].Name.Length - 5) + (char)16}");
                        Console.SetCursorPosition(22, 4 + i + dirs.Length);
                        Console.WriteLine($"{ files[i].Length,2}");
                        Console.SetCursorPosition(36, 4 + i + dirs.Length);
                        Console.WriteLine(files[i].CreationTime.ToString($"{0:dd/MM/yyyy}"));
                        Console.SetCursorPosition(50, 4 + i + dirs.Length);
                        Console.WriteLine(files[i].CreationTime.ToString($"{0:hh:mm:ss}"));

                    }


                }

                //foreach (var s in dirs)
                //{

                //    if (s.Length > 10)
                //    {                       
                //        Console.SetCursorPosition(2, 4);                                          
                //        Console.WriteLine(s.Substring(3, 8) + (char)16);
                //        //count++;
                //    }

                //    else
                //    {

                //        Console.SetCursorPosition(2, 4+count);
                //        Console.WriteLine(s.Substring(3));                        
                //        //count++;
                //    }





                // if (dirs.Length >= count)
                //{
                //foreach (var item in files)
                //{
                //    if (item.Name.Length >= 10)
                //    {
                //        Console.SetCursorPosition(2, 4 + count);
                //        Console.WriteLine(item.Name.Substring(0, item.Name.Length - 6) + (char)16);
                //        Console.SetCursorPosition(22, 4 + count);
                //        Console.WriteLine($"{ item.Length,6}");                           
                //        Console.SetCursorPosition(29, 4+count);
                //        Console.WriteLine(item.CreationTime.ToString($"{0:dd/MM/yyyy}"));
                //        Console.SetCursorPosition(41, 4 + count);
                //        Console.WriteLine(item.CreationTime.ToString($"{0:hh:mm:ss}"));

                //    }

                //    else
                //    {
                //        Console.SetCursorPosition(2, 4 + count);
                //        Console.WriteLine(item.Name.Substring(0, item.Name.Length - 5));
                //        Console.SetCursorPosition(22, 4 + count);
                //        Console.WriteLine($"{ item.Length,6}");
                //        Console.SetCursorPosition(29, 4 + count);
                //        Console.WriteLine(item.CreationTime.ToString($"{0:dd/MM/yyyy}"));
                //        Console.SetCursorPosition(41, 4 + count);
                //        Console.WriteLine(item.CreationTime.ToString($"{0:hh:mm:ss}"));
                //       // count++;
                //    }

                //}

                // }               







            }
        //    public void TablesLeft()
        //{

        //    string dirName = "D:\\";
        //    if (System.IO.Directory.Exists(dirName))
        //    {

        //        int count = 0;
        //        string[] dirs = Directory.GetDirectories(dirName);
        //        var dir = new DirectoryInfo(dirName);
        //        FileInfo[] files = dir.GetFiles(".", SearchOption.AllDirectories);// файли.

        //        Console.BackgroundColor = ConsoleColor.DarkBlue;
        //        Console.ForegroundColor = ConsoleColor.Yellow;
        //        Console.SetCursorPosition(0, 2);
        //        Console.WriteLine($"╔═════════════════════{dirName}══════════════════════╗");
        //        // Console.SetCursorPosition(20,3);

        //        Console.WriteLine("║     Name     │  Size         │  Date         ║");
        //        //Console.SetCursorPosition(20, 4);            


        //        foreach (var s in dirs)
        //        {

        //            if (s.Length > 10)
        //            {

        //                //Console.SetCursorPosition(20, 4+count);
        //                Console.WriteLine($"║{s.Substring(3, 8) + (char)16,-5}     │               │{new FileInfo(dirName).CreationTime.ToString($"{0:dd/MM/yyyy}")}     ║");
        //                count++;

        //            }
        //            else
        //            {

        //                //Console.SetCursorPosition(20, 4+count);
        //                Console.WriteLine($"║{s.Substring(3),-5}       │               │{new FileInfo(dirName).CreationTime.ToString($"{0:dd/MM/yyyy}")}     ║");
        //                count++;
        //            }



        //        }

        //        if (count < 20)
        //        {
        //            for (int i = 0; i < 20 - count; i++)
        //            {
        //                //Console.SetCursorPosition(20, 4+count + i);
        //                Console.WriteLine("║              │               │               ║");
        //            }
        //            //Console.SetCursorPosition(20,24);
        //            Console.WriteLine("║──────────────┼───────────────┼───────────────║");
        //            //Console.SetCursorPosition(20, 25);
        //            Console.WriteLine("║              │               │               ║");
        //            //Console.SetCursorPosition(20, 26);
        //            Console.WriteLine("║              │               │               ║");
        //            //Console.SetCursorPosition(20, 27);
        //            Console.WriteLine("╚══════════════════════════════════════════════╝");
        //        }


        //        Console.BackgroundColor = ConsoleColor.Black;
        //        Console.ForegroundColor = ConsoleColor.White;
        //        //Console.ResetColor();

        //    }

        //}

        //public void TablesRight()
        //{

        //    string dirName = "D:/SkillUp";
        //    if (System.IO.Directory.Exists(dirName))
        //    {

        //        int count = 0;

        //        string[] dirs = Directory.GetDirectories(dirName);//папки.
        //        var dir = new DirectoryInfo(dirName);
        //        FileInfo[] files = dir.GetFiles();// файли.              

        //        Console.BackgroundColor = ConsoleColor.DarkBlue;
        //        Console.ForegroundColor = ConsoleColor.Yellow;
        //        Console.SetCursorPosition(48, 2);
        //        Console.WriteLine($"╔═════════════════════{dirName}══════════════════════╗");
        //        Console.SetCursorPosition(48, 3);

        //        Console.WriteLine("║     Name     │  Size         │  Date         ║");
        //        Console.SetCursorPosition(48, 4);


        //        foreach (var s in dirs)
        //        {

        //            if (s.Length > 10)
        //            {
        //                //Console.SetCursorPosition(x, y + (count * i));
        //                Console.SetCursorPosition(48, 4 + count);
        //                Console.WriteLine($"║{s.Substring(3, 8) + (char)16,-5}                    {new FileInfo(dirName).CreationTime.ToString($"{0:dd/MM/yyyy}")}     ║");
        //                count++;

        //            }

        //            else
        //            {
        //                // Console.SetCursorPosition(x, y + (count * i));
        //                Console.SetCursorPosition(48, 4 + count);
        //                Console.WriteLine($"║{s.Substring(3),-5}                      {new FileInfo(dirName).CreationTime.ToString($"{0:dd/MM/yyyy}")}     ║");
        //                count++;
        //            }
                    
                   

        //        }
               
        //        if (dirs.Length >= count)
        //        {
        //            foreach (var item in files)
        //            {
        //                if(item.Name.Length>=10)
        //                {
        //                    Console.SetCursorPosition(48, 4 + count);
        //                    Console.WriteLine($"║{item.Name.Substring(0, item.Name.Length-6) + (char)16,-10}                   │{item.CreationTime.ToString($"{0:dd/MM/yyyy}")}     ║");
        //                    count++;
        //                }

        //                else
        //                {
        //                    Console.SetCursorPosition(48, 4 + count);
        //                    Console.WriteLine($"║{item.Name.Substring(0, item.Name.Length - 5),-10}                   │{item.CreationTime.ToString($"{0:dd/MM/yyyy}")}     ║");
        //                    count++;
        //                }

        //            }
                    
        //        }
        //        if (count < 20)
        //        {
        //            for (int i = 0; i < 20 - count; i++)
        //            {
        //                Console.SetCursorPosition(48, 4 + count + i);
        //                Console.WriteLine("║              │               │               ║");
        //            }
        //            Console.SetCursorPosition(48, 24);
        //            Console.WriteLine("║──────────────┼───────────────┼───────────────║");
        //            Console.SetCursorPosition(48, 25);
        //            Console.WriteLine("║              │               │               ║");
        //            Console.SetCursorPosition(48, 26);
        //            Console.WriteLine("║              │               │               ║");
        //            Console.SetCursorPosition(48, 27);
        //            Console.WriteLine("╚══════════════════════════════════════════════╝");
        //        }


        //        Console.BackgroundColor = ConsoleColor.Black;
        //        Console.ForegroundColor = ConsoleColor.White;


        //    }



        //}
        //public void Showfiles()
        //{
        //    string dirName = "D:/SkillUp";
        //    if (System.IO.Directory.Exists(dirName))
        //    {

               
        //        string[] dirs = Directory.GetDirectories(dirName);//папки.
        //        var dir = new DirectoryInfo(dirName);
        //        FileInfo[] files = dir.GetFiles(".", SearchOption.AllDirectories);// файли.
        //        foreach (var item in files)
        //        {
        //            Console.WriteLine(item);
        //        }



        //    }

        }
    }
}
