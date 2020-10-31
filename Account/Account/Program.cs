using System;
using System.Collections.Generic;
using System.IO;
using System.Text;
using System.Xml;
using System.Xml.Serialization;

namespace Account
{
    class Program
    {
        static void Main(string[] args)
        {

            Console.OutputEncoding = Encoding.Unicode;
            Console.InputEncoding = Encoding.Unicode;

            List<Account> account = new List<Account>();
            //{
            //    new Account()
            //    {
            //        payday="20",
            //        day="12",
            //        penaltyday="2",
            //        countday= "2"
            //    },
            //    new Account()
            //    {
            //        payday="30",
            //        day="20",
            //        penaltyday="4",
            //        countday= "6"
            //    }

            //};
           
            //string path = "D:/Natalia/Project1/C-Sharp/Account/Account/test1.xml";

            //using (FileStream fs = new FileStream(path, FileMode.OpenOrCreate, FileAccess.ReadWrite))
            //{

            //    XmlSerializer formatter = new XmlSerializer(typeof(List<Account>));

            //    formatter.Serialize(fs, account);

            //}

            account.Add(new Account("20", "15", "10", "2"));
            account.Add(new Account("10", "10", "12", "2"));
            account.Add(new Account("12", "10", "11", "2"));
            account.Add(new Account("1", "10", "1", "2"));

            Console.WriteLine("Загальна відомість: ");
            Console.WriteLine("------------------------------------------------------\n");
            foreach (var item in account)
            {
                
                Console.WriteLine($"Зарплата за день: {item.payday}");
                Console.WriteLine($"Кількість днів: {item.day}");
                Console.WriteLine($"Штраф за один день затримки: {item.countday}");
                Console.WriteLine($"Кількість днів затримки оплати :{item.penaltyday}");

                if (Account.ResSerialize == true)
                {
                    Console.WriteLine(item.totalSum);
                    Console.WriteLine(item.penaltySum);
                    Console.WriteLine(item.finishSum);
                    Console.WriteLine("-------------------------------------------------------");
                }

            }

            string path1 = "D:/test2.xml";
            var serializer = new XmlSerializer(typeof(List<Account>));
            //FileStream fs1 = new FileStream(path1, FileMode.Create);

            using (var stream = File.OpenWrite(path1))
            {
                serializer.Serialize(stream, account);
            }
            Console.WriteLine("------------------------------\n");


        }






    }
}
