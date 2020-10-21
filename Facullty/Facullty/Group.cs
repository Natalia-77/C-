using System;
using System.Collections.Generic;
using System.Text;

namespace Facullty
{
    class Group
    {
        string _namegroup { get; set; }
        string _number {get;set;}
        List<Teachers> teach { get; set; }
        List<Faculty> faculty { get; set; }

        
        //public string Namegroup { get; set; }
        //public int Number { get; set; }
        //public List<Faculty> facultet { get; set; }
        // List<Teachers> tea { get; set; }


        public Group(string namegroup,string number)//,List<Teachers>tich,List<Faculty>fa)
        {
            _namegroup = namegroup;
            _number = number;
            teach = new List<Teachers>();
            faculty = new List<Faculty>();
        }


        public override string ToString()
        {
            return _namegroup + "  " + _number ;
        }
    }
}
