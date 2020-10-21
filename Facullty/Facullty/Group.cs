using System;
using System.Collections.Generic;
using System.Text;

namespace Facullty
{
    class Group
    {
        public string _namegroup; 
        public int _number;

        public List<Teachers> teach { get; set; } = new List<Teachers>();
        public List<Faculty> faculty { get; set; } = new List<Faculty>();

    }
}
