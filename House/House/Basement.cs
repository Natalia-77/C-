using System;
using System.Collections.Generic;
using System.Text;

namespace House
{
    class Basement:IPart
    {
        private string name;
       
        public Basement(string name)
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
