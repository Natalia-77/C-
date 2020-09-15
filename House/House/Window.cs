using System;
using System.Collections.Generic;
using System.Text;

namespace House
{
    class Window:IPart
    {
        private string name;
       
        public Window(string name)
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
