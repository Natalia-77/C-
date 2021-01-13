using System;

namespace Figure
{
    abstract class FigureBase
    {
        string name{ get; set; }
        string color { get; set; }     
        
        public string Name
        {
            get => name;
            set => name = value;
        }

        public string Color
        {
            get => color;
            set => color = value;
        }

        public FigureBase(string name,string color)
        {
            this.name = name;
            this.color = color;
        }

        public abstract double Area();      

        public virtual void ShowInfo()
        {
            Console.WriteLine($"Figure name : {name}\nColor :{color}");
           // Console.WriteLine("-----------------------------\n");
        }
        
    }

    

}
