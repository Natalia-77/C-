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

        public string FullName
        {
            get => _name + " " + _surname;            
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
                catch (Exception )
                {
                    Console.WriteLine($"Помилка в імені '{this._name}',введіть коректне:\t");
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
            _position = position;
            _contract = contract;
            _salary = salary;
            journal.Add(_contract, this.FullName);
        }

        // Виводить інформацію про одного працівника.
        public void Shows()
        {
            Console.WriteLine("Name:{0} ", _name);
            Console.WriteLine("Surname: {0} ", _surname);
            Console.WriteLine("Position:{0} ", _position);
            Console.WriteLine("Contract:{0} ", _contract);
            Console.WriteLine("Salary:{0} ", _salary);

        }

        // Виводить значення "Ключ"-"Значення".
        public static void Show()
        {
            Console.WriteLine();      
            Console.WriteLine("   KEY                       VALUE");

            foreach (DictionaryEntry de in journal)
            {
                Console.WriteLine("   {0,-25} {1}", de.Key, de.Value);
            }
            Console.WriteLine();
        }



    }

    




}
