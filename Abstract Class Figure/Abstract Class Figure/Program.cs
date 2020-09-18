using System;
using System.Text;

namespace Abstract_Class_Figure
{
    abstract class Figure
    {

        protected string _name { get; set; }//назва.

        public  Figure(string name)
        {
            _name = name;
        }
        
        public abstract double Area();//площа.
        public abstract double Perimeter();//периметр.
        
        public virtual void Show()
        {
            Console.WriteLine(" Фігура: {0}\n Периметр: {1}\n Площа: {2} \n ", _name, Perimeter(), Area());
        }


    }

     class Rectangle : Figure
     {
        public double _sidefirst { get; set; }
        public double _sidesecond { get; set; }

        public Rectangle(string name,double sidefirst,double sidesecond):base(name)
        {
            _sidefirst = sidefirst;
            _sidesecond = sidesecond;

        }
            
        public override double Perimeter()
        {
            return 2 * (_sidefirst + _sidesecond); 
        }

        public override double Area()
        {
            return _sidefirst * _sidesecond;
        }

        public override void Show()
        {
            Console.WriteLine(" Фігура: {0}\n Периметр: {1}\n Площа: {2} \n ", _name, Perimeter(), Area());
        }

    }

    class Circle : Figure
    {
        public double _radius { get; set; }

        public Circle(string name,double radius ):base(name)
        {
            _radius = radius;
        }

        public override double Perimeter()
        {
            return Math.Round(2 * Math.PI*_radius,2);
        }

        public override double Area()
        {
            return Math.Round( Math.PI * (_radius * _radius),2);
        }

        public override void Show()
        {
            Console.WriteLine(" Фігура: {0}\n Периметр: {1}\n Площа: {2} \n ", _name, Perimeter(), Area());
        }
    }

    class Ellipse : Figure
    {
        public double _radfirst { get; set; }
        public double _radsecond { get; set; }

        public Ellipse(string name,double radfirst,double radsecond):base(name)
        {
            _radfirst = radfirst;
            _radsecond = radsecond;
        }

        public override double Perimeter()
        {
           // return Math.Round(2 * Math.PI * Radius, 2);
           return 
        }        

        public override double Area()
        {
            return Math.Round((Math.PI * _radfirst * _radsecond), 2);
        }

        public override void Show()
        {
            Console.WriteLine(" Фігура: {0}\n Периметр: {1}\n Площа: {2} \n ", _name, Perimeter(), Area());
        }
    }





    class Program
    {
        static void Main(string[] args)
        {
            Console.OutputEncoding = Encoding.Unicode;
            Console.InputEncoding = Encoding.Unicode;
           
        }
    }
}
