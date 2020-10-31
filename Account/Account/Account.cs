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
        public static bool ResSerialize = false;


        // Оплата за день.
        //[XmlElement(ElementName = "Payday")]
        public string payday;

        // Кількість днів.
        //[XmlElement(ElementName = "Days")]
        public string day;

        // Штраф за один день затримки оплати.
        //[XmlElement(ElementName = "Penaltyday")]
        public string penaltyday;

        // Кількість днів затримки оплати.
        //[XmlElement(ElementName = "Countday")]
        public string countday;

        // Поля,які обраховуються.
        // [XmlElement(ElementName = "Total Sum")]
        public string totalSum;

        //[XmlElement(ElementName ="Penalty Sum")]
        public string penaltySum;

        // [XmlElement(ElementName ="Finish Sum")]
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
