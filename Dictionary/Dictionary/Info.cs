using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Dictionary
{
    class Info
    {
        public Dictionary<string, string> dict;

        public Info()
        {
            dict = new Dictionary<string, string>();
        }

        public bool TranslateWord(string country,bool status)
        {
            // Потім в мейні буде задано,що при статусі фолс перекладати буде з англ. на укр.мову.
            if(status==false)
            { 
                // Якщо в словнику немає такого ключа(країни).
                if(dict.ContainsKey(country)==false)
                {
                    Console.WriteLine("Такої країни немає в нашому словнику");
                    return false;
                }
                // Якщо ж є у словнику,то виводимо.
                Console.WriteLine("{0}->>>{1}", country, dict[country]);//.TryGetValue(country,)[country]) ;
            }
            else
            {
                // Тут навпаки,вже питаємо,чи є такий value у словнику.
                if(dict.ContainsValue(country)==false)
                {
                    Console.WriteLine("Такої столиці немає в нашому словнику");
                    return false;
                }
                Console.WriteLine("{0}->>>{1}", country, dict.First(x => x.Value == country).Key);//ElementAtOrDefault(country);//.SingleOrDefault(x => x.Value == country).Key) ;//.FirstOrDefault(x => x.Value == country).Key);
            }
            return true;

        }

    }
}
