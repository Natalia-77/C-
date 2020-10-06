using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Dictionary
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.OutputEncoding = Encoding.Unicode;
            Console.InputEncoding = Encoding.Unicode;

            Info dictionary = new Info();
            
            dictionary.Add("Ukraine", "Україна");
            dictionary.Add("Poland", "Польща");
            dictionary.Add("Germany", "Німеччина");
            dictionary.Add("Spain", "Іспанія");


            Dictionary<string, string> Ukr = dictionary.dict.ToDictionary(x => x.Value, y => y.Key);

           // dictionary.ShowDictionary(dictionary.dict);
           // dictionary.ShowDictionary(Ukr);

            Console.WriteLine("Якщо ви хочете перейти в англійсько-український словник-натисніть 1;");
            Console.WriteLine("Якщо ви хочете перейти в українсько-англійський словник-натисніть 2;");
            string choice = Console.ReadLine();

            if (choice == "1") choice = "false";
            else if (choice == "2") choice = "true";
          
           // Передаю по ссилці status для перетворення choice.
           // Якщо res = true,то перетворення відбулось успішно.
            bool res = bool.TryParse(choice, out bool status);

            if(res)
            {
                do
                {                   
                    if (!status)
                    {
                        dictionary.ShowDictionary(dictionary.dict);
                        Console.WriteLine("Введіть назву країни на англійській мові");

                    }
                    else
                    {
                        dictionary.ShowDictionary(Ukr);
                        Console.WriteLine("Введіть назву країни на українській мові");
                    }

                    string text = Console.ReadLine();
                    dictionary.TranslateWord(text, status);
                       
                    Console.WriteLine("Для продовження натисніть 1;");
                    Console.WriteLine("Якщо хочете завершити натисніть 0;");
                    string end = Console.ReadLine();
                    Console.Clear();
                    if (end=="0") break;

                }
                while (true);
            }
            else
            {
                Console.WriteLine("Перетворення не відбулось успішно...");
            }


        }
    }
}
