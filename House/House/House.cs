using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace House
{
    class House
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
       
        public void Part(IPart par)
        {
            house.Add(par);//додаю складові частини будинку в спимок.
        }

        public void Show()
        {
            int size = house.Count;
            for (int i = 0; i < size; i++)
                Console.WriteLine("Element " + house.ElementAt(i).GetName);
        }


        public int CountPart()//кількість частин.
        { 
            return house.Count;
        }

        public string GetPart()//пошук останньої частини(назви).
        {
            return house.Last().GetName;
        }

        public List<IPart> GetHouse()
        {
            return house;
        }
       


    }
}
