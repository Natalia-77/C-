using System;
using System.Collections.Generic;
using System.Text;

namespace Parking
{
    class Parkingbook
    {
        private bool[] place;//масив місця на парковці.true->зайняте місце.фолс-вільно.
        private List<Car> list = new List<Car>(); // список машин.


        public Parkingbook(int count)
        {
            place = new bool[count];
        }

        public void AddCar()
        {
            for (int i = 0; i < place.Length; i++)
            {
                if (place[i] == false)//якщо вільно
                {
                    place[i] = true;//стає зайнято
                    list.Add(new Car());
                    return;
                }
            }
            Console.WriteLine("Вільних місць немає!");
        }

        public void DelCar(int number) // видалення машини по номеру машини.
        {
            foreach (Car car in list)
            {
                if (car._number == number)
                {
                    list.Remove(car);
                    place[car._number] = false;
                    Console.WriteLine("++");
                    return;
                }
            }
            Console.WriteLine("Немає такої машини: [{0}]", number);
        }

        public void PrintAllCar() // вывести все машины
        {
            foreach (Car car in list)
            {
                Console.WriteLine(car);
            }
        }
    }
}
