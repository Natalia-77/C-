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

            for (int i = 0; i < dir.Length; i++)
            {
               
                FileStream fs = new FileStream(dir[i], FileMode.Open, FileAccess.ReadWrite);
               
                byte[] bytes = new byte[fs.Length];
                fs.Read(bytes, 0, bytes.Length);              
                string str = Encoding.Default.GetString(bytes);


                if (str.Contains(word))
                {
                    int amount = new Regex(word).Matches(str).Count;
                    string name = Path.GetFileName(dir[i]);                   
                    Console.WriteLine($"{name,-20} | {amount,17} | ");
                    Allcount += amount;

                }

                
                StreamWriter write = new StreamWriter(fs);

                string str1 = str.Replace(word, wordnew);
                byte[] byte1 = Encoding.UTF8.GetBytes(str1);
                fs.Write(byte1, 0, byte1.Length);               

                fs.Close();
            }
            Console.WriteLine("------------------------------------------");
            Console.WriteLine($"Загальна кількість входжень по всім файлам:  {Allcount}");

           


        }
    }
}
