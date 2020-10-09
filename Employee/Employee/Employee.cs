using System;
using System.Collections;
using System.Collections.Generic;
using System.Collections.Specialized;
using System.Linq;
using System.Runtime.Serialization;
using System.Text;

namespace Employee
{
     internal class Employee
    {
        public static ListDictionary journal;
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
            maxcount = 5;
        }        

        public static string FullName
        {
            get => _name + " " + _surname;
        }


        //public  void AddEmloyee()
        //{            

        //    Console.WriteLine("Введіть імя працівника :");
        //    string name = Console.ReadLine();
           
        //    bool flag = false;
        //    _name = name;
        //    do
        //    {

        //        try
        //        {
        //            if (!name.All(x => char.IsLetter(x)))
        //            {
        //                throw new Exception();
        //            }
        //            else
        //            {
        //                _name = name;
        //                flag = true;
        //            }
        //        }
        //        catch (Exception)
        //        {
        //            Console.WriteLine($"Помилка в імені '{name}',введіть коректне:\t");
        //            Console.ReadKey();
        //            Console.WriteLine();                   
        //            Console.Write("Введіть нове ім'я : ");
        //            name = Console.ReadLine();//11111
                    
        //            flag = true;
        //        }
        //    }
        //    while (!flag);


        //    Console.WriteLine("Введіть прізвище працівника :");
        //    string surname = Console.ReadLine();
        //    _surname = surname;

        //    do
        //    {
        //        try
        //        {
        //            if (!surname.All(x => char.IsLetter(x)))
        //            {
        //                throw new Exception();
        //            }
        //            else
        //            {
        //                _surname = surname;
        //                flag = true;
        //            }
        //        }
        //        catch (Exception)
        //        {
        //            Console.WriteLine($"Помилка в прізвищі '{surname}',введіть коректне:\t");
        //            Console.ReadKey();
        //            Console.WriteLine();
        //            Console.Write("Введіть нове прізвище : ");
        //            surname = Console.ReadLine();
                    
        //            flag = true;
        //        }
        //    } while (!flag);

        //    Console.WriteLine("Введіть посаду працівника (може містити символи і літери) :");
        //    string position = Console.ReadLine();
        //    _position = position;

        //    Console.WriteLine("Введіть номер трудового договору (може містити літери,символи) працівника :");
        //    string contract = Console.ReadLine();
        //    _contract = contract;

        //    short salary;

        //    do
        //    {
        //        try
        //        {
        //            checked
        //            {
        //                 Console.WriteLine("Введіть розмір заробітної плати працівника :");                       
        //                 salary = Convert.ToInt16(Console.ReadLine());

        //                // Це для довідки просто виводила,щоб контролювати,який саме тип змінної ввели.
        //                Console.WriteLine($"Тип введеної змінної : {Convert.ToInt16(salary).GetType()}");                       
                        
        //            }

        //        }
        //        catch(Exception)
        //        {
        //            Console.WriteLine("Ви ввели завелике число,введіть коректне\t");
        //            Console.Write("Введіть нове число : ");
        //            salary = Convert.ToInt16(Console.ReadLine());                                 
        //            flag = true;

        //        }                         


        //    } while (!flag);

        //   _salary = salary;

        //    do
        //    {

        //        try
        //        {
        //            if (journal.Count >= maxcount)
        //            {
        //                throw new Exception();
        //            }
        //            else
        //            {
        //                Employee.journal.Add(contract,this);
        //                //flag = false;
        //            }
        //        }
        //        catch (Exception)
        //        {
        //            Console.WriteLine("Максимальна кількість перевищена ");
        //        }
        //    } while (!flag);


        //}
        

        public Employee(string name, string surname, string position, string contract, short salary)
        {
            bool flag = false;
            _name = name;
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
                    Console.ReadKey();
                    Console.Clear();
                    Console.Write("Введіть нове ім'я : ");
                    name = Console.ReadLine();
                    //_name = name;
                    flag = true;
                }
            }
            while (!flag);

            _surname = surname;

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
                    Console.ReadKey();
                    Console.Clear();
                    Console.Write("Введіть нове ім'я : ");
                    surname = Console.ReadLine();
                    //_surname = surname;
                    flag = true;
                }
            } while (!flag);

            // Посада працівника.
            _position = position;

            // Номер трудового договору.
            _contract = contract;

            // Оклад.
            _salary = salary;
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
                    Console.ReadKey();
                    Console.Clear();
                    Console.Write("Введіть нове число : ");
                    salary = short.Parse(Console.ReadLine());
                    flag = true;

                }

            } while (!flag);

            do
            {


                try
                {
                    if (journal.Count >= maxcount)
                    {
                        throw new Exception();


                    }
                    else
                    {
                        journal.Add(_contract,this);
                        flag = true;

                    }
                }
                catch (Exception)
                {
                    // Console.WriteLine("Максимальна кількість перевищена.");
                    // flag = true;
                }
            } while (!flag);
            // journal.Add(_contract, FullName);
        }



        // Виводить інформацію про одного працівника.
        public  void Shows()
        {
            Console.WriteLine();
            Console.WriteLine("*********************");
            Console.WriteLine("Name {0}: ", _name);
            Console.WriteLine("Surname: {0} ", _surname);
            Console.WriteLine("Position:{0} ", _position);
            Console.WriteLine("Contract:{0} ", _contract);
            Console.WriteLine("Salary:{0} ", _salary);

        }

        // Виводить значення "Ключ"-"Значення".
        public static void Show()
        {
            if (journal.Count > 0)
            {
                int count = 0;
                Console.WriteLine();
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
            Console.WriteLine("Вміст журналу працівників");
           
            foreach (var it in journal.Values)
            {
                if(it is Employee)
                {
                    Console.WriteLine(it.ToString());
                   
                }
               
            }
        }


        public override string ToString()
        {
            return $"\nID:\t\t{_contract}\nName:\t\t{FullName}\nPosition:\t{_position}\nSalary:\t\t{_salary}\n";
        }

       
            public void Delete()
        {
            
            Console.WriteLine("Оберіть номер договору працівника ,якого потрібно видалити");
            string del = "";
            del = Console.ReadLine();
            
                try
                {
                    // Видаляю по ключу.
                    journal.Remove(del);

                    if (!journal.Contains(del))
                    {
                        throw new Exception("Уточніть дані");
                    }                      
                    
                }

                // Видалення даних з пустого масиву. 
                catch (Exception)
                {
                    if (journal.Count == 0)
                    {
                        Console.WriteLine("Список порожній");                        
                    }
                                       
                }               
                     
            
        }

    }

    




}
