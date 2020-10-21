using System;
using System.Collections.Generic;
using System.Text;

namespace Facullty
{
    class Department
    {
        private int _fund { get; set; }
        private string _namedept { get; set; }
        List<Group> groups { get; set; }

        //public int Fund { get; set; }
        //public string Namedept { get; set; }
        //public List<Group> gr { get; set; }

        public Department(int fund,string namedept)//,List<Group>g)
        {
            _fund = fund;
            _namedept = namedept;
            groups = new List<Group>();
        }

        public override string ToString()
        {
            return _namedept + "  " + _fund ;
        }

    }
}
