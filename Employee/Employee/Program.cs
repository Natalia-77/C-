using System;
using System.Text;

namespace Employee
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.OutputEncoding = Encoding.Unicode;
            Console.InputEncoding = Encoding.Unicode;

            //Employee[] empl = { new Employee("Petya", "Petrov", "Doctor", "12-YY", 1),
            //                    new Employee("Yura", "Yurco", "IT", "22-Y", 2),
            //                    new Employee("Ykura", "Yuco", "T", "123-oo", 3)};

            //foreach (Employee el in empl)
            //{
            //    el.Shows();
            //}
            //Console.WriteLine();

            //Employee e = new Employee();
            // Employee employee = new Employee("Petya", "Petrov", "Doctor", "123", 1);
            //  Employee employee2 = new Employee("Шевчук", "Іван", "Водій", "22-2", 523);
            //Employee employee1 = new Employee("Петрик", "Андрій", "Психіатр", "123-oo", 350);
            ////e.AddEmloyee();
            ////e.AddEmloyee();
            //Console.WriteLine("Show");
            //Employee.Show();
            //Console.WriteLine("Shows");
            //employee.Shows();
            //Console.WriteLine("Print");
            //Employee.Print();
            //employee.Print();
            //e.Delete();
            //Employee.Show();


            Menu menu = new Menu();
            menu.MainMenu();









        }
    }
}
