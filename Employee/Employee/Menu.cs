using System;
using System.Collections.Generic;
using System.Collections.Specialized;
using System.Text;

namespace Employee
{
    class Menu
    {
        public void MainMenu()
        {
            int choice = 0;
            do
            {
                choice = ShowMenu();
                Console.Clear();
                if (choice != 0)
                {
                    Methods(choice);

                }
            }
            while (choice != 6);
        }

        private int ShowMenu()
        {
            int choice = 0;
            Console.WriteLine();
            Console.WriteLine("1.Подивитись список всіх працівників");
            Console.WriteLine("2.Додати нового працівника");
            Console.WriteLine("3.Видалити дані про працівника");
            Console.WriteLine("4.Показати розгорнуті дані про обраного працівника");
            Console.WriteLine("5.Редагувати дані про працівника");
            Console.WriteLine("6.Вийти");
            Console.WriteLine("--------------------------------------");
            choice = Convert.ToInt32(Console.ReadLine());

            return choice;
        }

        private void Methods(int choice)
        {
            Employee e = new Employee();
            Employee[] empl = { new Employee("Petya", "Petrov", "Doctor", "12-YY", 10),
                                new Employee("Yura", "Yurco", "IT", "22-Y", 200),
                                new Employee("Ykura", "Yuco", "25YTT", "123-oo", 3)};
                     

            switch (choice)
            {
                case 1:
                    {
                        Employee.Show();
                        break;
                    }

                case 2:
                    {                      
                                           
                        e.AddEmloyee();
                        break;
                    }
                case 3:
                    {
                        //Employee.Delete();
                       // Employee.Show();

                        break;
                    }
                case 4:
                    {

                        foreach (Employee el in empl)
                        {
                            if(el is Employee)
                            {
                                el.Shows();
                            }
                           
                            
                        }
                        //Employee.ShowMyJournal();             
                        break;
                    }
                case 5:
                    {

                        break;
                    }

                case 6:
                    {
                        Console.WriteLine("Чао-какао!");
                        return;
                    }

            }
        }

    }

}

