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
        private double fact { get; set; }
        private int _id { get; set; }
        //private DateTime fact { get; set; }
             

        static Random rnd = new Random();

        public Car(int _h,int _m,int _s,int id)
        {
            _model = Randommodel();
            _color = Randomcolor();
            _number = Randomnum();
            //fact = Timer.Res(_h, _m, _s);
            _id = id;
            //fact = Timer.Result(_h, _m, _s);           
            
        }
           



        public static double Conver(Car f)
        {
            var ts = TimeSpan.FromMinutes(f.fact);
            Console.WriteLine("{0} г. {1} хв. {2} с. ", ts.Hours, ts.Minutes, ts.Seconds);
            return ts.Hours >> ts.Minutes >> ts.Seconds;  
        }

        public override string ToString()
        {
            return string.Format("Model {0} , time {1}, Color {2} ",_model,fact,_color);
        }

        public void Show()
        {
            Console.WriteLine("Номер місця "+_id+" Model " + _model + " Час стоянки на даний момент у хвилинах: " + fact + " Color: " + _color + " Number: " + _number);
            
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
