using System;
using System.Collections.Generic;
using System.Text;

namespace Parking
{
    class Parkingbook
    {

        
        private static readonly Lazy<Parkingbook> instance = new Lazy<Parkingbook>(() => new Parkingbook());
        public static Parkingbook Instance => instance.Value;
        private List<Car> cars;
        private List<Ticket> ticket;
        private static readonly int parkingSpace = 10;// max places
       
        private Parkingbook()//приватний конструктор Синглтон.
        {
            cars = new List<Car>(parkingSpace);
            ticket = new List<Ticket>();
           
        }

        public int GetAllSize() => ticket.Count;//всього місць на парковці.

        public int GetFreeParking() => ticket.Count-cars.Count;//кількість вільних місць на парковці.

        public void AddCar(Car car)
        {

            //if (GetFreeParking() == 0)
            //{
            //    throw new InvalidOperationException("Вільних місць немає!");
            //}

            cars.Add(car);
               
            
        }            
        

        public Car DelCar(int number) // видалення машини по номеру машини.
        {
            foreach (Car car in cars)
            {
                if (car.GetNumbers() == number)
                {
                    cars.Remove(car);
                    
                    return car;
                }
            }
            Console.WriteLine("Немає такої машини: [{0}]", number);
            return null;
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
            foreach (Ticket tic in ticket)
            {
                sum += tic.GetFine();
            }
            return sum;
        }

        public void AddToTickets(Ticket t)
        {
            this.ticket.Add(t);
        }

    }
}
