using System;
using System.Collections.Generic;
using System.Text;

namespace Facullty
{
    class Faculty
    {
        int _finance { get; set; }
        string _namefaculty { get; set; }
        List<Department> dep { get; set; }

        //public int Finance { get; set; }
       // public string Namefaculty { get; set; }        
       // public List<Department> d { get; set; }


        public Faculty(int finance,string namefaculty)//,List<Department>d)
        {
            _finance = finance;
            _namefaculty = namefaculty;          
            dep = new List<Department>();            
           
        }

        public override string ToString()
        {
            return _namefaculty + "--> " + _finance ;
        }
    }
}
