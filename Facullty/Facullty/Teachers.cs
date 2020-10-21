using System;
using System.Collections.Generic;
using System.Text;

namespace Facullty
{
    class Teachers
    {
        string _name; 
        string _surname; 
        int _salary;
        List<Department> dept;

        public string Name { get; set; }
        public string Surname { get; set; }
        public int Salary { get; set; }
        public List<Department> departments { get; set; }

        public Teachers()
        {
            _name = "";
            _surname = "";
            _salary = 0;
            dept = new List<Department>();
            dept.Add(new Department());
        }
        





    }
}
