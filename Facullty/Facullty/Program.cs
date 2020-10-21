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

            
            Teachers tea1 = new Teachers { _name = "Valery", _surname = "Brauan", _salary = 5000};
            Teachers tea2 = new Teachers { _name = "Samantha", _surname = "Adams", _salary = 1200 };
            Teachers tea3 = new Teachers { _name = "Mary", _surname = "Gold", _salary = 6000 };
            Teachers tea4 = new Teachers { _name = "Peter", _surname = "Mars", _salary = 2000 };
            Teachers tea5 = new Teachers { _name = "Mark", _surname = "Spencer", _salary = 1000 };
            Teachers tea6 = new Teachers { _name = "Pavlo", _surname = "zibrov", _salary = 8800 };
            List<Teachers> resultt = new List<Teachers> { tea1, tea2, tea3, tea4, tea5, tea6 };

            Faculty fa1 = new Faculty { _finance = 20000, _namefaculty = "Basic automatization" };
            Faculty fa2 = new Faculty { _finance = 30000, _namefaculty = "Basic design" };
            Faculty fa3 = new Faculty { _finance = 10000, _namefaculty = "Computer Science" };
            Faculty fa4 = new Faculty { _finance = 15000, _namefaculty = "Abstract design " };
            List<Faculty> resultf = new List<Faculty> { fa1, fa2, fa3, fa4 };


            Group gr1 = new Group { _namegroup = "911VPU", _number = 2 };
            Group gr2 = new Group { _namegroup = "921VUU", _number = 3 };
            Group gr3 = new Group { _namegroup = "322WWQ", _number = 1 };
            Group gr4 = new Group { _namegroup = "388YUI", _number = 4 };
            List<Group> resultg = new List<Group> { gr1, gr2, gr3, gr4 };

            Department dep1 = new Department { _fund = 11000, _namedept = "Technology" };
            Department dep2 = new Department { _fund = 16000, _namedept = "Design" };
            List<Department> resultd = new List<Department> { dep1,dep2};
            




           Console.WriteLine("------------------1---------------\n");

            
            //var groups = departments.SelectMany((Department el) => el.groups);

            //List<string> teachers = groups.Select((Group g) => g._namegroup + "-->" 
            //+ g.teach.Select(teach => teach._name).Aggregate((string a, string b) => a + ", " + b)).ToList();

            //foreach (var item in teachers)
            //{
            //    Console.WriteLine(item);
            //}




            Console.WriteLine("---------------2------------------\n");

            var report2 = resultf.Where(f => f._finance < f.dep.Sum(d => d._fund)).Select(f => f._namefaculty);
            foreach (var item in report2)
            {
                Console.WriteLine(item);

            }
        }
    }
}
