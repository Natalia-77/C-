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

        public  void Walk()
        {
            Console.WriteLine(color + " " + name + " says ");
            Console.WriteLine("Walk with me!");
           
        }

        public void Sleep()
        {
            Console.WriteLine(color + " " + name + " says ");
            Console.WriteLine("Sleep with me!");
          
        }

        public  void Eat()
        {
            Console.WriteLine(color + " " + name + " says ");
            Console.WriteLine("Eat with me!");
            
        }

        // Прохання полікувати.
        public  void Treat()
        {
            Console.WriteLine(color + " " + name + " says ");
            Console.WriteLine("Treated me!Please!");
          
        }

        public  void Play()
        {
            Console.WriteLine(color + " " + name + " says ");
            Console.WriteLine("Play with me!");
          
        }

        public void Wash()
        {
            Console.WriteLine(color + " " + name + " says ");
            Console.WriteLine("Wash me with shampoo !");
        }

        public void Drink()
        {
            Console.WriteLine(color + " " + name + " says ");
            Console.WriteLine("I want to Drink !");
        }

        public void Makeup()
        {
            Console.WriteLine(color + " " + name + " says ");
            Console.WriteLine("Would you like to get me makeup!");
        }
        public void Die()
        {
            Console.WriteLine("I'm die(((((");
        }


      






    }
}
