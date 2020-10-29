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

            List<Student> p2 = null;
            using (FileStream fs1 = new FileStream(@"D:/test.json", FileMode.Open))
            {
                p2 = d.ReadObject(fs1) as List<Student>;
            }
            Console.WriteLine("p2");
            foreach (var p in p2)
            {
                Console.WriteLine(p);
            }


            //List<Student> st = Student.GetList();

            //foreach (var item in st)
            //{
            //    Console.WriteLine(item);
            //}



            p2.Add(new Student("Oleg", "Polinovaar", 5));

            //Console.WriteLine("--------------------------------\n");
            //foreach (var item in st)
            //{
            //    Console.WriteLine(item);
            //}


            Console.WriteLine("----------------------\n");
            Console.WriteLine("Введіть прізвище студента,якого треба видалити");
            string del = string.Empty;
            del = Console.ReadLine();

            for (int i = 0; i < p2.Count; i++)
            {
                if (p2[i]._surname == del)
                {
                    p2.RemoveAt(i);
                }
            }

            //Console.WriteLine("--------------------------------\n");
            //foreach (var item in st)
            //{
            //    Console.WriteLine(item);
            //}

            FileStream fs = new FileStream(@"D:/test1.json", FileMode.OpenOrCreate);
                d.WriteObject(fs, p2);
                fs.Close();


        }
    }
}
