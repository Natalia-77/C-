using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading;
using System.Timers;

namespace Tamagochi
{
    class Program
    {
        

        static System.Timers.Timer timer = new System.Timers.Timer(2000);
        static int interval = 5;
        public delegate void Action();
      
        private static void Test(object sender, ElapsedEventArgs e)
        {
            
            Tama t = new Tama("Lolo", "Yellow");
            List<Action> act = new List<Action>();
            Random rand = new Random((int)DateTime.Now.Ticks);

            act.Add(t.Eat);
            act.Add(t.Walk);
            act.Add(t.Treat);
            act.Add(t.Sleep);
            act.Add(t.Play);

           // int index = rand.Next(act.Count);
           // act[index]();
                          
           //for(int i=0;i<act.Count;i++)
           // {
           //     if(i>0)
           //     {
           //         for(int j=0;j<i;j++)
           //         {
           //             if(act[i]!=act[j])
           //             {
           //                 act[rand.Next(0, 4)]();
           //                 //break;
           //                 //continue;
           //             }
           //             //else
           //             //{
                            
           //             //    i++;
           //             //}
           //         }
           //     }
           // }
         
          
            act[rand.Next(0, 4)]();



        }

        



        static void Main(string[] args)
        {


            //Action act = Play;
            //List<Action> act = new List<Action>();
            //act.Add(Play);
            //act.Add(Walk);
            //act.Add(Treat);
            //act.Add(Sleep);
            //act.Add(Eat);


            
            timer.Elapsed += timer_Elapsed;
            timer.Elapsed += Test;
            Console.WriteLine("Enter Y-to start timer.");
            Console.WriteLine("Enter N-to stop timer.");

            while(true)
            {
                ConsoleKeyInfo key = Console.ReadKey();
                if (key.KeyChar == 'Y' ||
                    key.KeyChar == 'y')
                {
                    timer.Start();
                    Console.WriteLine();
                   
                    //Console.Clear();
                }
                else if (key.KeyChar == 'N' ||
                    key.KeyChar == 'n')
                {
                    timer.Stop();
                    //Console.Clear();
                }
            }
           
        }
        
        private static void timer_Elapsed(object sender, ElapsedEventArgs e)
        {
            interval--;

            Console.Clear();            
            Console.WriteLine("               Залишок часу:  " + interval.ToString());            
           

            if (interval == 0)
            {
                Console.Clear();               
                Console.WriteLine("              Кінець відліку таймера");
                
                timer.Close();
                timer.Dispose();
            }

            
        }
    }


}

