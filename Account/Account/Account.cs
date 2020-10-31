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
        public int _payday;

        // Кількість днів.
        //[XmlElement(ElementName = "Days")]
        public int _days;

        // Штраф за один день затримки оплати.
        //[XmlElement(ElementName = "Penaltyday")]
        public int _penaltyday;

        // Кількість днів затримки оплати.
        //[XmlElement(ElementName = "Countday")]
        public int _countday;    

        public Account()
        {

        }

        public Account(int payday, int days, int penaltyday,int countday)
        {
            _payday = payday;
            _days = days;
            _penaltyday = penaltyday;
            _countday = countday;
        }

        // Поля,які обраховуються.
       // [XmlElement(ElementName = "Total Sum")]
        public int TotalSum =>_payday * _days;

        //[XmlElement(ElementName ="Penalty Sum")]
        public int PenaltySum => _penaltyday * _countday;

       // [XmlElement(ElementName ="Finish Sum")]
        public int FinishSum => TotalSum + PenaltySum;

      



    }
}
