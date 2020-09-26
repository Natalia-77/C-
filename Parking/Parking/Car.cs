using System;
using System.Collections.Generic;
using System.Text;

namespace Parking
{
    class Car
    {
        private string _model { get; set; }
        private string _color { get; set; }
        private string _number { get; set; }
        private double _time { get; set; }
        private Timer timer = new Timer();

        static readonly Random rnd = new Random();

        public Car()
        {
            _model = Randommodel();
            _color = Randomcolor();
            _number = Randomnum();
            _time = timer.GetF();
        }
           



        //public static double Conver(Car f)
        //{
        //    var ts = TimeSpan.FromMinutes(f.fact);
        //    Console.WriteLine("{0} г. {1} хв. {2} с. ", ts.Hours, ts.Minutes, ts.Seconds);
        //    return ts.Hours >> ts.Minutes >> ts.Seconds;  
        //}

        public override string ToString()
        {
            return string.Format("Model {0} , Color {1} ", _model, _color);
        }

        public void Show()
        {
            Console.WriteLine(" Model " + _model + " Color: " + _color + " Number: " + _number+" Time: "+_time);
            
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
            Number numb = (Number)(new Random()).Next(0, 5);
            int r = rnd.Next(10, 125);
            switch (numb)
            {
                case Number.UA:
                    {
                        return "UA " +r;
                    }

                case Number.EU:
                    {
                        return "EU " +r;
                    }

                case Number.USA:
                    {
                        return "USA " +r;
                    }

                case Number.CH:
                    {
                        return "DH " +r;
                    }

                case Number.IN:
                    {
                        return "IN " +r;
                    }

                case Number.RU:
                    {
                        return "RU"+r;
                    }

                case Number.CAN:
                    {
                        return "Can 263 Kanban";
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
