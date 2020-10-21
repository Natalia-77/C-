using System;
using System.Collections.Generic;
using System.Text;

namespace Facullty
{
    class Department
    {
        private int _fund;
        private string _namedept;
        List<Group> groups;

        public int Fund { get; set; }
        public string Namedept { get; set; }
        public List<Group> gr { get; set; }

        public Department()
        {
            _fund = 0;
            _namedept = "";
            groups = new List<Group>();
            groups.Add(new Group());
        }


    }
}
