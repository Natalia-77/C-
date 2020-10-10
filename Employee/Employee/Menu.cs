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
            Console.WriteLine("2.Додати працівника з коректними даними");
            Console.WriteLine("3.Додати працівника з некоректними даними (Exception)");
            Console.WriteLine("4.Видалити працівника зі списку");
            Console.WriteLine("5.Показати наявні прізвища працівників");
            Console.WriteLine("6.Вийти");
            Console.WriteLine("--------------------------------------");
            choice = Convert.ToInt32(Console.ReadLine());

            return choice;
        }

        private void Methods(int choice)
        {

            
            Employee employee2 = new Employee("Шевчук", "Іван", "Водій", "22", 523);
            Employee employee1 = new Employee("Іванова", "Марта", "Лікар", "123", 155);


            switch (choice)
            {
                case 1:
                    {                        
                        Employee.Show();
                        break;
                    }

                case 2:
                    {
                        Employee employee3 = new Employee("Коваль", "Олег", "Психіатр", "66", 200);
                        break;
                    }
                case 3:
                    {                        
                        Employee employee4 = new Employee("Міл2а", "Сидо22рова", "Санітарка", "77-С", 300);
                        break;
                    }               
                case 4:
                    {
                        Employee.Show();
                        Employee.Delete();
                        break;
                    }
                case 5:
                    {
                        Employee.ShowMyJournal();                        
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

