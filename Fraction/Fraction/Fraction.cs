using System;
using System.Collections.Generic;
using System.Text;

namespace Fraction
{
    internal class Fraction
    {
        private int _numerator;
        private int _denominator;
        private double v;

        public int Numerator { get; set; }
        public int Denominator { get; set; }

        public double Frac
        {
            get
            { 
                return _numerator / _denominator;
            }
        }
        public Fraction()
        {
            _numerator = 1;
            _denominator = 1;
        }

        public Fraction(int numerator,int denominator)
        {
           
            _numerator = numerator;
            _denominator = denominator;
        }

        public Fraction(double v, int denominator)
        {
            this.v = v;
            _denominator = denominator;
        }

        public override string ToString()
        {
            int part = _numerator / _denominator;
            if (part != 0 && _numerator % _denominator != 0)
            {
                 return string.Format("{0} {1}/{2}", part, _numerator % _denominator, _denominator);

            }
            if (_numerator % _denominator == 0)
            {
                return string.Format("{0}", part);
            }
            else
            {
                return string.Format("{0}/{1}", _numerator, _denominator);
            }

        }   
        
        public void Show()
        {
          
            int part = _numerator / _denominator;
            if (part != 0&& _numerator % _denominator != 0)
            {            
                Console.WriteLine(string.Format("{0} {1}/{2}", part, _numerator % _denominator, _denominator));
               
            }
            if (_numerator % _denominator == 0)
            {
                Console.WriteLine(string.Format("{0}", part));
            }
            if (part==0)
            {
                Console.WriteLine(string.Format("{0}/{1}", _numerator, _denominator));
            }           


        }

        public static Fraction operator +(Fraction f1, Fraction f2)
        => new Fraction(f1._numerator * f2._denominator + f1._denominator * f2._numerator, f1._denominator * f2._denominator);

        public static Fraction operator +(Fraction f1, int a)
        => new Fraction(f1._denominator *a+f1._numerator, f1._denominator);

        public static Fraction operator +(Fraction f1, double b)
         => new Fraction(f1._denominator * b + f1._numerator, f1._denominator);

        public static Fraction operator -(Fraction f1, Fraction f2)
        => new Fraction(f1._numerator * f2._denominator - f1._denominator * f2._numerator, f1._denominator * f2._denominator);        

        public static Fraction operator *(Fraction f1, Fraction f2)
        => new Fraction(f1._numerator * f2._numerator, f1._denominator * f2._denominator);

        public static Fraction operator *(Fraction f1, int b)
        => new Fraction(f1._numerator * b, f1._denominator);

        public static Fraction operator *(int c,Fraction f1)
        => new Fraction(c*f1._numerator, f1._denominator);

        public static Fraction operator /(Fraction f1, Fraction f2)
        => new Fraction(f1._numerator * f2._denominator, f1._denominator * f2._numerator);

        public static bool operator ==(Fraction a, Fraction b)
        {
            return a.Equals(b);
        }

        public static bool operator !=(Fraction a, Fraction b)
        {       
            return !(a.Equals(b));
        }

        public override int GetHashCode()
        {
            return this.ToString().GetHashCode();
        }

        public bool Equals(Fraction obj)
        {           
           return (ToString() == obj.ToString());           
        }

        public static bool operator >(Fraction a, Fraction b)
        => (a.Frac > b.Frac) ? true : false;

        public static bool operator <(Fraction a, Fraction b)
        => (a.Frac < b.Frac) ? true : false;

        //public static bool operator >(Fraction a, Fraction b)
        //{
        //    if (a.Frac <= b.Frac)
        //        return false;
        //    return true;
        //}
        //public static bool operator <(Fraction a, Fraction b)
        //{
        //    if (a.Frac >=b.Frac)
        //        return false;
        //    return true;
        //}


        public static bool operator true(Fraction a)
        => (a._numerator < a._denominator) ? true : false;

        public static bool operator false(Fraction a)
        => (a._numerator > a._denominator) ? true : false;
        
        public static Fraction Parse(string s)//метод отримання дробу зі строки.
        { 
            int Part, numerator, denominator;
            Fraction res;
           
            string[] str = s.Split(".");


            if (str.Length == 1)//якщо наше число ціле.
            {
                Part = int.Parse(str[0]);
                res = new Fraction(Part, 1);
            }
            else // якщо не ціле,а має цифри після крапки(1.23 або 1.5 як в умові)
            {
               
                int x = Convert.ToInt32(str[1]);   //визначаю кількість цифр після крапки.
                int counter = 0;
                while (x > 0 )
                {
                    counter++;                    //кількість цифр після крапки.
                    x = x / 10;
                }
               
                int y = Convert.ToInt32(str[0]); //якщо ціла частина рівна нулю.
                if (y == 0)
                {
                    numerator = int.Parse(str[1]);
                    denominator = (int)(Math.Pow(10, counter));
                    res = new Fraction(numerator, denominator);

                }
                else                             //якщо ціла частина більше нуля.
                {
                    numerator = (int)(((int.Parse(str[0])) * (Math.Pow(10, counter))) + (int.Parse(str[1])));
                    denominator = (int)(Math.Pow(10, counter));
                    res = new Fraction(numerator, denominator);
                }
               
                res = new Fraction(numerator, denominator);                
            }    
            
            return res ;
        }



    }
}
