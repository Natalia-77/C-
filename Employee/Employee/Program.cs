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

            Employee e = new Employee();
            //Employee employee = new Employee("Petya", "Petrov", "Doctor", "12-YY", 1);
            //Employee employee1 = new Employee("Yura", "Yurco", "IT", "22-Y", 5255);
            //Employee employee2 = new Employee("Ykura", "Yuco", "T", "123-oo", 3);
            e.AddEmloyee();
            e.AddEmloyee();
            Employee.Show();
            
            e.Delete();
            Employee.Show();
           








           
           
          
        }
    }
}
