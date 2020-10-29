using System;
using System.Collections.Generic;
using System.Runtime.Serialization;
using System.Text;

namespace Students
{
    [DataContract]
    class Student
    {
        [DataMember]
        public string _name { get; set; }
        [DataMember]
        public string _surname { get; set; }
        [DataMember]
        public int _group { get; set; }

        public Student() { }

        public Student(string name,string surname,int group)
        {
            _name = name;
            _surname = surname;
            _group = group;
        }

        public static List<Student> GetList()
        {
            List<Student> teach = new List<Student>()
            {
                    //new Student()
                    //{
                    //    _name="Ivan",
                    //    _surname="Petrov",
                    //    _group=1
                    //},
                    //new Student()
                    //{
                    //    _name="Karina",
                    //    _surname="Oreshko",
                    //    _group=2
                    //},
                    //new Student()
                    //{
                    //    _name="Marina",
                    //    _surname="Poroshenko",
                    //    _group=4
                    //},
                    //new Student()
                    //{
                    //    _name="Victor",
                    //    _surname="Ushchenko",
                    //    _group=3
                    //},
                    //new Student()
                    //{
                    //    _name="Victor",
                    //    _surname="Yanukovich",
                    //    _group=2
                    //},
                    //new Student()
                    //{
                    //    _name="Volodymyr",
                    //    _surname="Zelenskiy",
                    //    _group=4
                    //},
                    //new Student()
                    //{
                    //    _name="Olena",
                    //    _surname="Kravets",
                    //    _group=3
                    //},
                    //new Student()
                    //{
                    //    _name="Anton",
                    //    _surname="Kyzmin",
                    //    _group=5
                    //},
                    //new Student()
                    //{
                    //    _name="Natalia",
                    //    _surname="Kyzmenko",
                    //    _group=4
                    //},
                    //new Student()
                    //{
                    //    _name="Iryna",
                    //    _surname="Melnichyik",
                    //    _group=8
                    //},
                    //new Student()
                    //{
                    //    _name="Tetiana",
                    //    _surname="Prokhorenko",
                    //    _group=6
                    //},
                    //new Student()
                    //{
                    //    _name="Katya",
                    //    _surname="Levchuyik",
                    //    _group=9
                    //},
                    //new Student()
                    //{
                    //    _name="Lyidmyla",
                    //    _surname="Palamarcuik",
                    //    _group=5
                    //},
                    //new Student()
                    //{
                    //    _name="Svetlana",
                    //    _surname="Lana",
                    //    _group=8
                    //},
                    //new Student()
                    //{
                    //    _name="Oleksandr",
                    //    _surname="Ushchyik",
                    //    _group=6
                    //},
                    new Student()
                    {
                        _name="Pako",
                        _surname="Rabann",
                        _group=2},
                   
            };
            return teach;
        }

        public override string ToString()
        {
            return string.Format($"Name:{_name,-10} Surname: {_surname,-15}  Group: {_group} ");
        }

    }

}

