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

            //List<Account> account = new List<Account>()
            //{
            //    new Account()
            //    {
            //        _payday=2,
            //        _days=50,
            //        _penaltyday=2,
            //        _countday= 200
            //    },
            //    new Account()
            //    {
            //        _payday=3,
            //        _days=60,
            //        _penaltyday=4,
            //        _countday= 600
            //    }

            //};
            Account ac = new Account();
            string path = "D:/Natalia/Project1/C-Sharp/Account/Account/test1.xml";

            using (FileStream fs = new FileStream(path, FileMode.OpenOrCreate, FileAccess.ReadWrite))
            {

                XmlSerializer formatter = new XmlSerializer(typeof(Account));

                formatter.Serialize(fs, ac);//

                // Console.WriteLine("Ok");
            }

            //account.Add(new Account(8, 31, 1010, 21));
           // account.Add(new Account(7, 30, 100, 20));           
            Console.WriteLine("Загальна відомість: ");
            Console.WriteLine("------------------------------------------------------\n");
            //foreach (var item in account)
            // {
            //Console.WriteLine($"Зарплата за день: {item._payday}");
            //Console.WriteLine($"Кількість днів: {item._days}");
            //Console.WriteLine($"Штраф за один день затримки: {item._countday}");
            //Console.WriteLine($"Кількість днів затримки оплати :{item._penaltyday}");
            //Console.WriteLine("-------------------------------------------------------");
            //Console.WriteLine(item.TotalSum);
            //Console.WriteLine(item.PenaltySum);
            //Console.WriteLine(item.FinishSum);
            //}

            //string path1= "D:/test2.xml";
            //var serializer = new XmlSerializer(typeof(List<Account>));
            ////FileStream fs1 = new FileStream(path1, FileMode.Create);

            //using (var stream = File.OpenWrite(path1))
            //{
            //    serializer.Serialize(stream, account);
            //}
            Create(ac);
        }

        public static void Create(Account acc)
        {
            XmlDocument d = new XmlDocument();

            //List<Account> acc = new List<Account>();

            XmlElement root = d.CreateElement("Account");
            d.AppendChild(root);

            XmlElement payday = d.CreateElement("Payday");
            payday.InnerText = "2";// acc._payday.ToString();
           
            //payday.Value = acc._payday.ToString();
          
            root.AppendChild(payday);

            //XmlElement days = d.CreateElement("Days");
            //a.AppendChild(days.Value=);

            //XmlElement penaltyday = d.CreateElement("Penaltyday");
            //a.AppendChild(penaltyday);

            //XmlElement countday = d.CreateElement("Countday");
            //a.AppendChild(countday);

            d.Save("D:/newtest.xml");
        }






    }
}
