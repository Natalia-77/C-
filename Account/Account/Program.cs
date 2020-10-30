using System;
using System.Collections.Generic;
using System.IO;
using System.Xml.Serialization;

namespace Account
{
    class Program
    {
        static void Main(string[] args)
        {
            List<Account> account = new List<Account>()
            {
                new Account()
                {
                    _payday=2,
                    _days=50,
                    _penaltyday=2,
                    _countday= 200
                },
                new Account()
                {
                    _payday=3,
                    _days=60,
                    _penaltyday=4,
                    _countday= 600
                }

            };
            string path = "D:/Natalia/Project1/C-Sharp/Account/Account/test1.xml";

           
            

            using (FileStream fs = new FileStream(path, FileMode.OpenOrCreate, FileAccess.ReadWrite))
            {
                
                XmlSerializer formatter = new XmlSerializer(typeof(List<Account>));

                formatter.Serialize(fs, account);

                Console.WriteLine("Ok");
            }



        }
    }
}
