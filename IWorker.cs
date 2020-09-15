//using System;
//using System.Collections.Generic;
//using System.Text;

//namespace ConsoleApp1
//{
//    public enum Parts { Basement, Wall, Window, Door, Roof };
//    public enum MaterialDoor { Wood, Glass, Plastic };
//    public enum MaterialBasement { Tape, Plate, Columnar };

//    interface IWorker
//    {
//        string Inform();//інформування(довідково)про етап будівництва.
//    }

//    interface IPart
//    {
//        string Action();//подія(етап)будівництва будинку.
//    }

//    class Team
//    {



//    }

//    class House : IPart
//    {
        
//        public string Action()
//        {
//            return "House are building";
//        }
//    }


//    class Basement : IPart
//    {
        
//        public string Action()
//        {
//            return "Basement build";
//        }
//    }

//    class Wall : IPart
//    {
       
//        public string Action()
//        {
//            return "Wall build";
//        }

//    }

//    class Window : IPart
//    {
        
//        public string Action()
//        {
//            return "Window build";
//        }

//    }

//    class Door : IPart
//    {
       
//        public string Action()
//        {
//            return "Door build";
//        }

//    }

//    class Roof : IPart
//    {
        
//        public string Action()
//        {
//            return "Roof build";

//        }

//    }
//    class Program
//    {
//        static void Main(string[] args)
//        {
//            Console.OutputEncoding = Encoding.Unicode;
//            Console.InputEncoding = Encoding.Unicode;

//            List<IPart> parts = new List<IPart>();                       
            
//            parts.Add(new Roof());
//            parts.Add(new Window());
//            parts.Add(new Door());
//            parts.Add(new Wall());
//            parts.Add(new Basement());

//            foreach (var el in parts)
//            {
//                Console.WriteLine(el.Action());
//            }

//            Console.ReadLine();
//        }
//    }
//}

    

