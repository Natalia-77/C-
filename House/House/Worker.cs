using System;
using System.Collections.Generic;
using System.Text;

namespace House
{
    class Worker : IWorker
    {


        public House PartBuild(House h)//послідовне будівництво будівельниками.
        {

            if (h.CountPart() == 0)
            {
                h.Part(new Basement("Basement"));
                RandomMaterial(h);
                Console.WriteLine("Now building basement");
                
            }
            else if ((h.CountPart() < 5) || (h.GetPart() == "Basement"))
            {
                h.Part(new Wall("Wall"));
                Console.WriteLine("Now building wall");
                
            }
            else if (h.CountPart() == 5)
            {
                h.Part(new Door("Door"));
                Console.WriteLine("Now building Door");
               
            }
            else if ((h.CountPart()>5)&&(h.CountPart()<10)||(h.GetPart() == "Door"))
            {
               
                h.Part(new Window("Window"));
                RandomMaterialWindow(h);
                Console.WriteLine("Now building window");                         
               
            }
            else
            {
                h.Part(new Roof ("Roof"));
                Console.WriteLine("Now building roof");
                
            }

            return h;
        }

        //public string RandomMaterial()//обирає рандомно матеріал фундамента.
        House RandomMaterial(House h)
        {
            MaterialBasement b = (MaterialBasement)(new Random()).Next(0, 3);
            switch (b)
            {
                case MaterialBasement.Field:
                    {
                        Console.WriteLine("Material of basement : Field");
                        break;
                    }
                case MaterialBasement.Slabs:
                    {
                        Console.WriteLine("Material of basement : Slabs");
                        break;
                    }
                case MaterialBasement.Tape:
                    {
                        Console.WriteLine("Material of basement : Tape");
                        break;
                    }
                case MaterialBasement.Сolumnar:
                    {
                        Console.WriteLine("Material of basement : Columnar");
                        break;
                    }
                default:
                    {
                        Console.WriteLine("Error!");
                        break;
                    }
                    
            }
            return h;
        }

        //public void RandomMaterialWindow()//обирає рандомно матеріал вікон.
        House RandomMaterialWindow(House h)
        {
            MaterialWindow win = (MaterialWindow)(new Random()).Next(0, 2);
            switch (win)
            {
                case MaterialWindow.Glass:
                    {
                        Console.WriteLine("Material of window : Glass");
                        break;
                    }
                case MaterialWindow.Plastic:
                    {
                        Console.WriteLine("Material of window : Plastic");
                        break;
                    }
                case MaterialWindow.Wood:
                    {
                        Console.WriteLine("Material of window : Wood");
                        break;
                    }
                default:
                    {
                        Console.WriteLine("Error!");
                        break;
                    }
            }
            return h;
        }

    }
}
