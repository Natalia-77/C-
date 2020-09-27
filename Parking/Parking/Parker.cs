using System;
using System.Collections.Generic;
using System.Text;

namespace Parking
{
    class Parker
    {
        Parkingbook park = new Parkingbook(3);
        public static string parkername;

        public void Add()
        {
            park.AddCar();
        }

        public void Del()
        {
            try
            {     
                int del;
                Console.WriteLine("Enter number for delete: ");
                del = int.Parse(Console.ReadLine());
                park.DelCar(del);
            }
            catch
            {
                Console.WriteLine("Такого авто немає у списку");
            }
        }

        public void ShowAllCars()
        {                     
             park.PrintAllCar();             
        }

    }
}
