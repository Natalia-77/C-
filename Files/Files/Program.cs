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
            string[] dir = Directory.GetFiles(@"D:\Natalia\Project1\C-Sharp\Files\Files\Testdoc", "*.txt");

            Console.WriteLine("Enter word for search");
            string word = Console.ReadLine();
            int Allcount = 0;       


            Console.WriteLine("-----------------------------------------------------------------------------------");
            Console.WriteLine("Назва файлу у якому є таке слово                              | кількість входжень |");
            Console.WriteLine("-----------------------------------------------------------------------------------");
            for (int i = 0; i < dir.Length; i++)
            {
                //int count = 0;
                FileStream fs = new FileStream(dir[i], FileMode.Open, FileAccess.Read);               
                byte[] bytes = new byte[fs.Length];
                fs.Read(bytes, 0, bytes.Length);              
                string str = Encoding.Default.GetString(bytes);


                if (str.Contains(word))
                {
                    int amount = new Regex(word).Matches(str).Count;
                    Console.WriteLine( dir[i]  );
                    Allcount += amount;

                }
              
                fs.Close();              
               
            }
            Console.WriteLine($"This word is {Allcount} times");

        }
    }
}
