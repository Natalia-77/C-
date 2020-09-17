using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace House
{
    class Teamleader:IWorker
    {
        public House PartBuild(House h)//Teamleader буде показувати актуальний стан будівництва будинку.
        {
           // Console.WriteLine("================");
            Console.WriteLine("We have elements is build on this time :->>");
           // Console.WriteLine("================\n");

            List<IPart> partHouse = h.GetHouse();//повертає "збудовану" частину будинку на даному етапі.

            for (int i = 0; i < h.CountPart(); i++)
            {
                          
                Console.WriteLine("Name of part: " + partHouse.ElementAt(i).GetName);                

            }
            return h;
        }
    }
}
