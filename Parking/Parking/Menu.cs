using System;
using System.Collections.Generic;
using System.Text;

namespace Parking
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
                if(choice!=0)
                {
                    Methods(choice);
                   
                }
            }
            while (choice != 7);
        }

        private int ShowMenu()
        {
            int choice = 0;
            Console.WriteLine();
            Console.WriteLine("1.Авторизуйтесь");
            Console.WriteLine("2.Поставити машину на парковку");
            Console.WriteLine("3.Випустити машину з парковки і роздрукувати квитанцію");
            Console.WriteLine("4.Показати список машин на парковці");
            Console.WriteLine("5.Показати статистику по парковці");
            Console.WriteLine("6.Показати наявність місць на парковці");
            Console.WriteLine("7.Вийти");
            Console.WriteLine("--------------------------------------");
            choice = Convert.ToInt32(Console.ReadLine());

            return choice;
        }

        private void Methods(int choice)
        {
            Parker parker = new Parker();
           
            switch (choice)
            {
                case 1:
                    {
                        string name="";
                        Console.Write("Введіть ім'я:");
                        name = Console.ReadLine();
                        Parker.parkername=name;
                        Console.Clear();
                        break;
                    }

                case 2:
                    {
                        parker.Add();
                        parker.ShowAllCars();
                        break;
                    }
                case 3:
                    {
                        parker.ShowAllCars();
                        parker.Del();
                        Console.WriteLine();                                            
                        break;
                    }
                case 4:
                    {
                        parker.ShowAllCars();
                        break;
                    }
                case 5:
                    {
                        parker.Statist();
                        break;
                    }
                case 6:
                    {
                        parker.Info();
                        break;
                    }
                case 7:
                    {
                        Console.WriteLine("Чао-какао!");
                        return;
                    }

            }
        }

    }
}
