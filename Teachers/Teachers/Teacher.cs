using System;
using System.Collections.Generic;
using System.Text;

namespace Teachers
{
    class Teacher
    {
        public string _name { get; set; }
        public string _surname { get; set; }
        public int _salary { get; set; }

        public static List<Teacher> GetList()
        {
            List<Teacher> teach = new List<Teacher>()
            {
                    new Teacher(){_name="Ivan",_surname="Petrov",_salary=1400},
                    new Teacher(){_name="Karina",_surname="Oreshko",_salary=3200},
                    new Teacher(){_name="Marina",_surname="Poroshenko",_salary=5000},
                    new Teacher(){_name="Victor",_surname="Ushchenko",_salary=2200},
                    new Teacher(){_name="Victor",_surname="Yanukovich",_salary=1000},
                    new Teacher(){_name="Volodymyr",_surname="Zelenskiy",_salary=3200},
                    new Teacher(){_name="Olena",_surname="Kravets",_salary=5400},
                    new Teacher(){_name="Anton",_surname="Kyzmin",_salary=1200},
                    new Teacher(){_name="Natalia",_surname="Kyzmenko",_salary=3700},
                    new Teacher(){_name="Iryna",_surname="Melnichyik",_salary=8000},
                    new Teacher(){_name="Tetiana",_surname="Prokhorenko",_salary=6200},
                    new Teacher(){_name="Katya",_surname="Levchuyik",_salary=9200},
                    new Teacher(){_name="Lyidmyla",_surname="Palamarcuik",_salary=5300},
                    new Teacher(){_name="Svetlana",_surname="Lana",_salary=8400},
                    new Teacher(){_name="Oleksandr",_surname="Ushchyik",_salary=9500},
                    new Teacher(){_name="Pavlo",_surname="Polino",_salary=2000},
                    new Teacher(){_name="Milana",_surname="Pretinok",_salary=4500},
                    new Teacher(){_name="Liliya",_surname="Belka",_salary=6850},
                    new Teacher(){_name="Olga",_surname="Strelka",_salary=4620},
                    new Teacher(){_name="Maxim",_surname="Lokh",_salary=3200},
                    new Teacher(){_name="Larisa",_surname="Batcus",_salary=2300},
                    new Teacher(){_name="Misha",_surname="Kisha",_salary=8520},
                    new Teacher(){_name="Petro",_surname="Palyanitsa",_salary=6250},
                    new Teacher(){_name="Nadia",_surname="Meykher",_salary=6600},
                    new Teacher(){_name="Nina",_surname="Matvienko",_salary=8820},
                    new Teacher(){_name="Pavlo",_surname="Zibrov",_salary=3266},
                    new Teacher(){_name="Ivo",_surname="Bobul",_salary=8952},
                    new Teacher(){_name="Stepan",_surname="Giga",_salary=9630},
                    new Teacher(){_name="Liliya",_surname="Sandulesa",_salary=1110},
                    new Teacher(){_name="Victor",_surname="Pavlic",_salary=4110}
            };
            return teach;
        }
        
        public override string ToString()
        {
            return string.Format($"Name:{_name,-10} Surname: {_surname,-15}  Salary: {_salary} ");
        }

    }
}
