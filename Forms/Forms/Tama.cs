using System;
using System.Collections.Generic;
using System.Text;

namespace Tamagochi
{
    class Tama
    {

        private  string name { get; set; }
        private string color { get; set; }

        public Tama(string name,string color)
        {
            this.name = name;
            this.color = color;
        }

        // Прохання полікувати.
        public string Treat()
        {
            return "Treated me!Please!";
        }

        public void Walk()
        {
            Console.WriteLine("Walk with me!");           
        }

        public void Sleep()
        {           
            Console.WriteLine("Sleep with me!");          
        }

        public  void Eat()
        {           
            Console.WriteLine("Eat with me!");            
        }        

        public  void Play()
        {           
            Console.WriteLine("Play with me!");          
        }

        public void Wash()
        {           
            Console.WriteLine("Wash me with shampoo !");
        }

        public void Drink()
        {           
            Console.WriteLine("I want to Drink !");
        }

        public void Makeup()
        {           
            Console.WriteLine("Would you like to get me makeup!");
        }

        public void Die()
        {
            Console.WriteLine("Тамі помер(((((");
        }


      






    }
}
