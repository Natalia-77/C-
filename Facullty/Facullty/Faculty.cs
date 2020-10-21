using System;
using System.Collections.Generic;
using System.Text;

namespace Facullty
{
    class Faculty
    {
        int _finance;
        string _namefaculty;
        List<Department> dep;

        public int Finance { get; set; }
        public string Namefaculty { get; set; }        
        public List<Department> d { get; set; }


        public Faculty()
        {
            _finance = 0;
            _namefaculty= "";           
            dep = new List<Department>();          
            dep.Add(new Department());
        }
    }
}
