using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Facullty
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.OutputEncoding = Encoding.Unicode;
            Console.InputEncoding = Encoding.Unicode;

            List<Department> deps = new List<Department>()
            {
                new Department(25000,"Дизайн"),
                new Department(8885, "Програмування"),
            };

            List<Teachers> teachers = new List<Teachers>()
            {
                new Teachers("Петрук", "Ілона",1210),
                new Teachers("Соловей", "Христина", 1300),
            };


            List<Faculty> faculties = new List<Faculty>()
            {
                new Faculty(22000,"Дизайн"),
                new Faculty(10000, "Адміністрування"),
            };


            List<Group> groups = new List<Group>()
            {
                new Group("P101", "1"),
                new Group("P102", "2"),
            };


        }
    }
}
