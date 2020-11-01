using System;
using System.Collections.Generic;
using System.IO;
using System.Text;
using System.Xml;
using System.Xml.Linq;
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
            {
                new Account()
                {
                    payday = "20",
                    day = "12",
                    penaltyday = "2",
                    countday = "2"
                };
                new Account()
                {
                    payday = "30",
                    day = "20",
                    penaltyday = "4",
                    countday = "6"
                };

            };
            Account.ResSerialize = true;
            string path = "D:/Natalia/Project1/C-Sharp/Account/Account/test2.xml";

            using (FileStream fs = new FileStream(path, FileMode.OpenOrCreate, FileAccess.ReadWrite))
            {

                XmlSerializer formatter = new XmlSerializer(typeof(List<Account>));

                formatter.Serialize(fs, account);

            }

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
                Console.WriteLine($"Сума до оплати без штрафу:{item.totalSum}");
                Console.WriteLine($"Штраф:{item.penaltySum}");
                Console.WriteLine($"Загальна сума до оплати:{item.finishSum}");
                Console.WriteLine("-------------------------------------------------------");
                

            }
            Console.WriteLine("Якщо ви хочете серіалізувати весь список-натисніть +");
            Console.WriteLine("Якщо ви хочете серіалізувати не весь список-натисніть *");
            ConsoleKeyInfo keys = Console.ReadKey();
            if (keys.KeyChar == '+')
            {
                // Щоб перевірити-розкоментуйте.
                //Серіалізуємо все.

                if (Account.ResSerialize)
                {

                    string path1 = "D:/test5.xml";
                    var serializer = new XmlSerializer(typeof(List<Account>));

                    using (var stream = File.OpenWrite(path1))
                    {
                        serializer.Serialize(stream, account);
                    }
                }
            }
            if (keys.KeyChar == '*')
            {
                Account.ResSerialize = false;

                // Серіалізуємо тільки певні поля.


                if (!Account.ResSerialize)
                {
                    using (XmlWriter writer = XmlWriter.Create("D:/test6.xml"))
                    {


                        writer.WriteStartDocument();
                        writer.WriteStartElement("Account");

                        foreach (Account ac in account)
                        {
                            writer.WriteStartElement("Account");
                            writer.WriteElementString("TotalSum", ac.totalSum.ToString());
                            writer.WriteElementString("PenaltySum", ac.penaltySum.ToString());
                            writer.WriteElementString("FinishSum", ac.finishSum.ToString());


                            writer.WriteEndElement();
                        }

                        writer.WriteEndElement();
                        writer.WriteEndDocument();
                    }
                }
            }

        }







    }
}
