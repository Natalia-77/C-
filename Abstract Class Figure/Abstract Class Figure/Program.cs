using Abstract_Class_Figure;
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

        public Ellipse(string name, double radfirst, double radsecond) : base(name)
        {
            _radfirst = radfirst;
            _radsecond = radsecond;
        }

        public override double Perimeter()
        {
            return Math.Round( 4 * ((Math.PI * _radfirst * _radsecond) + (_radfirst - _radsecond) / (_radfirst + _radsecond)),2);
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
    class Parallelogram : Figure
    {
        public double _sidea { get; set; }
        public double _sideb { get; set; }
        public double _height { get; set; }

        public Parallelogram(string name, double sidea, double sideb,double height) : base(name)
        {
            _sidea = sidea;
            _sideb = sideb;
            _height = height;
                
        }

        public override double Perimeter()
        {
            return Math.Round(2 * (_sidea + _sideb),2);
        }

        public override double Area()
        {
            return Math.Round((_sidea * _height),2);
        }

        public override void Show()
        {
            Console.WriteLine(" Фігура: {0}\n Периметр: {1}\n Площа: {2} \n ", _name, Perimeter(), Area());
        }
    }

    class Romb : Figure
    {
        
        public double _sideA { get; set; }
        public double _height { get; set; }
        

        public Romb(string name, double sideA,double height) : base(name)
        {
            _sideA = sideA;
            _height = height;
            
        }

        public override double Perimeter()
        {
            return Math.Round(( 4 * _sideA),2);
        }

        public override double Area()
        {
            return Math.Round((_sideA * _height),2);
        }

        public override void Show()
        {
            Console.WriteLine(" Фігура: {0}\n Периметр: {1}\n Площа: {2} \n ", _name, Perimeter(), Area());
        }
    }

    class Triangle : Figure
    {

        public double _sideA { get; set; }
        public double _sideB { get; set; } 
        public double _sideC { get; set; } 
      


        public Triangle(string name, double sideA, double sideB,double sideC) : base(name)
        {
            _sideA = sideA;
            _sideB = sideB;
            _sideC = sideC;
        }

        public override double Perimeter()
        {
            return Math.Round((_sideA+_sideB+_sideC), 2);
        }

        public override double Area()
        {
            double P = 0.5 * (_sideA + _sideB + _sideC);
            return Math.Round(Math.Sqrt(P * (P - _sideA) * (P - _sideB) * (P - _sideC)),2);
        }

        public override void Show()
        {
            Console.WriteLine(" Фігура: {0}\n Периметр: {1}\n Площа: {2} \n ", _name, Perimeter(), Area());
        }
    }


    class Trapezoid : Figure
    {       
        public double _sideA { get; set; }
        public double _sideB { get; set; }
        public double _sideC { get; set; }
        public double _sideD { get; set; }
        public double _height { get; set; }


        public Trapezoid(string name, double sideA,double sideB,double sideC, double sideD, double height) : base(name)
        {
            _sideA = sideA;
            _sideB = sideB;
            _sideC = sideC;
            _sideD = sideD;
            _height = height;
        }

        public override double Perimeter()
        {
            return Math.Round((_sideA + _sideB + _sideC + _sideD),2);
        }

        public override double Area()
        {
            return Math.Round((((_sideA+_sideB)/2)*_height),2);
        }

        public override void Show()
        {
            Console.WriteLine(" Фігура: {0}\n Периметр: {1}\n Площа: {2} \n ", _name, Perimeter(), Area());
        }
    }

    class Composite
    {
       
        public Figure[] _fig { get; set; }

        public Composite ( Figure[] fig)
        {
            _fig = fig;
            
        }

        public double Area()
        {
            double res = 0;
            for (int i = 0; i <_fig.Length; i++)
            {
                res += _fig[i].Area();
                
            }
            return res;

        }
        public void Printres()
        {
            Console.WriteLine($"Площа результуючої фигури :  {Area()} \n ");

        }

    }


}



    class Program
    {
        static void Main(string[] args)
        {
            Console.OutputEncoding = Encoding.Unicode;
            Console.InputEncoding = Encoding.Unicode;


            Figure[] figures = {new Triangle("Трикутник",7,7,8),new Rectangle("Прямокутник", 5.2,7),
                new Romb("Ромб",3,6),new Parallelogram("Паралелограм", 5,6,7),
                new Trapezoid("Трапеція", 5,6,4,7,6.5),new Circle("Коло", 5.6),new Ellipse("Эліпс", 3,6)};

            foreach (Figure el in figures)
            {
                el.Show();
            }

            Console.WriteLine("-----------------------");
            Figure[] f = {new Circle("Коло",4.5), new Parallelogram("Паралелограм", 3,7,8),new Trapezoid("Трапеція", 6,5,7,9,5)};

            foreach(Figure el in f)
            {
                el.Show();
            }

            Console.WriteLine("-------------------------");
            Composite c = new Composite(f);
            c.Printres();

        }
    }

