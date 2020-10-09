﻿using System;
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
            
            
            //Employee employee = new Employee("Petya", "Petrov", "Doctor", "123", 1);
            Employee employee2 = new Employee("Шевчук", "Іван", "Водій", "22-2", 523);    

            switch (choice)
            {
                case 1:
                    {
                        
                        Employee.ShowMyJournal();
                        break;
                    }

                case 2:
                    {

                        Employee employee3 = new Employee("Рома", "Кравчук", "Студент", "8-HJH", 200);
                        
                        break;
                    }
                case 3:
                    {
                        Employee employee4 = new Employee("Міла", "Сидорова", "Студент", "77-HJH", 20);
                        //Employee.Delete();
                        // Employee.Show();

                        break;
                    }
                case 4:
                    {

                        Employee.ShowMyJournal();             
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

