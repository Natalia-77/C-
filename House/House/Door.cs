using System;
using System.Collections.Generic;
using System.Text;

namespace House
{
    class Door:IPart
    {
        private string name;
        public string Name { get; set; } = "Door";
        public Door(string name)
        {
            this.name = name;
        }
        public string GetName//читання.
        {
            get
            {
                return name;
            }
        }
    }
}
