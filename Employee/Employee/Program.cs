using System;

namespace Employee
{
    class Program
    {
        static void Main(string[] args)
        {
            Employee employee = new Employee("Petya", "Petrov", "Doctor", "12-YY", 1);
           
            employee.Showjournal();
            //employee.Show();
        }
    }
}
