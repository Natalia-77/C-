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
            Console.CursorVisible = false;
            string dirName = "C:\\";
            if (System.IO.Directory.Exists(dirName))
            {
                string[] dirs = Directory.GetDirectories(dirName);//папки.
                var dir = new DirectoryInfo(dirName);
                FileInfo[] files = dir.GetFiles();// файли.              

               // Console.BackgroundColor = ConsoleColor.DarkBlue;
                //Console.ForegroundColor = ConsoleColor.Yellow;

                // З"єднані два масива.
                var items = new string[dirs.Length + files.Length];
                for (var i = 0; i < dirs.Length; i++)
                    items[i] = dirs[i];
                for (var i = 0; i < files.Length; i++)
                    items[dirs.Length + i] = files[i].ToString();

                int counter = 0;             

                ConsoleKeyInfo key = new ConsoleKeyInfo();               


                    do
                    {
                  
                    if (key.Key == ConsoleKey.UpArrow)
                        {
                            if (counter == 0)
                                counter = items.Length - 1;
                            else counter--;
                        }
                        else if (key.Key == ConsoleKey.DownArrow)
                        {
                            if (counter == items.Length - 1)
                                counter = 0;
                            else
                                counter++;
                        }

                        for (int j = 0; j < dirs.Length; j++)
                        {

                            if (dirs[j].Length > 10)
                            {
                                if (j == counter)
                                {
                                    Console.BackgroundColor = ConsoleColor.Blue;
                                    Console.ForegroundColor = ConsoleColor.Black;
                                    Console.SetCursorPosition(62, 4 + j);
                                    Console.WriteLine(dirs[j].Substring(3, 8) + (char)16);
                                   
                                }
                                else
                                {
                                    Console.BackgroundColor = ConsoleColor.DarkBlue;
                                    Console.ForegroundColor = ConsoleColor.Yellow;
                                    Console.SetCursorPosition(62, 4 + j);
                                    Console.WriteLine(dirs[j].Substring(3, 8) + (char)16);
                                   
                                }

                            }

                            else
                            {
                                if (j == counter)
                                {
                                    Console.BackgroundColor = ConsoleColor.Blue;
                                    Console.ForegroundColor = ConsoleColor.Black;
                                    Console.SetCursorPosition(62, 4 + j);
                                    Console.WriteLine(dirs[j].Substring(3));
                                  
                                }
                                else
                                {
                                    Console.BackgroundColor = ConsoleColor.DarkBlue;
                                    Console.ForegroundColor = ConsoleColor.Yellow;
                                    Console.SetCursorPosition(62, 4 + j);
                                    Console.WriteLine(dirs[j].Substring(3));
                                    
                                }

                            }
                        }

                        for (int i = 0; i < files.Length; i++)
                        {

                            if (files[i].Name.Length <= 10)
                            {
                                if (i + dirs.Length == counter)
                                {
                                    Console.BackgroundColor = ConsoleColor.Blue;
                                    Console.ForegroundColor = ConsoleColor.Black;
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

                                    Console.BackgroundColor = ConsoleColor.DarkBlue;
                                    Console.ForegroundColor = ConsoleColor.Yellow;
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

                            }
                            else
                            {
                                if (i + dirs.Length == counter)
                                {
                                    Console.BackgroundColor = ConsoleColor.Blue;
                                    Console.ForegroundColor = ConsoleColor.Black;
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
                                    Console.ResetColor();
                                }
                                else
                                {
                                    Console.BackgroundColor = ConsoleColor.DarkBlue;
                                    Console.ForegroundColor = ConsoleColor.Yellow;
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
                                    Console.ResetColor();
                                }

                            }

                        }
                    
                    } while ((key = Console.ReadKey()).Key != ConsoleKey.Tab);                              
                     Left();

                

            }
           



        }

        public void Left()
        {
            Console.CursorVisible = false;
            string dirName = "D://SkillUp";
            if (System.IO.Directory.Exists(dirName))
            {
                // Записала два масива(з директоріями і файлами) в ліст.
                IEnumerable<string> Allfiles;

                // Масив з директорями.
                string[] dirs = Directory.GetDirectories(dirName);
                var dir = new DirectoryInfo(dirName);
                
                //Масив з файлами.
                FileInfo[] files = dir.GetFiles();             

                //Console.BackgroundColor = ConsoleColor.DarkBlue;
                //Console.ForegroundColor = ConsoleColor.Yellow;

                // З"єднані два масива.
                var items = new string[dirs.Length + files.Length];
                for (var i = 0; i < dirs.Length; i++)
                    items[i] = dirs[i];
                for (var i = 0; i < files.Length; i++)
                    items[dirs.Length + i] = files[i].ToString();

                int counter = 0;
                //int identity = 0;

                // Значення з масиву тепер всі додані до ліста.
                 Allfiles = items;

                //Сумарна довжина нового списку на основі суми двох масивів.
                 int listlength = dirs.Length + files.Length;

                // Перевірка виводу всього ліста в консоль.
                //foreach (var item in Allfiles)
                //{
                //    Console.SetCursorPosition(2, 4 + identity);
                //    Console.WriteLine(item);
                //    identity++;
                //}

                // Розмір кроку для пагінації.
                int step = listlength - 20;

                // Якщо довжина менше 20,то крок=0.
                if (listlength < 20)
                {
                    step = 0;
                }


                //ConsoleKeyInfo key = new ConsoleKeyInfo();
                //do
                //{
                //    if (key.Key == ConsoleKey.UpArrow)
                //    {
                //        if (counter == 0)
                //            counter =  Allfiles.Count() - 1;
                //        else counter--;
                //    }
                //    else if (key.Key == ConsoleKey.DownArrow)
                //    {
                //        if (counter == Allfiles.Count() - 1)
                //            counter = 0;
                //        else
                //            counter++;
                //    }


                //    foreach (var item in Allfiles.Skip(0).Take(19))
                //    {


                //        if (item.Contains('.'))
                //        {
                //            if (item[identity] == counter)
                //            {
                //                Console.BackgroundColor = ConsoleColor.White;
                //                Console.ForegroundColor = ConsoleColor.Black;
                //                Console.SetCursorPosition(2, 4 + identity);
                //                ///Console.WriteLine(item.Substring(item.LastIndexOf("\\")+1) + (char)16);   
                //                var name = item.Substring(item.LastIndexOf("\\") + 1) + (char)16;
                //                ///Console.WriteLine(name.Split(".").Last());//тільки розширення.
                //                Console.WriteLine(name.Substring(0, name.LastIndexOf(".")));
                //                identity++;
                //                Console.ResetColor();
                //            }
                //            else
                //            {
                //                Console.SetCursorPosition(2, 4 + identity);
                //                ///Console.WriteLine(item.Substring(item.LastIndexOf("\\")+1) + (char)16);   
                //                var name = item.Substring(item.LastIndexOf("\\") + 1) + (char)16;
                //                ///Console.WriteLine(name.Split(".").Last());//тільки розширення.
                //                Console.WriteLine(name.Substring(0, name.LastIndexOf(".")));
                //                identity++;

                //            }


                //        }
                //        else
                //        {
                //            if (item.Length < 20)
                //            {
                //                if (item[identity] == counter)
                //                {
                //                    Console.BackgroundColor = ConsoleColor.White;
                //                    Console.ForegroundColor = ConsoleColor.Black;
                //                    Console.SetCursorPosition(2, 4 + identity);
                //                    var name = item.Substring(item.IndexOf("\\") + 1) + (char)16;
                //                    Console.WriteLine(name);
                //                    identity++;
                //                    Console.ResetColor();
                //                }
                //                else
                //                {
                //                    Console.SetCursorPosition(2, 4 + identity);
                //                    var name = item.Substring(item.IndexOf("\\") + 1) + (char)16;
                //                    Console.WriteLine(name);
                //                    identity++;
                //                }
                //            }
                //            else
                //            {
                //                if (item[identity] == counter)
                //                {
                //                    Console.BackgroundColor = ConsoleColor.White;
                //                    Console.ForegroundColor = ConsoleColor.Black;
                //                    Console.SetCursorPosition(2, 4 + identity);
                //                    var name = item.Substring(item.IndexOf("\\") + 1, 8) + (char)16;
                //                    Console.WriteLine(name);
                //                    identity++;
                //                    Console.ResetColor();
                //                }
                //                else
                //                {
                //                    Console.SetCursorPosition(2, 4 + identity);
                //                    var name = item.Substring(item.IndexOf("\\") + 1, 8) + (char)16;
                //                    Console.WriteLine(name);
                //                    identity++;
                //                }
                //            }

                //        }


                //    }
                //} while ((key = Console.ReadKey()).Key != ConsoleKey.Enter);



                //}
                // Якщо менше 20-просто виводимо в консоль.
                //else
                //{
                //    foreach (var item in Allfiles)
                //    {
                //        Console.SetCursorPosition(2, 4 + identity);
                //        Console.WriteLine(item);
                //        identity++;
                //    }

                //}


                    ConsoleKeyInfo key = new ConsoleKeyInfo();
                    
                        do
                        {


                            if (key.Key == ConsoleKey.UpArrow)
                            {
                                if (counter == 0)
                                    counter = items.Length - 1;
                                else counter--;
                            }
                            else if (key.Key == ConsoleKey.DownArrow)
                            {
                                if (counter == items.Length - 1)
                                    counter = 0;
                                else
                                    counter++;
                            }

                            for (int j = 0; j < dirs.Length; j++)
                            {

                                if (dirs[j].Length > 10)
                                {
                                    if (j == counter)
                                    {
                                        Console.BackgroundColor = ConsoleColor.Blue;
                                        Console.ForegroundColor = ConsoleColor.Black;
                                        Console.SetCursorPosition(2, 4 + j);
                                        Console.WriteLine(dirs[j].Substring(3, 8) + (char)16);
                                        Console.ResetColor();
                                    }
                                    else
                                    {
                                        Console.BackgroundColor = ConsoleColor.DarkBlue;
                                        Console.ForegroundColor = ConsoleColor.Yellow;
                                        Console.SetCursorPosition(2, 4 + j);
                                        Console.WriteLine(dirs[j].Substring(3, 8) + (char)16);
                                        //Console.ResetColor();
                                    }
                                }

                                else
                                {
                                    if (j == counter)
                                    {
                                        Console.BackgroundColor = ConsoleColor.Blue;
                                        Console.ForegroundColor = ConsoleColor.Black;
                                        Console.SetCursorPosition(2, 4 + j);
                                        Console.WriteLine(dirs[j].Substring(3));
                                        //Console.ResetColor();
                                    }
                                    else
                                    {
                                        Console.BackgroundColor = ConsoleColor.DarkBlue;
                                        Console.ForegroundColor = ConsoleColor.Yellow;
                                        Console.SetCursorPosition(2, 4 + j);
                                        Console.WriteLine(dirs[j].Substring(3));
                                        //Console.ResetColor();
                                    }

                                }
                            }

                            for (int i = 0; i < files.Length; i++)
                            {

                                if (files[i].Name.Length <= 10)
                                {
                                    if (i + dirs.Length == counter)
                                    {
                                        Console.BackgroundColor = ConsoleColor.Blue;
                                        Console.ForegroundColor = ConsoleColor.Black;
                                        Console.SetCursorPosition(2, 4 + i + dirs.Length);
                                        var extention = Directory.GetFiles(dirName, files[i].Name + ".*").FirstOrDefault();
                                        var res = Path.GetFileNameWithoutExtension(files[i].Name);
                                        Console.WriteLine($"{res.Substring(0, files[i].Name.Length - 5)}  ");
                                        Console.SetCursorPosition(16, 4 + i + dirs.Length);
                                        Console.WriteLine($"{ Path.GetExtension(extention).Substring(1)}");
                                        Console.SetCursorPosition(22, 4 + i + dirs.Length);
                                        Console.WriteLine($"{ files[i].Length,2}");
                                        Console.SetCursorPosition(36, 4 + i + dirs.Length);
                                        Console.WriteLine(files[i].CreationTime.ToString($"{0:dd/MM/yyyy}"));
                                        Console.SetCursorPosition(50, 4 + i + dirs.Length);
                                        Console.WriteLine(files[i].CreationTime.ToString($"{0:hh:mm:ss}"));
                                        // Console.ResetColor();
                                    }
                                    else
                                    {
                                        Console.BackgroundColor = ConsoleColor.DarkBlue;
                                        Console.ForegroundColor = ConsoleColor.Yellow;
                                        Console.SetCursorPosition(2, 4 + i + dirs.Length);
                                        var extention = Directory.GetFiles(dirName, files[i].Name + ".*").FirstOrDefault();
                                        var res = Path.GetFileNameWithoutExtension(files[i].Name);
                                        Console.WriteLine($"{res.Substring(0, files[i].Name.Length - 5)}  ");
                                        Console.SetCursorPosition(16, 4 + i + dirs.Length);
                                        Console.WriteLine($"{ Path.GetExtension(extention).Substring(1)}");
                                        Console.SetCursorPosition(22, 4 + i + dirs.Length);
                                        Console.WriteLine($"{ files[i].Length,2}");
                                        Console.SetCursorPosition(36, 4 + i + dirs.Length);
                                        Console.WriteLine(files[i].CreationTime.ToString($"{0:dd/MM/yyyy}"));
                                        Console.SetCursorPosition(50, 4 + i + dirs.Length);
                                        Console.WriteLine(files[i].CreationTime.ToString($"{0:hh:mm:ss}"));
                                        //Console.ResetColor();
                                    }

                                }
                                else
                                {
                                    if (i + dirs.Length == counter)
                                    {
                                        Console.BackgroundColor = ConsoleColor.Blue;
                                        Console.ForegroundColor = ConsoleColor.Black;
                                        Console.SetCursorPosition(2, 4 + i + dirs.Length);
                                        var extention = Directory.GetFiles(dirName, files[i].Name + ".*").FirstOrDefault();
                                        var res = Path.GetFileNameWithoutExtension(files[i].Name);
                                        Console.WriteLine($"{res.Substring(0, files[i].Name.Length - 6) + (char)16}");
                                        Console.SetCursorPosition(16, 4 + i + dirs.Length);
                                        Console.WriteLine($"{ Path.GetExtension(extention).Substring(1)}");
                                        Console.SetCursorPosition(22, 4 + i + dirs.Length);
                                        Console.WriteLine($"{ files[i].Length,2}");
                                        Console.SetCursorPosition(36, 4 + i + dirs.Length);
                                        Console.WriteLine(files[i].CreationTime.ToString($"{0:dd/MM/yyyy}"));
                                        Console.SetCursorPosition(50, 4 + i + dirs.Length);
                                        Console.WriteLine(files[i].CreationTime.ToString($"{0:hh:mm:ss}"));
                                        //Console.ResetColor();
                                    }
                                    else
                                    {
                                        Console.BackgroundColor = ConsoleColor.DarkBlue;
                                        Console.ForegroundColor = ConsoleColor.Yellow;
                                        Console.SetCursorPosition(2, 4 + i + dirs.Length);
                                        var extention = Directory.GetFiles(dirName, files[i].Name + ".*").FirstOrDefault();
                                        var res = Path.GetFileNameWithoutExtension(files[i].Name);
                                        Console.WriteLine($"{res.Substring(0, files[i].Name.Length - 6) + (char)16}");
                                        Console.SetCursorPosition(16, 4 + i + dirs.Length);
                                        Console.WriteLine($"{ Path.GetExtension(extention).Substring(1)}");
                                        Console.SetCursorPosition(22, 4 + i + dirs.Length);
                                        Console.WriteLine($"{ files[i].Length,2}");
                                        Console.SetCursorPosition(36, 4 + i + dirs.Length);
                                        Console.WriteLine(files[i].CreationTime.ToString($"{0:dd/MM/yyyy}"));
                                        Console.SetCursorPosition(50, 4 + i + dirs.Length);
                                        Console.WriteLine(files[i].CreationTime.ToString($"{0:hh:mm:ss}"));
                                        //Console.ResetColor();
                                    }

                                }


                            }


                        } while ((key = Console.ReadKey()).Key != ConsoleKey.Tab);
               
                       Right();
                
                



            }


















        }
    }
}
