using System;
using System.Collections.Generic;
using System.Text;

namespace Parking
{
    class Car
    {
        private string _model { get; set; }
        private string _color { get; set; }
        public int _number { get; set; }
        private string _letter { get; set; }
        private double _time { get; set; }
       

        static readonly Random rnd = new Random();

        public Car()
        {
            _model = Randommodel();
            _color = Randomcolor();
            _number = rnd.Next(1, 10);
            _letter = Randomnum();
            Timer timer = new Timer();
            _time = timer.GetF();
        }

        public int Numbers
        {
            get
            {
                return _number;
            }
            set
             {
                _number = value;
            }
        }
           

        public override string ToString()
        {
            return string.Format("Model {0} , Time {1} ", _model, _time);
        }

        public void Show()
        {
            Console.WriteLine(" Model " + _model + " Color: " + _color + " Number: " + _number+"--"+_letter+" Time: "+_time);
            
        }

        public string Randommodel()
        {
            Model mod = (Model)(new Random()).Next(0, 3);
            switch (mod)
            {
                case Model.Audi:
                    {                        
                        return "Audi";                        
                    }

                case Model.Opel:
                    {
                       return "Opel";
                    }

                case Model.Kia:
                    {
                        return "Kia";
                    }

                case Model.Lada:
                    {
                        return "Lada";
                    }

                case Model.BMW:
                    {
                        return "BMW";
                    }

                default:
                    {
                        Console.WriteLine("Error!");
                        break;
                    }

            }
            return mod.ToString();
        }

        public string Randomcolor()
        {
            Color color = (Color)(new Random()).Next(0, 3);
            switch (color)
            {
                case Color.Black:
                    {
                        return "Black";
                    }

                case Color.Red:
                    {
                        return "Red";
                    }

                case Color.White:
                    {
                        return "White";
                    }

                case Color.Yellow:
                    {
                        return "Yellow";
                    }

                case Color.Silver:
                    {
                        return "Silver";
                    }

                default:
                    {
                        Console.WriteLine("Error!");
                        break;
                    }

            }
            return color.ToString();
        }

        public string Randomnum()
        {
            Letter numb = (Letter)(new Random()).Next(0, 5);
            
            switch (numb)
            {
                case Letter.UA:
                    {
                        return "UA ";
                    }

                case Letter.EU:
                    {
                        return "EU ";
                    }

                case Letter.USA:
                    {
                        return "USA ";
                    }

                case Letter.CH:
                    {
                        return "DH ";
                    }

                case Letter.IN:
                    {
                        return "IN ";
                    }

                case Letter.RU:
                    {
                        return "RU";
                    }

                case Letter.CAN:
                    {
                        return "Can";
                    }

                default:
                    {
                        Console.WriteLine("Error!");
                        break;
                    }

            }
            return numb.ToString();
        }


    }
}
