using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Timers;



namespace Tamagochi
{
    class Program
    {
        public static void Tami(object obj, EventArgs e)
        {

            Tama t = new Tama("Lolo", "Yellow");
            List<Moves> m = new List<Moves>(new Moves[] { t.Sleep, t.Eat, t.Play, t.Walk, t.Drink, t.Wash, t.Makeup });

            Random rand = new Random();
            Random r = new Random((int)DateTime.Now.Ticks);
           
            // Новий ліст,куди додаю нові згeнеровані методи делегата.
            List<Moves> mov = new List<Moves>();

            Console.WriteLine("-------------------------");
            Console.WriteLine("| Wellcome to Tamagochi |");
            Console.WriteLine("-------------------------");

                // Два різні рандоми для генерації індексів.
                int index = rand.Next(m.Count);
                int ind = r.Next(m.Count);

                mov.Add(m[index]);


                for (int i = 0; i < mov.Count; i++)
                {

                    for (int j = i + 1; j < mov.Count; j++)
                    {

                        if (mov[j].Method.Name == mov[i].Method.Name)
                        {
                            // Перевіряла,чи робить заміну на новий метод,якщо повтор.
                            //Console.WriteLine("+++++");
                            //Console.WriteLine(mov[j].Method.Name);

                            // Якщо є повтор,то видаляю.
                            mov.RemoveAt(i);

                            // Потім на це видалене місце додаю новий,але  індекс згенеровано новим рандомом.
                            mov.Add(m[ind]);
                        }

                    }

                }

                foreach (Moves item in mov)
                {
                    // Викликаю.
                    item.DynamicInvoke();          
                                                          

                }
            
        }

        public static void Check(object obj, EventArgs e)
        {
            Tama t = new Tama("Lolo", "Yellow");
            int counter = 0;
            Console.WriteLine("----------------------------------------------------------------");
            Console.WriteLine("Do you want to satisfy a need?");
            Console.WriteLine("Enter '+' if your answer 'YES' or enter '-' if your answer 'NO'\n");
            Console.WriteLine("-----------------------------------------------------------------");
           
            ConsoleKeyInfo keys = Console.ReadKey();
           
            if (keys.KeyChar  == '+')
            {
                Console.WriteLine("Super\n");

            }
            else if (keys.KeyChar == '-')
            {
                Console.WriteLine("Bad\n");
                counter++;
                Console.WriteLine("You refuse to tami " + counter);
                Console.WriteLine("---------------");

                // Якщо тричі відмовити,то просить полікувати.
                if (counter == 3)
                {
                    t.Treat();

                    Console.WriteLine("Do you want treat me?");
                    Console.WriteLine("Enter '1' if your answer 'YES' or enter '0' if your answer 'NO'");
                    ConsoleKeyInfo choice = Console.ReadKey();
                    if (choice.KeyChar == '1')
                    {
                        Console.WriteLine("Thank you!");
                        Console.Clear();
                        counter = 0;
                    }
                    else if (choice.KeyChar == '0')
                    {
                        Console.Clear();
                        t.Die();
                        Console.WriteLine();
                        return;
                    }

                }
            }
            //Console.Read();
        }


        private delegate void Moves();


       
        static Timer timer = new Timer(2000);
        static int i = 5;

        static void Main(string[] args)
        {
            timer.Elapsed += timer_Elapsed;
            timer.Elapsed += Tami;
            timer.Elapsed += Check;
            timer.Start();
            Console.Read();    
                       

        }

        public static void timer_Elapsed(object sender, ElapsedEventArgs e)
        {
            i--;

            Console.Clear();
            Console.WriteLine("=================================================");
            Console.WriteLine("                Time           :  " + i.ToString());
            Console.WriteLine("");
            Console.WriteLine("=================================================");

            if (i == 0)
            {
                Console.Clear();
                Console.WriteLine("");
                Console.WriteLine("==============================================");
               
                Console.WriteLine("               End                 "           );
                Console.WriteLine("==============================================");

                timer.Close();
                timer.Dispose();
            }


        }
    }
}




        
        
    



        

    


    




      

