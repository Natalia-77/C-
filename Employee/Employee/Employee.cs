using System;
using System.Collections;
using System.Collections.Generic;
using System.Collections.Specialized;
using System.Linq;
using System.Runtime.Serialization;
using System.Text;

namespace Employee
{
     class Employee
    {
        static ListDictionary journal;
        private static string _name;
        private static string _surname;
        private static string _position;
        private static string _contract;
        private static short _salary;
       

        // Максимальний розмір списку працівників.
        private static int maxcount;

        public string Name { get; set; }
        
        public string SurName { get; set; }
        
        public string Position { get; set; }

        public string Contract { get; set; }

        public short Salary { get; set; }
       
        // Static ctor.
        static Employee()
        {
            Employee.journal = new ListDictionary();
            maxcount = 6;
        }

        public static string FullName
        {
            get => _name + " " + _surname;
        }         

        public Employee(string name, string surname, string position, string contract, short salary)
        {
            bool flag = false;
           
            do
            {

                try
                {
                    if (!name.All(x => char.IsLetter(x)))
                    {
                        throw new Exception();
                    }
                    else
                    {
                        _name = name;
                        flag = true;
                    }
                }
                catch (Exception)
                {
                    Console.WriteLine($"Помилка в імені '{name}',введіть коректне:\t");
                    Console.Clear();
                    Console.Write("Введіть нове ім'я : ");
                    name = Console.ReadLine();
                    _name = name;
                    flag = true;
                }
            }
            while (!flag);

            do
            {

                try
                {
                    if (!surname.All(x => char.IsLetter(x)))
                    {
                        throw new Exception();
                    }
                    else
                    {
                        _surname = surname;
                        flag = true;
                    }
                }
                catch (Exception)
                {
                    Console.WriteLine($"Помилка в прізвищі '{surname}',введіть коректне:\t");
                    Console.Clear();
                    Console.Write("Введіть нове ім'я : ");
                    surname = Console.ReadLine();
                    _surname = surname;
                    flag = true;
                }
            } while (!flag);

            // Посада працівника.
            _position = position;

            // Номер трудового договору.
            _contract = contract;

            // Оклад.
           
            do
            {
                try
                {
                    if (!(salary is short))
                    {
                        throw new Exception();
                    }
                    else flag = true;

                }
                catch (Exception)
                {
                    Console.WriteLine($"Помилка в введеному числі '{salary}',введіть коректне:\t");
                    Console.Clear();
                    Console.Write("Введіть нове число : ");
                    salary = short.Parse(Console.ReadLine());
                    flag = true;

                }

            } while (!flag);

            _salary = salary;

            do
            {

                try
                {
                    if (journal.Count >maxcount)
                    {
                        throw new Exception();
                       

                    }
                    else
                    {
                        journal.Add(_contract,FullName);
                        flag = true;

                    }
                }
                catch (Exception)
                {
                   // Console.WriteLine("Максимальна кількість перевищена.");
                    Console.WriteLine(journal.Count);
                    Console.Clear();
                     flag = true;
                }
            } while (!flag);
            
        }


        // Виводить значення "Ключ"-"Значення".
        public static void Show()
        {
            if (journal.Count > 0)
            {
                int count = 0;
                Console.WriteLine();
                Console.WriteLine("Ключ : номер договору ; Значення: Прізвище і імя працівника ");
                Console.WriteLine("------------------------------------------------------------");
                Console.WriteLine("№     KEY                               VALUE");
                foreach (DictionaryEntry de in journal)
                {
                    Console.WriteLine("{0,-5} {1,-33} {2,-30}", count++, de.Key, de.Value);                    
                                       
                }
                Console.WriteLine();               

            }
            else
            {
                Console.WriteLine("Немає що відображати,тут поки порожньо");
            }
        }
       
        public static  void ShowMyJournal()
        {
            Console.Clear();
            Console.WriteLine("Журнал працівників має наступні прізвища: ");
            Console.WriteLine("-------------------------------------------");
           
            foreach (var it in Employee.journal.Values)
            {
                Console.WriteLine(it.ToString());
               
            }
           
        }

        //!!!Ось тут маю питання.Вже в неділю спитаю!!!

        //public static void MyJournal()
        //{               
        //    Console.WriteLine("Введіть номер договору працівника:");
        //    string find = Console.ReadLine();
        //    foreach (var it in Employee.journal.Keys)
        //    {
        //        var employee = journal[find];

        //        Console.WriteLine("Прізвище: {0},Ім/я: {0}",_surname,_name);
        //            return;
                

        //    }            

        //}              


        public static void Delete()
        {
            bool flag1 = false;
            Console.WriteLine("Оберіть номер договору працівника ,якого потрібно видалити");
            string del = "";
            del = Console.ReadLine();

            do
            {

                try
                {                                  
                        if (!journal.Contains(del))
                        {
                            throw new Exception();
                        }

                    journal.Remove(del);
                    flag1 = true;
                }
                // Видалення даних з пустого масиву. 
                catch (Exception)
                {                 

                    if (Employee.journal.Count == 0)
                    {
                        Console.WriteLine("Список порожній");                        
                    }
                    Console.WriteLine("Уточніть дані,Не існує такого номеру договору");
                    return;
                }

            } while (!flag1);

        }
                
    }

    




}
