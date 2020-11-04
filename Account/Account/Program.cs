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


            Account ac1 = new Account("23", "12", "7", "3");
            Account ac2 = new Account("20", "1", "5", "3");
            Account[] account = new Account[] { ac1, ac2 };
            XmlSerializer formatter = new XmlSerializer(typeof(Account[]));
            Account.ResSerialize = true;
            string path = "D:/Natalia/Project1/C-Sharp/Account/Account/test2.xml";

            // Створили файл з новими записами.
            using (FileStream fs = new FileStream(path, FileMode.OpenOrCreate))
            {
                formatter.Serialize(fs,account);
            }


            // Десеріалізували.
            using (FileStream fs = new FileStream(path, FileMode.OpenOrCreate))
            {
                Account[] newac = (Account[])formatter.Deserialize(fs);

                foreach (Account p in newac)
                {
                    Console.WriteLine($"Зарплата за день: {p.payday}");
                    Console.WriteLine($"Кількість днів: {p.day}");
                    Console.WriteLine($"Штраф за один день затримки: {p.countday}");
                    Console.WriteLine($"Кількість днів затримки оплати :{p.penaltyday}");
                    Console.WriteLine($"Сума до оплати без штрафу:{p.totalSum}");
                    Console.WriteLine($"Штраф:{p.penaltySum}");
                    Console.WriteLine($"Загальна сума до оплати:{p.finishSum}");
                    Console.WriteLine("-------------------------------------------------------");



                }
            }

            Console.WriteLine("Якщо ви хочете серіалізувати весь список-натисніть +");
            Console.WriteLine("Якщо ви хочете серіалізувати не весь список-натисніть *");
            ConsoleKeyInfo keys = Console.ReadKey();
            if (keys.KeyChar == '*')
            {

                using (XmlWriter writer = XmlWriter.Create("D:/test7.xml"))
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
            if (keys.KeyChar == '+')
            {

                //Серіалізуємо все.

                if (Account.ResSerialize)
                {
                    string path1 = "D:/test8.xml";
                    using (FileStream fs1 = new FileStream(path1, FileMode.OpenOrCreate))
                    {
                        formatter.Serialize(fs1, account);
                    }
                   
                }
            }
        }





        }







    
}
