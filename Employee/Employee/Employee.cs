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
        public static ListDictionary journal;
        private string _name;
        private string _surname;
        private string _position;
        private string _contract;
        private short _salary;

        // Максимальний розмір списку працівників.
        const int maxcount = 5;

        public string Name
        {
            get => _name;
            set => _name = value;
        }

        public string SurName
        {
            get => _surname;
            set => _surname = value;
        }

        public string Position
        {
            get => _position;
            set => _position = value;
        }

        public string Contract
        {
            get => _contract;
            set => _contract = value;
        }

        public short Salary
        {
            get => _salary;
            set => _salary = value;
        }

        // Static ctor.
        static Employee()
        {
            journal = new ListDictionary();
        }

        public Employee()
        {

        }
        public string FullName
        {
            get => _name + " " + _surname;            
        }         
        

        public void AddEmloyee()
        {
            

            Console.WriteLine("Введіть імя працівника :");
            string name = Console.ReadLine();
           
            bool flag = false;
            _name = name;
            do
            {

                try
                {
                    if (!_name.All(x => char.IsLetter(x)))
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
                    Console.WriteLine($"Помилка в імені '{_name}',введіть коректне:\t");
                    Console.ReadKey();
                    Console.WriteLine();                   
                    Console.Write("Введіть нове ім'я : ");
                    _name = Console.ReadLine();
                    
                    flag = true;
                }
            }
            while (!flag);


            Console.WriteLine("Введіть прізвище працівника :");
            string surname = Console.ReadLine();
            _surname = surname;

            do
            {
                try
                {
                    if (!_surname.All(x => char.IsLetter(x)))
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
                    Console.WriteLine($"Помилка в прізвищі '{_surname}',введіть коректне:\t");
                    Console.ReadKey();
                    Console.WriteLine();
                    Console.Write("Введіть нове ім'я : ");
                    _surname = Console.ReadLine();
                    
                    flag = true;
                }
            } while (!flag);

            Console.WriteLine("Введіть посаду працівника (може містити символи і літери) :");
            string position = Console.ReadLine();
            _position = position;

            Console.WriteLine("Введіть номер трудового договору (може містити літери,символи) працівника :");
            string contract = Console.ReadLine();
            _contract = contract;

            short salary;

            do
            {
                try
                {
                    checked
                    {
                         Console.WriteLine("Введіть розмір заробітної плати працівника :");                       
                         salary = Convert.ToInt16(Console.ReadLine());

                        // Це для довідки просто виводила,щоб контролювати,який саме тип змінної ввели.
                        Console.WriteLine($"Тип введеної змінної : {Convert.ToInt16(salary).GetType()}");                       
                        
                    }

                }
                catch(Exception)
                {
                    Console.WriteLine("Ви ввели завелике число,введіть коректне\t");
                    Console.Write("Введіть нове число : ");
                    salary = Convert.ToInt16(Console.ReadLine());                                 
                    flag = true;

                }                         


            } while (!flag);

           _salary = salary;


            try
            {
                if (journal.Count >= maxcount)
                {
                    throw new Exception();
                }
                else
                {
                    journal.Add(_contract, FullName);
                }
            }
            catch (Exception)
            {
                Console.WriteLine("Максимальна кількість перевищена ");
            }


        }

        public Employee(string name, string surname, string position, string contract, short salary)
        {            
            
            bool flag = false;            
           _name = name;
            do
            {

                try
                {
                    if (!_name.All(x => char.IsLetter(x)))
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
                    Console.WriteLine($"Помилка в імені '{_name}',введіть коректне:\t");
                    Console.ReadKey();
                    Console.Clear();
                    Console.Write("Введіть нове ім'я : ");
                    _name = Console.ReadLine();
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
                    if (!_surname.All(x => char.IsLetter(x)))
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
                    Console.WriteLine($"Помилка в прізвищі '{_surname}',введіть коректне:\t");
                    Console.ReadKey();
                    Console.Clear();
                    Console.Write("Введіть нове ім'я : ");
                    _surname = Console.ReadLine();
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
                    if (!(_salary is short))
                    {
                        throw new Exception();
                    }
                    else flag = true;
                   
                }
                catch(Exception)
                {
                    Console.WriteLine($"Помилка в введеному числі '{_salary}',введіть коректне:\t");
                    Console.ReadKey();
                    Console.Clear();
                    Console.Write("Введіть нове число : ");
                    _salary =short.Parse( Console.ReadLine());                   
                    flag = true;
                   
                }

            } while (!flag);


            try
            {
                if (journal.Count >= maxcount)
                {
                    throw new Exception();
                }
                else
                {
                    journal.Add(_contract, this.FullName);
                }
            }
            catch(Exception)
            {
                Console.WriteLine("Максимальна кількість перевищена.");
            }
                       
            //journal.Add(_contract, this.FullName);
        }

        // Виводить інформацію про одного працівника.
        public void Shows()
        {
            Console.WriteLine("*********************");
            Console.WriteLine("Name:{0} ", _name);
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
                Console.WriteLine("   KEY                       VALUE");

                foreach (DictionaryEntry de in journal)
                {
                    Console.WriteLine("{0} {1,-25} {2}", count++, de.Key, de.Value);

                }
                Console.WriteLine();
            }
            else
            {
                Console.WriteLine("Немає що відображати,тут поки порожньо");
            }
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
