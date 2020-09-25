using System;
using System.Collections.Generic;
using System.Text;

namespace Parking
{
   
    class Timer
    {

        //private static int _hour; //static -
        //private static int _minute;
        //private static int _second;


        static readonly Random rand = new Random();

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

        private DateTime start { get; set; }
        private DateTime end { get; set; }
         int range;

        public Timer()
        {
            start = new DateTime(2020,09,25);
            end = new DateTime(2020,09,25);
            range = (DateTime.Today - start).Days;
        }

        public DateTime Start()
        {
            return start.AddHours(rand.Next(0, 24)).AddMinutes(rand.Next(0, 60)).AddSeconds(rand.Next(0, 60));
        }

        public DateTime End()
        {
            return end.AddHours(rand.Next(0, 24)).AddMinutes(rand.Next(0, 60)).AddSeconds(rand.Next(0, 60));
        }

        
        

        
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