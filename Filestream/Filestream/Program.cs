using System;
using System.IO;
using System.Text;
using System.Text.RegularExpressions;

namespace Filestream
{
    class Program
    {
        static void Main(string[] args)
        {

            Console.OutputEncoding = Encoding.Unicode;
            Console.InputEncoding = Encoding.Unicode;

            //string name = "D:/Natalia/Project1/C-Sharp/Filestream/Filestream/images.jpg";

            string name1 = string.Empty;
           
            // Залишила лише,щоб тільки диск Д приймало.
            string pattern = "[(D)]";
            var r = new Regex(pattern);

            bool flag = false;
            do
            {

                Console.WriteLine("Введіть шлях до файлу(наприклад D:--коса риска--   :");
                 name1 = Console.ReadLine();


                if (r.IsMatch(name1))
                {                   
                    Console.WriteLine("Супер!Поки що все вірно!");
                    flag = true;
                }
                else
                {
                     Console.WriteLine("Неправильно введений шлях.Перевірте дані.");                   
                }

            } while (!flag);

           

            // Тут регулярним виразом перевіряю наявність вказаного розширення.
            var r2 = new Regex(@".jpg(\w*)");
            string name2 = string.Empty;
            bool flag2 = false;
            do
            {
                Console.WriteLine("Введіть ім1я файлу.Не забудьте про розширення .jpg");
                name2 = Console.ReadLine();

                if (r2.IsMatch(name2))
                {
                    Console.WriteLine("Супер!Все вірно!");
                    flag2 = true;

                }
                else
                {
                    Console.WriteLine("Неправильно введене ім1я файлу.");
                    
                }

            } while (!flag2);

            string name = name1 + name2;
            if(File.Exists(name))
            {
                Console.WriteLine("Введений вами файл існує");
            }
            else
            {
                Console.WriteLine("Такого файлу ,принамі у нас,немає. ");
            }

            byte[] bytes;
            int len = 0;

            using (FileStream fs = new FileStream(name, FileMode.OpenOrCreate, FileAccess.ReadWrite))
            {
                using (BinaryReader br = new BinaryReader(fs, Encoding.Default))
                {
                    len = (int)fs.Length;
                    bytes = new byte[fs.Length];
                    br.Read(bytes, 0, bytes.Length);
                }
            }

            int num = 0;           
            Console.WriteLine("Enter num of copy");
            num = int.Parse(Console.ReadLine());

            for (int i = 0; i < num; i++)
            {
                using (FileStream fs = new FileStream("D://file" + i + ".jpg", FileMode.OpenOrCreate, FileAccess.ReadWrite))
                {
                    using (BinaryWriter br = new BinaryWriter(fs, Encoding.Default))
                    {
                        br.Write(bytes, 0, bytes.Length);                      
                        br.Write(bytes);

                    }
                }
            }

        }
    }
}
