using System;
using System.Collections.Generic;
using System.Text;

namespace House
{
    class Window:IPart
    {
        private string name;

        public string Name { get; set; } = "Window";
       
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
