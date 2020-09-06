using System;
using System.Collections.Generic;
using System.Text;

namespace ConsoleApp1
{
    class Student
    {

        private readonly string _surname;
        private readonly string _name;
        private readonly string _secondname;
        private readonly string _group;
        private readonly DateTime dates;
        private int [] Marks = new int[5];//масив оцінок.


        public int this[int x]
        {
            get { return Marks[x]; }
            set { Marks[x] = value; }
        }
    }
}
