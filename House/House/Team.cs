using System;
using System.Collections.Generic;
using System.Text;

namespace House
{
    class Team
    {
        private IWorker teamLeader;
        private Worker[] workers;

        public Team(int count)
        {

            teamLeader = new Teamleader();
            workers = new Worker[count];
            for (int i = 0; i < count; i++)
                workers[i] = new Worker();
        }

        public House Work(House house)
        {

            for (int i = 0; i < workers.Length; i++)
            {
                house = workers[i].PartBuild(house);
                System.Threading.Thread.Sleep(200);
                Console.WriteLine("==============");
                teamLeader.PartBuild(house);
                Console.WriteLine("==============");
                System.Threading.Thread.Sleep(200);


            }

          
            Console.WriteLine("Ocean Plaza done!");
            return house;
        }
    }
}
