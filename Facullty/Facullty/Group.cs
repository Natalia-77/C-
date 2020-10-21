using System;
using System.Collections.Generic;
using System.Text;

namespace Facullty
{
    class Group
    {
        string _namegroup;
        string _number;
        List<Teachers> teach;
        List<Faculty> faculty;

        
        public string Namegroup { get; set; }
        public int Number { get; set; }
        public List<Faculty> facultet { get; set; }
        public List<Teachers> tea { get; set; }


        public Group()
        {
            _namegroup = "";
            _number = "";

            teach = new List<Teachers>();
            faculty = new List<Faculty>();

            teach.Add(new Teachers());           
            faculty.Add(new Faculty());
        }
    }
}
