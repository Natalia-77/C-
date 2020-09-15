using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace House
{
    class House:IPart
    {
        private string name;
        List<IPart> house;

        public House()
        {
            house = new List<IPart>();
            name = "Ocean Plaza";
        }

        public string GetName 
        { 
            get
            { 
                return name;
            }
        }

        public void Part(IPart obj)
        {
            house.Add(obj);//додаю складові частини будинку.
        }

        public void Show()
        {
            int size = house.Count;
            for (int i = 0; i < size; i++)
            Console.WriteLine(house.ElementAt(i).GetName);
        }

        public int CounterPart()//кількість частин.
        { 
            return house.Count;
        }

        public string GetLastPartName()//пошук останньої частини(назви).
        {
            return house.Last().GetName;
        }

    }
}
