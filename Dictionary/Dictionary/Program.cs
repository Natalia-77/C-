using System;
using System.Collections.Generic;
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

            dictionary.ShowDictionary(dictionary.dict);
        }
    }
}
