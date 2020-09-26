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

        public DateTime start;// { get; set; }
        public DateTime end { get; set; }
        private TimeSpan Payed { get; set; }
        private double totalminutes { get; set; }

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
           this. end= new DateTime(year, month, days2, rand.Next(0, 24), rand.Next(0, 60), rand.Next(0, 60));
           this. Payed = (end - start);
           this. totalminutes = Math.Round(Payed.TotalMinutes,0);
            
        }

        public void Show()
        {
            Console.WriteLine("Start"+start+"   End "+end+" Payed "+Payed+"Total min "+totalminutes);
        }

        public DateTime GetMinutesStart()
        {

            return start;
        }

        public DateTime GetMinuteEnd ()
        {
            return end;

        }

        public double GetTotalMinutes ()
        {

            return totalminutes;
        }

        //public DateTime Start()
        //{
        //    return start.AddDays(rand.Next(range)).AddHours(rand.Next(0, 24)).AddMinutes(rand.Next(0, 60)).AddSeconds(rand.Next(0, 60));
        //}

        //public DateTime End()
        //{
        //    return end.AddDays(rand.Next(range)).AddHours(rand.Next(0, 24)).AddMinutes(rand.Next(0, 60)).AddSeconds(rand.Next(0, 60));
        //}


        //public DateTime Start()
        //{
        //    var year = rand.Next(2020, 2020);
        //    var month = rand.Next(09, 09);
        //    var days = rand.Next(start.Day, start.Day);
                           
        //    return new DateTime(year, month, days, rand.Next(0, 24), rand.Next(0, 60), rand.Next(0, 60));          
                        
        //}

        //public DateTime End()
        //{
        //    int range,ranger;
        //    var year = rand.Next(2020, 2020);
        //    var month = rand.Next(09, 10);
        //    ranger = start.Day + 3;
        //    range = start.Day + 1 ;
        //    var days2 = rand.Next(range, ranger);

        //     return new DateTime(year, month, days2, rand.Next(0, 24), rand.Next(0, 60), rand.Next(0, 60));
        //}

     





    }



}

//internal DateTime EntryDateTime { get; set; }
//internal DateTime ExitDateTime { get; set; }

//public PatronTimeSpend(DateTime entryDate, DateTime exitDate)
//{
//    if (entryDate.Subtract(exitDate).TotalMilliseconds > 0)
//    {
//        throw new InvalidOperationException();
//    }
//    EntryDateTime = entryDate;
//    ExitDateTime = exitDate;
//}