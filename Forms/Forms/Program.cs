using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Text;
using System.Windows.Forms;



namespace Tamagochi
{
    class Program
    {

        private delegate void Moves();      


        static void Main(string[] args)
        {
            Console.OutputEncoding = Encoding.Unicode;
            Console.InputEncoding = Encoding.Unicode;

            Tama t = new Tama("Tami", "Yellow");
            List<Moves> m = new List<Moves>(new Moves[] { t.Sleep, t.Eat, t.Play, t.Walk, t.Drink, t.Wash, t.Makeup });

            Random rand = new Random();
            Random r = new Random((int)DateTime.Now.Ticks);
            
            // Кількість життів.
            int counter = 3;

            // Новий ліст,куди додаю нові згeнеровані методи делегата.
            List<Moves> mov = new List<Moves>();

            Stopwatch rt = new Stopwatch();
            Stopwatch tm = new Stopwatch();


            Console.WriteLine($"Tami має зараз  = {counter} не використаних відмов");
            Console.WriteLine("-------------------------");
            Console.WriteLine("|Вас вітає тамагочі Тамі!))) |");
            Console.WriteLine("-------------------------");
            while (counter > 0)
            {
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
                    //item.DynamicInvoke();

                    string mes = item.Method.Name;
                    rt.Start();
                    var res = MessageBox.Show(mes, "Tami", MessageBoxButtons.OKCancel);
                
                    if (res == DialogResult.OK)
                    {
                        Console.WriteLine("Дякую)");
                        rt.Stop();

                        if (rt.ElapsedMilliseconds / 1000 > 3)
                        {
                            Console.WriteLine("Так краще не роби.Виконуй мої бажання швидше.");
                            counter--;
                            Console.WriteLine($"Тамі має зараз  = {counter} не використаних відмов");
                        }
                        else
                        {
                            Console.WriteLine("Дякую за турботу");
                        }
                        rt.Reset();
                    }
                    else
                    {

                        counter--;
                        rt.Stop();
                        Console.WriteLine("Не роби так.Я можу захворіти");
                        Console.WriteLine($"Тамі має зараз  = {counter} не використаних відмов");
                        rt.Reset();

                        if(counter==0)
                        {

                            tm.Start();
                            string mes2 = t.Treat();
                            var res2 = MessageBox.Show(mes2, "Tami", MessageBoxButtons.OKCancel);
                            if (res2 == DialogResult.OK)
                            {
                                tm.Stop();

                                if (tm.ElapsedMilliseconds / 1000 > 2)
                                {
                                    counter = 0;
                                    // t.Die();
                                    Console.WriteLine("Тамагочі загинув!(( Бо ти довго думав,чи треба тобі це...");
                                    return;
                                }
                                else
                                {
                                    Console.WriteLine("Ти полікував мене.");
                                    counter = 3;
                                    Console.WriteLine($"Tami має  = {counter} не використаних відмов");
                                }
                            }
                            else
                            {
                                tm.Stop();
                                counter = 0;
                                t.Die();
                                //Console.WriteLine("Tami помер.На жаль...");
                            }
                            tm.Reset();
                        }
                    }
                }
                                            
            }

        }

    }
        
}
    





        
        
    



        

    


    




      

