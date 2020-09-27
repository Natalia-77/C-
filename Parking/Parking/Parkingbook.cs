using System;
using System.Collections.Generic;
using System.Text;

namespace Parking
{
    class Parkingbook
    {

        //private static Parkingbook parkingbook = new Parkingbook();//Синглтон.       
        // private static int size = 7;
        private int count;
        private bool[] place;//масив місця на парковці.true->зайняте місце.фолс-вільно.
        private List<Ticket> tickets = new List<Ticket>();//квитанції.
        private List<Car> cars = new List<Car>(); // список машин.

        //private Parkingbook(int count)
        //{
        //    place = new bool[count];
        //}

        public Parkingbook(int count)
        {
            place = new bool[count];
            this.count = count;

        }

        public int Carsize()
        {
            return count;
        }

        //public int Gersize()
        //{
        //    return count;
        //}

        //public Parkingbook this[int pa]
        //{
        //    get
        //    {
        //        return parkingbook[pa];
        //    }
        //}



        public void AddCar()
        {
            for (int i = 0; i < place.Length; i++)
            {
                if (place[i] == false)//якщо вільно
                {
                    place[i] = true;//стає зайнято
                    cars.Add(new Car());
                    return;
                }
            }
            Console.WriteLine("Вільних місць немає!");
        }

        public void DelCar(int number) // видалення машини по номеру машини.
        {
            foreach (Car car in cars)
            {
                if (car.GetNumbers() == number)
                {
                    cars.Remove(car);
                    place[car.GetNumbers()] = false;
                    Console.WriteLine(" Res: ");
                    return;
                }
            }
            Console.WriteLine("Немає такої машини: [{0}]", number);
        }

        public void PrintAllCar() // вывести всі машини.
        {
            foreach (Car car in cars)
            {
                Console.WriteLine("Hомер машини"+car.GetNumbers()+"Модель "+car.GetModels());
            }
        }

        public double GetAllFine()//сума штрафів.
        {
            double sum = 0;
            foreach (Ticket tic in tickets)
            {
                sum += tic.GetFine();
            }
            return sum;
        }

        public void AddToTickets(Ticket ticket)
        {
            this.tickets.Add(ticket);
        }


        //public void Statistic()
        //{
        //    Console.WriteLine($"\nКількість вільних місць - {(double)(size -cars.Count )}");
        //    Console.WriteLine($"\nКількість зайнятих місць - {(double)cars.Count-size}");
        //}

        //public static Parkingbook Create()
        //{
        //    if (parkingbook == null)
        //    {
        //        parkingbook = new Parkingbook();
        //    }
        //    return parkingbook;
        //}
    }
}
