using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading;
using System.Timers;


namespace Tamagochi
{
    class Program
    {

       // public static System.Threading.Timer timer;
        static System.Timers.Timer timer = new System.Timers.Timer(3000);
        static int interval = 5;
        
        public delegate void Action();

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

        private static void Test(object sender, ElapsedEventArgs e)

        {
            bool flag = true;
            Tama t = new Tama("Lolo", "Yellow");
            List<Action> act = new List<Action>();
            Random rand = new Random(((int)DateTime.Now.Ticks));
            int counter = 0;
            int con = 0;
            act.Add(t.Eat);
            act.Add(t.Walk);
            act.Add(t.Treat);
            act.Add(t.Sleep);
            act.Add(t.Play);
            // act[rand.Next(0, 4)]();
            for (int i = 0; i < act.Count; i++)
            {
                int index = rand.Next(act.Count);
                act[index]();
               


                ConsoleKeyInfo keys = Console.ReadKey();
                if (keys.KeyChar == '+')
                {
                    counter++;
                    //flag =true; ;
                   
                   
                }
                 else if (keys.KeyChar == '-')
                {
                    flag=false;
                    if(!flag)
                    {
                        con++;
                    }
                   
                }
               
                Console.WriteLine("Counter " + counter);
                Console.WriteLine("Con" + con);
                Console.ReadKey();
            }
           
            // act[rand.Next(0, 4)]();

        }

        

        //public static void Count()
        //{
        //    Tama t = new Tama("Lolo", "Yellow");
        //    List<Action> act = new List<Action>();
        //    Random rand = new Random();

        //    act.Add(t.Eat);
        //    act.Add(t.Walk);
        //    act.Add(t.Treat);
        //    act.Add(t.Sleep);
        //    act.Add(t.Play);

        //    int index = rand.Next(act.Count);
        //    act[index]();



        //}

        static void Main(string[] args)
        {
            //Tama t = new Tama("Lolo", "Yellow");
            //TimerCallback timerCallback = new TimerCallback(t.Need);
            //timer = new System.Threading.Timer(timerCallback, 0, 0, 3000); //3 сек
          
            //List<Action> act = new List<Action>();
            //act.Add(t.Play);
            //act.Add(t.Walk);
            //act.Add(t.Treat);
            //act.Add(t.Sleep);
            //act.Add(t.Eat);

            //Random rand = new Random();
            //act[rand.Next(0, 2)]();

            timer.Elapsed += timer_Elapsed;
            timer.Elapsed += Test;
            



            Console.WriteLine("Enter Y-to start timer.");
            Console.WriteLine("Enter N-to stop timer.");

            while (true)
            {
                ConsoleKeyInfo key = Console.ReadKey();
                if (key.KeyChar == 'Y' || key.KeyChar == 'y')
                {
                    timer.Start();
                    Console.WriteLine();

                }
                else if (key.KeyChar == 'N' || key.KeyChar == 'n')
                {
                    timer.Stop();

                }
                }



            }

         
    }
}


      

