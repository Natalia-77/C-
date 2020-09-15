using System;

namespace House
{

    public enum Parties { Basement, Wall, Window, Door, Roof };
    public enum MaterialBasement { Tape, Сolumnar, Slabs, Field };
    public enum MaterialWindow { Wood, Plastic, Glass };

    interface IPart   
    {
        string GetName { get; }        
    }

    interface IWorker 
    {


    }


    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello World!");
        }
    }
}
