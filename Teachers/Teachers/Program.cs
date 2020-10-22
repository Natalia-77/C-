﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Teachers
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.OutputEncoding = Encoding.Unicode;
            Console.InputEncoding = Encoding.Unicode;

            // Номер сторінки.
            int pagenumber = 0;

            // Кількість записів на одній сторінці.
            int pagecount = 6;
            bool flag = false;

            IEnumerable<Teacher> tea = Teacher.GetList();

            foreach (var item in tea)
            {
                Console.WriteLine(item);
            }
            Console.WriteLine("------------------------------------------------------------------");
            Console.ForegroundColor = ConsoleColor.Green;
            Console.WriteLine("Введіть номер сторінки для перегляду даних.");
            Console.WriteLine("Якщо ви захочете закінчити роботу і вийти,то натисніть цифру 0");
            Console.ResetColor();
            Console.WriteLine("-----------------------------------------------------------------\n");
            do
            {
                do
                {
                    try
                    {
                        Console.WriteLine("Enter number of page");
                        pagenumber = int.Parse(Console.ReadLine());
                       
                        if (pagenumber >= 1 && pagenumber <= 5)
                       {
                            flag = true;
                            int index = (pagenumber - 1) * pagecount;
                            IEnumerable<Teacher> res = tea.Skip(index).Take(pagecount);

                            // Загальна кількість елементів в колекції.
                            int f = tea.Count();

                            // Визначаю кількість сторінок,за умови,що на сторінці має бути 6 елементів.
                            double result = f / pagecount;
                            Console.Clear();
                            Console.WriteLine();
                            Console.ForegroundColor = ConsoleColor.Green;
                            Console.WriteLine($"Now display { pagenumber} in {result}");
                            Console.ResetColor();

                            Console.WriteLine("----------------------------------------------------------");
                            Console.WriteLine($"Name:           |Surname:                 | Salary:      |");
                            Console.WriteLine("----------------------------------------------------------");
                            foreach (Teacher t in res)
                            {
                                Console.WriteLine($"Name:{t._name,-10} |Surname: {t._surname,-15} | Salary: {t._salary} |");

                            }
                            Console.WriteLine("---------------------------------------------------------");
                            
                        }
                       
                        else if (pagenumber == 0)
                        {
                            Console.Clear();
                            Console.ForegroundColor = ConsoleColor.Red;
                            Console.WriteLine("You're out!Bye-bye.");
                            Console.ResetColor();
                            return;
                        }
                        else
                        {
                            throw new Exception();
                        }

                    }
                    catch (Exception)
                    {
                        Console.ForegroundColor = ConsoleColor.Red;
                        Console.WriteLine("Not correct! Try again.");
                        Console.ResetColor();
                        flag = false;
                    }
                } while (!flag);
               
            } while (true);
        }         
        
    }
}
