using System;

namespace FileManager
{

    public delegate void OnKey(ConsoleKeyInfo key);

    class Program
    {

        static void Main(string[] args)
        {
            FileManager manager = new FileManager();
            manager.Explore(); 
        }
    }
}
