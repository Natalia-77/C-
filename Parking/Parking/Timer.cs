using System;
using System.Collections;
using System.Collections.Generic;
using System.Text;

namespace Parking
{
   
    class Timer
    {

        //private static int _hour; //static -
        //private static int _minute;
        //private static int _second;


        

        //public Timer()
        //{
        //    _hour = rand.Next(0,24);
        //    _minute = rand.Next(0, 60);
        //    _second = rand.Next(0,60);
        //}

        //public int Hour
        //{
        //    get
        //    {                
        //        return _hour;
        //    }
        //    set
        //    {           
        //            if (value < 0 || value > 24)
        //            {
        //              return;
        //            }
        //            _hour = value;     
        //    }

        //}

        //public int Minute
        //{
        //    get
        //    {
        //        return _minute;
        //    }
        //    set
        //    {
        //        if (value < 0 || value > 60)
        //        {
        //            return;
        //        }
        //        _minute = value;
        //    }

        //}

        //public int Second
        //{
        //    get
        //    {
        //        return _second;
        //    }
        //    set
        //    {
        //        if (value < 0 || value > 60)
        //        {
        //            return;
        //        }
        //        _second = value;
        //    }

        //}

        //public  override string ToString()
        //{
        //    return string.Format("{0}г:{1}хв:{2}сек", _hour,_minute, _second);
        //}

        //public void Print()
        //{
        //    Console.WriteLine(this.ToString());
        //}

        //public static void Timestart()//час,коли авто поставили на парковку.
        //{
        //    Timer timer = new Timer();
        //    int hour = rand.Next(0,24);
        //    int minute = rand.Next(0, 60);
        //    int second = rand.Next(0, 60);

        //    timer.Hour = hour; //В години запишеться,що видав рандом.
        //    timer.Minute = minute;
        //    timer.Second = second;
        //    Console.WriteLine("Час,коли авто поставили на парковку:{0}г.{1}хв.{2}с.",timer.Hour,timer.Minute,timer.Second);

        //}

        //public static void Timefinish()
        //{
        //    Timer timer = new Timer();
        //    int hour = rand.Next(0, 24);
        //    int minute = rand.Next(0, 60);
        //    int second = rand.Next(0, 60);

        //    timer.Hour = hour; //В години запишеться,що видав рандом.
        //    timer.Minute = minute;
        //    timer.Second = second;
        //    Console.WriteLine("Час,коли авто забирають з парковки:{0}г.{1}хв.{2}с.", timer.Hour, timer.Minute, timer.Second);
        //}

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

            start= new DateTime(year, month, days, rand.Next(0, 24), rand.Next(0, 60), rand.Next(0, 60));
            end= new DateTime(year, month, days2, rand.Next(0, 24), rand.Next(0, 60), rand.Next(0, 60));
            Payed = (end - start);
            totalminutes = Math.Round(Payed.TotalMinutes,0);

            
        }

        public void Show()
        {
            Console.WriteLine("Start"+start+"   End "+end+" Payed "+Payed+"Total min "+totalminutes);
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

        //public TimeSpan Pay()
        //{
        //    return  End() - Start();
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