using System;
using System.Collections.Generic;
using System.Text;

namespace Tamagochi
{
    class Tama
    {

        private string name { get; set; }
        private string color { get; set; }

        public Tama(string name,string color)
        {
            this.name = name;
            this.color = color;
        }

        public void Need(object obj)
        {
            Console.WriteLine();
        }

        public void Walk()
        {
            Console.WriteLine(color + " " + name + " says ");
            Console.WriteLine("Walk with me!");
            Console.WriteLine("------------------");
        }

        public void Sleep()
        {
            Console.WriteLine(color + " " + name + " says ");
            Console.WriteLine("Sleep with me!");
            Console.WriteLine("------------------");
        }

        public  void Eat()
        {
            Console.WriteLine(color + " " + name + " says ");
            Console.WriteLine("Eat with me!");
            Console.WriteLine("------------------");
        }

        public  void Treat()
        {
            Console.WriteLine(color + " " + name + " says ");
            Console.WriteLine("Treated me!Please!");
            Console.WriteLine("------------------");
        }

        public  void Play()
        {
            Console.WriteLine(color + " " + name + " says ");
            Console.WriteLine("Play with me!");
            Console.WriteLine("------------------");
        }

      






    }
}
