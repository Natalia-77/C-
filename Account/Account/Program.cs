using System;
using System.IO;
using System.Xml.Serialization;

namespace Account
{
    class Program
    {
        static void Main(string[] args)
        {
            Account account= new Account { _payday=2, _days=50, _penaltyday=2,_countday= 200 };
            string path = "D:/Natalia/Project1/C-Sharp/Account/Account/test1.xml";

           
            

            using (FileStream fs = new FileStream(path, FileMode.OpenOrCreate, FileAccess.ReadWrite))
            {
                // Передаю в конструктор тип класу.
                XmlSerializer formatter = new XmlSerializer(typeof(Account));
                formatter.Serialize(fs, account);
                Console.WriteLine("Ok");
            }



        }
    }
}
