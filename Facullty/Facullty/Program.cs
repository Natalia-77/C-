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


            Teachers tea1 = new Teachers { _name = "Valery", _surname = "Brauan", _salary = 5000 };
            Teachers tea2 = new Teachers { _name = "Samantha", _surname = "Adams", _salary = 1200 };
            Teachers tea3 = new Teachers { _name = "Mary", _surname = "Gold", _salary = 6000 };
            Teachers tea4 = new Teachers { _name = "Peter", _surname = "Mars", _salary = 2000 };
            Teachers tea5 = new Teachers { _name = "Mark", _surname = "Spencer", _salary = 1000 };
            Teachers tea6 = new Teachers { _name = "Pavlo", _surname = "zibrov", _salary = 8800 };
            List<Teachers> resultt = new List<Teachers> { tea1, tea2, tea3, tea4, tea5, tea6 };

            // Список факультетів.
            Faculty fa1 = new Faculty { _finance = 20000, _namefaculty = "Basic automatization" };
            Faculty fa2 = new Faculty { _finance = 30000, _namefaculty = "Basic design" };
            Faculty fa3 = new Faculty { _finance = 10000, _namefaculty = "Computer Science" };
            Faculty fa4 = new Faculty { _finance = 15000, _namefaculty = "Abstract design " };
            List<Faculty> resultf = new List<Faculty> { fa1, fa2, fa3, fa4 };

            Group gr1 = new Group { _namegroup = "911VPU", _number = 2 };
            Group gr2 = new Group { _namegroup = "921VUU", _number = 3 };
            Group gr3 = new Group { _namegroup = "322WWQ", _number = 4 };
            Group gr4 = new Group { _namegroup = "388YUI", _number = 4 };
            List<Group> resultg = new List<Group> { gr1, gr2, gr3, gr4 };

            // Список кафедр.
            Department dep1 = new Department { _fund = 11000, _namedept = "Technology" };
            Department dep2 = new Department { _fund = 16000, _namedept = "Design" };
            Department dep3 = new Department { _fund = 18000, _namedept = "HR management" };
            Department dep4 = new Department { _fund = 30000, _namedept = "Сybersecurity" };
            List<Department> resultd = new List<Department> { dep1, dep2,dep3,dep4 };


            gr1.teach = new List<Teachers> { tea1, tea2, tea3 };
            gr2.teach = new List<Teachers> { tea4, tea5 };
            gr3.teach = new List<Teachers> { tea6, tea1 };
            gr4.teach = new List<Teachers> { tea3, tea5 };
            gr1.faculty = new List<Faculty> { fa2, fa3 };
            gr2.faculty = new List<Faculty> { fa1, fa3 };
            gr3.faculty = new List<Faculty> { fa4, fa2,fa3 };
            gr4.faculty = new List<Faculty> { fa1, fa4 };
            fa1.dep = new List<Department> { dep1 };
            fa2.dep = new List<Department> { dep2 };
            fa3.dep = new List<Department> { dep3 };
            fa4.dep = new List<Department> { dep4 };
            dep1.groups = new List<Group> { gr1, gr2 };
            dep2.groups = new List<Group> { gr3 };
            dep3.groups = new List<Group> { gr4 };
            dep4.groups = new List<Group> { gr2, gr3 };
            tea1.dept = new List<Department> { dep1 };
            tea2.dept = new List<Department> { dep1, dep2 };
            tea3.dept = new List<Department> { dep1, dep3 };
            tea4.dept = new List<Department> { dep4, dep2 };
            tea5.dept = new List<Department> { dep3, dep4 };
            tea6.dept = new List<Department> { dep2, dep3 };


            Console.WriteLine("---------------------1----------------------------\n");
            Console.WriteLine("Вивести всі можливі пари строк викладачів та груп:");
            var res = resultg.SelectMany(x => x.teach.Select(y => new { Група = x._namegroup, Викладач = y._surname + " " + y._name })).ToList();
            foreach (var item in res)
            {
                Console.WriteLine(item);
            }


            Console.WriteLine("------------------------2-------------------------\n");
            Console.WriteLine("Вивести назву факультетів,фонд фінансування кафедр яких" +
                " перевищує фонд фінансування факультета");
            var reі2 = resultf.Where(f => f._finance < f.dep.Sum(d => d._fund)).Select(f => new { Назва = f._namefaculty });
            foreach (var item in reі2)
            {
                Console.WriteLine(item);

            }

            Console.WriteLine("---------------------------3----------------------\n");
            Console.WriteLine(" Вивести імена та прізвища викладачів,які читають лекції в групі 911VPU");
            var res3 = resultg.Where(x => x._namegroup == "911VPU").SelectMany(t => t.teach).Select(t => new { Викладач = t._surname + " " + t._name });
            foreach (var item in res3)
            {
                Console.WriteLine(item);
            }


            Console.WriteLine("---------------------4-------------------------------\n");
            Console.WriteLine(" Вивести прізвища викладачів та назви факультетів,де вони читають лекції.");
            var res4 = resultt.SelectMany(t => resultf.Where(f => f.dep.Any(d => t.dept.Contains(d))).Select
            (f => new { Викладач = t._name + " " + t._surname, Факультет = f._namefaculty }));

            foreach (var item in res4)
            {
                Console.WriteLine(item);
            }


            Console.WriteLine("---------------------5-----------------------------\n");
            Console.WriteLine(" Вивести назви кафедр і назви груп, які до них відносяться.");
            var res5 = resultd.SelectMany(t => t.groups.Select(x => new { Кафедра = t._namedept, Група = x._namegroup }));

            foreach (var item in res5)
            {
                Console.WriteLine(item);
            }



            Console.WriteLine("---------------------6-----------------------------\n");
            Console.WriteLine("Вивести назви кафедр, на яких читає викладач Samantha Adams");
            var res6 = resultt.Where(x => x._surname == "Adams").SelectMany(t => t.dept).Select(y => y._namedept);

            foreach (var item in res6)
            {
                Console.WriteLine(item);
            }



            Console.WriteLine("---------------------7--------------------------\n");
            Console.WriteLine("Вивести назви груп, які відносяться до факультету Computer Science”. ");
            var res7 = resultg.SelectMany(x => x.faculty.Where(y => y._namefaculty == "Computer Science").
            Select(t => new { x._namegroup }));

            foreach (var item in res7)
            {
                Console.WriteLine(item);
            }


            Console.WriteLine("---------------------8--------------------------\n");
            Console.WriteLine("Вивести назви груп 4-го курса, а також назви факультетів," +
                " до яких вони відносяться ");
            var res8 = resultg.SelectMany(x => x.faculty.Where(y => x._number == 4).Select(y => new { x._number, y._namefaculty }));

            foreach (var item in res8)
            {
                Console.WriteLine(item);
            }

        }
    }
}
