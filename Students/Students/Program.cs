using System;
using System.Collections.Generic;
using System.IO;
using System.Runtime.Serialization.Json;

namespace Students
{
    class Program
    {
        static void Main(string[] args)
        { 
           
            DataContractJsonSerializer d = new DataContractJsonSerializer(typeof(List<Student>));

            List<Student> st = Student.GetList();

            foreach (var item in st)
            {
                Console.WriteLine(item);
            }

            st.Add(new Student("Oleg", "Polinov", 5));

            //Console.WriteLine("--------------------------------\n");
            //foreach (var item in st)
            //{
            //    Console.WriteLine(item);
            //}


            Console.WriteLine("----------------------\n");
            Console.WriteLine("Введіть прізвище студента,якого треба видалити");
            string del = string.Empty;
            del = Console.ReadLine();

            for (int i = 0; i < st.Count; i++)
            {
                if (st[i]._surname == del)
                {
                    st.RemoveAt(i);
                }
            }

            Console.WriteLine("--------------------------------\n");
            foreach (var item in st)
            {
                Console.WriteLine(item);
            }

            using (FileStream fs = new FileStream(@"D:/test.json", FileMode.OpenOrCreate))
            {
                d.WriteObject(fs, st);
            }
        }
    }
}
