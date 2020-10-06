using System;
using System.Collections.Generic;
using System.Collections.Specialized;
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

        // Static ctor;
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
            name = _name;
            surname=_surname;
            position = _position;
            contract = _contract;
            salary = _salary;
            journal.Add(contract, FullName);
            Console.WriteLine("Added to journal");
        }

        public void Show()
        {          
            Console.WriteLine("Name:{0} ",_name);
            Console.WriteLine("Surname: {0} ",_surname);
            Console.WriteLine("Position:{0} ",_position);
            Console.WriteLine("Contract:{0} ",_contract);
            Console.WriteLine("Salary:{0} ",_salary);        


        }

    }
}
