using System;
using System.Collections.Generic;
using System.IO;
using System.Text;
using System.Xml.Serialization;

namespace Account
{
    [Serializable]

    public class Account
    {
        public static bool ResSerialize = true;


        // Оплата за день.   
        [XmlElement]
        public string payday;

        // Кількість днів.     
        [XmlElement]
        public string day;

        // Штраф за один день затримки оплати.
        [XmlElement]
        public string penaltyday;

        // Кількість днів затримки оплати.
        [XmlElement]
        public string countday;

        // Поля,які обраховуються.
        [XmlElement]
        public string totalSum;

        [XmlElement]
        public string penaltySum;

        [XmlElement]
        public string finishSum;


        public Account()
        {

        }

        public Account(string payday, string day, string penaltyday,string countday)
        {
            this.payday = payday;
            this.day = day;
            this.penaltyday = penaltyday;
            this.countday = countday;

           
            int paydays = int.Parse(this.payday);           
            int days = int.Parse(this.day);           
            int penaltydays = int.Parse(this.penaltyday);         
            int countdays= int.Parse(this.countday);


            totalSum = (paydays * days).ToString();
            penaltySum = (penaltydays * countdays).ToString();
            finishSum = (totalSum + penaltySum).ToString();           


        }
               




    }
}
