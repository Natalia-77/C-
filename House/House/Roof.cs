using System;
using System.Collections.Generic;
using System.Text;

namespace House
{
    class Roof:IPart
    {
        private string name;

        public string Name { get; set; } = "Roof";

        public Roof(string name)
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
