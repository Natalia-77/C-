using System;

namespace House
{
       
    public enum MaterialBasement { Tape, Сolumnar, Slabs, Field };
    public enum MaterialWindow { Wood, Plastic, Glass };

    interface IPart   
    {
        string GetName { get; }    //отримати назву складової частини будинку.      
    }

    interface IWorker 
    {
       House PartBuild(House h);

    }


    class Program
    {
        static void Main(string[] args)
        {
            int kol = 11;
            House house = new House();
            Team team = new Team(kol);
            team.Work(house);
            house.Show();
            Console.ReadKey();

        }
    }
}
