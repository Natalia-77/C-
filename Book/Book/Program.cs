using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Book
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.OutputEncoding = Encoding.Unicode;
            Console.InputEncoding = Encoding.Unicode;

            List<Book> book = new List<Book>();

            book.Add(new Book("Війна і мир", "1918", 200));
            book.Add(new Book("Лісова пісня", "2019", 120));
            book.Add(new Book("Іліада Одісея", "1952", 320));
            book.Add(new Book("Фауст", "2019", 50));
            Console.WriteLine("Весь список:\n");

            foreach (var item in book)
            {
                Console.WriteLine("Назва :{0} , Ціна: {1} , Рік: {2} ",
                    item.Name, item.Price, item.Year);
            }
            Console.WriteLine();

            Console.WriteLine("-----------------------------------------------------");
            Console.WriteLine("Вивести всі книжки,вартість яких дорожче вказаної ціни");
            int price =int.Parse(Console.ReadLine());

            IEnumerable<Book> prices = book.Where(x => x.Price>price).ToList();

            foreach (var item in prices)
            {
                Console.WriteLine(item.Name);
            }
            Console.WriteLine();

            Console.WriteLine("--------------------------------------------------");
            Console.WriteLine("Вибрати всі книжки, які видавались за останній рік");
            
            IEnumerable<Book> years =book.Where(x => x.Year=="2019").ToList();
            foreach (var item in years)
            {
                Console.WriteLine("Назва книжок :{0}",item.Name);
            }
            Console.WriteLine();

            Console.WriteLine("---------------------------------------------");
            Console.WriteLine("На основі колекції книжок сформувати колекцію," +
                " яка містить лише назви книжок");

            IEnumerable<string> namesbooks = book.Select(x => x.Name).ToList();
                        
            foreach (var item in namesbooks)
            {
                Console.WriteLine(item);

            }
        }
    }
}
