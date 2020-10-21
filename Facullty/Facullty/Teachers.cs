using System;
using System.Collections.Generic;
using System.Text;

namespace Facullty
{
    class Teachers
    {
        string _name { get; set; }
        string _surname { get; set; }
        int _salary { get; set; }
        List<Department> dept { get; set; }

        //public string Name { get; set; }
        //public string Surname { get; set; }
        //public int Salary { get; set; }
        //public List<Department> departments { get; set; }

        public Teachers(string name,string surname,int salary)//,List<Department>de)
        {
            _name = name;
            _surname = surname;
            _salary = salary;
            dept = new List<Department>(); 
            
        }

        public override string ToString()
        {
            return _surname + " " + _name + "  " + _salary;
        }




    }


}
