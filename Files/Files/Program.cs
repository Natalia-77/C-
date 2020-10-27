using System;
using System.IO;
using System.Text;
using System.Text.RegularExpressions;

namespace Files
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.OutputEncoding = Encoding.Unicode;
            Console.InputEncoding = Encoding.Unicode;

            string[] dir = Directory.GetFiles(@"D:\Natalia\Project1\C-Sharp\Files\Files\Testdoc", "*.txt");
            Console.WriteLine("Введіть слово для пошуку: ");
            string word = Console.ReadLine();
            Console.WriteLine("Введіть слово,яким ми замінимо введене: ");
            string wordnew = Console.ReadLine();

            int Allcount = 0;

            Console.WriteLine("------------------------------------------");
            Console.WriteLine($"Назва файлу          | кількість входжень|");
            Console.WriteLine("------------------------------------------");

            foreach (string name in dir)
            {
                string str = string.Empty;
                using (StreamReader reader = File.OpenText(name))
                {
                    str = reader.ReadToEnd();
                    if (str.Contains(word))
                    {
                        int amount = new Regex(word).Matches(str).Count;
                        string names = Path.GetFileName(name);
                        Console.WriteLine($"{names,-20} | {amount,17} | ");
                        Allcount += amount;

                    }
                }
                str = str.Replace(word, wordnew);

                using (StreamWriter file = new StreamWriter(name))
                {
                    file.Write(str);
                }
               
            }
            Console.WriteLine("------------------------------------------");
            Console.WriteLine($"Загальна кількість входжень по всім файлам:  {Allcount}");



        }
    }
}
