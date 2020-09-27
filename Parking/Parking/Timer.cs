using System;
using System.Collections;
using System.Collections.Generic;
using System.Text;

namespace Parking
{
   
    class Timer
    {

        private DateTime start;
        private DateTime end;
        private DateTime payed;
     
        static readonly Random rand = new Random();

        public Timer()
        {      
           
            this.start = DateTime.Now;

            this.end = new DateTime(DateTime.Now.Year,DateTime.Now.Month,DateTime.Now.Day,
            rand.Next(start.Hour+1, 24), rand.Next(start.Minute, 60), rand.Next(start.Second, 60));

            this.payed = new DateTime(DateTime.Now.Year, DateTime.Now.Month, DateTime.Now.Day,
            rand.Next(start.Hour, 24), rand.Next(start.Minute, 60), rand.Next(start.Second, 60));             
            
        }

        public void Show()
        {
            Console.WriteLine("Start" + start + "   End " + end + " Payed " + payed );
        }

        public DateTime GetTimeStart()=>start;//час заїзду на парковку.
       
        public DateTime GetTimeEnd() => end;//час виїзду з парковки.
       
        public DateTime GetTimePayed() => payed;//оплачений час.

        public double GetEndMinute() => end.Minute;//час виїзду у хвилинах.

        public double GetSpanMinutes() => payed.Minute;//оплачений час у хвилинах.   


        public double OutstandingTime()//різниця між часом виїзду і оплаченим у хвилинах.
        {
            TimeSpan OutStanding = end - payed;

            return OutStanding.Minutes;
        }

        public DateTime Outstand()
        {
            TimeSpan OutStanding = end - payed;
           

            if (OutStanding.Minutes<0)
            {
                DateTime data = new DateTime(DateTime.Now.Year, DateTime.Now.Month, DateTime.Now.Day,0,0,0);
                return data;
            }
            else
            {
                DateTime data = new DateTime(DateTime.Now.Year, DateTime.Now.Month, DateTime.Now.Day,OutStanding.Hours,OutStanding.Minutes,OutStanding.Seconds);
                return data;
            }

        }
       

        //public DateTime GetOutstanding()=>(OutstandingTime()< 0)?0://якщо різниця додатня,то вертаємо кількість хвилин,за які треба доплатити.
                 


        
        


    }



}

