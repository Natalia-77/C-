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

            Employee[] empl = { new Employee("Petya", "Petrov", "Doctor", "12-YY", 1),
                                new Employee("Yura", "Yurco", "IT", "22-Y", 2),
                                new Employee("Ykura", "Y6uco", "T", "123-oo", 3)};

            foreach (Employee el in empl)
            {
                el.Shows();
            }
            Console.WriteLine();


            // Employee employee = new Employee("Petya", "Petrov", "Doctor", "12-YY", 1);
            //Employee employee1 = new Employee("Yura", "Yurco", "IT", "22-Y", 2);
            // Employee employee2 = new Employee("Ykura", "Y8uco", "T", "123-oo", 3);

            Employee.Show();          

           // employee1.Shows();
           
          
        }
    }
}
