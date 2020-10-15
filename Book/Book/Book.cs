using System;
using System.Collections.Generic;
using System.Text;

namespace Book
{
    class Book
    {
        public string Name { get; set; }
        public string Year { get; set; }
        public int Price { get; set; }

        public Book(string Name,string Year,int Price)
        {
            this.Name = Name;
            this.Year = Year;
            this.Price = Price;
        }

        

    }
}
