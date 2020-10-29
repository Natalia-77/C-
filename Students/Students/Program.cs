using System;
using System.Collections.Generic;
using System.IO;
using System.Runtime.Serialization.Json;
using System.Text;

namespace Students
{
    class Program
    {
        static void Main(string[] args)
        {

            Console.OutputEncoding = Encoding.Unicode;
            Console.InputEncoding = Encoding.Unicode;

            DataContractJsonSerializer d = new DataContractJsonSerializer(typeof(List<Student>));

            List<Student> st = null;
            using (FileStream fs1 = new FileStream(@"D:/Natalia/Project1/C-Sharp/Students/Students/test.json", FileMode.Open))
            {
                st = d.ReadObject(fs1) as List<Student>;
            }

            Console.WriteLine("Список студентів:");
            foreach (var p in st)
            {
                Console.WriteLine(p);
            }

            // Додала нового.
            st.Add(new Student("Oleg", "Sharkizyan", 5));

            // Видалення по прізвищу.
            Console.WriteLine("----------------------\n");
            try
            {

                Console.WriteLine("Введіть прізвище студента,якого треба видалити");
                string del = string.Empty;
                del = Console.ReadLine();

                for (int i = 0; i < st.Count; i++)
                {
                    if (st[i]._surname == del)
                    {
                        st.RemoveAt(i);
                    }
                    else
                    {
                        throw new Exception();
                    }
                }
            }
            catch(Exception )
            {
                Console.WriteLine("Такого прізвища немає у списку!");
            }
            // Запис просто на диск Д .
            FileStream fs = new FileStream(@"D:/test1.json", FileMode.OpenOrCreate);
                d.WriteObject(fs, st);
                fs.Close();


        }
    }
}
