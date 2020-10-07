using System;

namespace Employee
{
    class Program
    {
        static void Main(string[] args)
        {
            Employee employee = new Employee("Petya", "Petrov", "Doctor", "12-YY", 1);
            Employee employee1 = new Employee("Yura", "Yurco", "IT", "22-Y", 2);
                   
            Employee.Show();
           
          
        }
    }
}
