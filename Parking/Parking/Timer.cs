using System;
using System.Collections;
using System.Collections.Generic;
using System.Text;

namespace Parking
{
   
    class Timer
    {

        //public static double Res(int hours, int minutes, int seconds)
        //{
        //    TimeSpan T1 = new TimeSpan(hours, minutes, seconds);
        //    DateTime res = DateTime.Now.Subtract(T1);
        //    double res2 = (res.Hour * 60) + res.Minute;
        //   // Console.WriteLine("Res:  " + res2);
        //     return res2;
        //}

        //public static DateTime Result(int hours, int minutes, int seconds)
        //{
        //    TimeSpan T1 = new TimeSpan(hours, minutes, seconds);
        //    DateTime res = DateTime.Now.Subtract(T1);
        //    int res2 = (res.Hour * 60) + res.Minute;
        //    Console.WriteLine("Res:  " + res2);
        //    int time =(int)(res.Hour*60)+ (int)res.Minute;
        //    Console.WriteLine("Time :"+time);
        //    return res;
        //}

        public DateTime start { get; set; }
        public DateTime end { get; set; }
        private TimeSpan Payed { get; set; }
        private TimeSpan Fact { get; set; }


        static readonly Random rand = new Random();

        public Timer()
        {
            start = new DateTime(2020,09,24);//початок 
            end = new DateTime(2020,09,26);//кінець 

            var year = rand.Next(2020, 2020);
            var month = rand.Next(09, 09);
            var days = rand.Next(start.Day, start.Day);
            var ranger = start.Day + 3;
            var range = start.Day + 1;
            var days2 = rand.Next(range, ranger);

           this.start= new DateTime(year, month, days, rand.Next(0, 24), rand.Next(0, 60), rand.Next(0, 60));
           this.end= new DateTime(year, month, days2, rand.Next(0, 24), rand.Next(0, 60), rand.Next(0, 60));
           this.Payed = TimeSpan.FromMinutes(rand.Next(200, 2500));
           this. Fact = this.end - this.start;
          
            
        }

        public void Show()
        {
            Console.WriteLine("Start" + start + "   End " + end + " Payed " + Payed );
        }

        public DateTime GetTimeStart()=>start;//час заїзду на парковку.
       
        public DateTime GetTimeEnd() => end;//час виїзду з парковки.
       
        public TimeSpan GetTimePayed() => Payed;

        public double GetF() => Math.Round(Fact.TotalMinutes,0);//фактичний час стоянки у хвилинах.
       
        public double GetSpanMinutes() => Payed.TotalMinutes;//оплачений час у хвилинах.
       
        public TimeSpan GetOutstandingTime()//різниця між фактичним часом і оплаченим.   
        {
            TimeSpan OutStanding = this.end- this.start- Payed;

             return OutStanding;
        }


        public double GetS()=>(GetOutstandingTime().TotalMinutes < 0)?0:Math.Round(GetOutstandingTime().TotalMinutes,0);//якщо різниця додатня,то вертаємо кількість хвилин,за які треба доплатити.
                 


        //public DateTime Start()
        //{
        //    return start.AddDays(rand.Next(range)).AddHours(rand.Next(0, 24)).AddMinutes(rand.Next(0, 60)).AddSeconds(rand.Next(0, 60));
        //}
        


    }



}

