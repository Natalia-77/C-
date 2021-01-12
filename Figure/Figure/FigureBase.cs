using System;

namespace Figure
{
    abstract class FigureBase
    {
        string name{ get; set; }
        string color { get; set; }       

        public FigureBase(string name,string color)
        {
            this.name = name;
            this.color = color;
        }

        public abstract double Area();
       // public abstract string Color();

        public virtual void ShowInfo()
        {
            Console.WriteLine($"Figure name :{name} color :{color}");
        }
        
    }

    

}
