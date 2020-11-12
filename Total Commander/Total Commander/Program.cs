using System;

namespace Total_Commander
{
    class Program
    {
        public delegate void UseKey(ConsoleKeyInfo key);

        static void Main(string[] args)
        {
            //Table tab = new Table();
            //tab.MainTab(0, 0);
            //tab.MainTab(61, 0);



            FileManager manager = new FileManager();
            manager.Explore();
        }
    }
}
