using System;
using System.Collections.Generic;
using System.Text;

namespace Parking
{
    class Parker
    {

        Parkingbook p = Parkingbook.Instance;
        public static string parkername;

        public void Add()
        {
            p.AddCar(new Car());
        }

        public void Del()
        {
            try
            {     
                int del;
                Console.WriteLine("Enter number for delete: ");
                del = int.Parse(Console.ReadLine());
                Car car=p.DelCar(del);
                Ticket ticket = new Ticket(car);
                ticket.PrintTicket();
                p.AddToTickets(ticket);

            }
            catch
            {
                Console.WriteLine("Такого авто немає у списку");
            }
        }

        public void ShowAllCars()
        {                     
             p.PrintAllCar();     
            
        }              

        public void Info()
        {
            p.Info();
        }

        public void Statist()
        {
            p.Statistic();
        }

    }
}
