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
        private int carSpace = 0;
       
        private Parkingbook()//приватний конструктор Синглтон.
        {
            cars = new List<Car>(carSpace);
            ticket = new List<Ticket>(parkingSpace);
           
        }

        public void Info()
        {
            Console.WriteLine("Всього місць на парковці "+parkingSpace);
            Console.WriteLine("Free places "+(parkingSpace-carSpace));
        }
                     
        public void AddCar(Car car)
        {
            cars.Add(car);
            carSpace++;                        
        }            
        

        public Car DelCar(int number) // видалення машини по номеру машини.
        {
            foreach (Car car in cars)
            {
                if (car.GetNumbers() == number)
                {
                    cars.Remove(car);
                    carSpace--;
                    return car;
                }
            }
            Console.WriteLine("Немає такої машини: [{0}]", number);
            return null;
        }

        public void PrintAllCar() //  всі машини.
        {
            Console.WriteLine("---------------------------------------------------------------------------------------------");
            Console.WriteLine("|Номер машини  |Модель  |Колір    |Дата заїзду           |Дата виїзду         |Оплачений час|");
            Console.WriteLine("--------------------------------------------------------------------------------------------");

            foreach (Car car in cars)
            {
                //Console.WriteLine("Hомер машини: "+car.GetNumbers()+car.GetLrtter()+"Модель: "+car.GetModels());
               
                Console.WriteLine("|{0} "+"{1}         |{2}    |{3}     |{4}  |{5} |{6}    |",car.GetNumbers(),car.GetLrtter(),car.GetModels(),car.GetColors(),car.GetTime().GetTimeStart(),car.GetTime().GetTimeEnd(),car.GetTime().GetTimePayed());
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
