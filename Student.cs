//using System;
//using System.Collections.Generic;
//using System.Text;

//namespace ConsoleApp1
//{
//    class Student
//    {   

//        private  string _surname;
//        private  string _name;
//        private  string _secondname;
//        private  string _group;
//        private  DateTime dates;
//        private  int[][] Classes = new int[3][] { new int[0], new int[0], new int[0] };   //рваний масив -предмети,з яких будуть проставлені оцінки.


//        public Student(string surname, string name, string secondname, string group, DateTime date)//конструктор приймає,ПІБ,групу та дату народження.
//        {
//            _surname = surname;
//            _name = name;
//            _secondname = secondname;
//            _group = group;
//            dates = date;
//        }

//        public void InfoStud()
//        {
//            Console.WriteLine(string.Format("Повне прізвище,імя,по-батькові студента: [ {0} - {1} - {2}]\n", _surname, _name, _secondname));
//        }

//        public void FillArrayProg(int[][] Classes)//заповнення масиву оцінок.
//        {

//            for (int i = 0; i < Classes.Length; i++)
//            {

//                Console.Write("Введіть кількість оцінок ,яка буде виставлена по предмету в {0} строці:", i);

//                int j = int.Parse(Console.ReadLine());
//                Classes[i] = new int[j];

//                for (j = 0; j < Classes[i].Length; j++)
//                {

//                    Console.Write("Оцінка по предмету {0} номер {1}- ", i+1, j+1); Classes[i][j] = int.Parse(Console.ReadLine());

//                }

//            }

//            Console.WriteLine("==================\n");     
//        }

        

//        public void PrintInfo(int[][] Classes)
//        {
//            DateTime today = DateTime.Today;
//            TimeSpan age = today - dates;
//            double ageInDays = age.TotalDays;    
//            double daysInYear = 365;        
//            double ageInYears = ageInDays / daysInYear;

//            Console.WriteLine("Ім я " + _name);
//            Console.WriteLine("Прізвище " + _surname);
//            Console.WriteLine("По-батькові " + _secondname);
//            Console.WriteLine("Група " + _group);
//            Console.WriteLine("Дата народження " + "D:"+dates.ToString("D"));
//            Console.WriteLine("Вік студента "+(int)ageInYears);

//            Console.Write("Дисципліна --Програмування-- ");
//            double sp = 0, sa = 0, sd = 0;
//            for (int i = 0; i < Classes[0].Length; i++)
//            {
//                sp += Classes[0][i];
//                Console.Write(Classes[0][i] + " ");
//            }
//            double res1 = sp / Classes[0].Length;
//            Console.WriteLine($"Середній бал {Math.Round(res1, 0)} ", res1);

//            Console.Write("Дисципліна --Адміністрування-- ");
//            for (int i = 0; i < Classes[1].Length; i++)
//            {
//                sa += Classes[1][i];
//                Console.Write(Classes[1][i] + " ");
//            }
//            double res2 = sa / Classes[1].Length;
//            Console.WriteLine($"Середній бал {Math.Round(res2, 0)} ", res2);

//            Console.Write("Дисципліна --Дизайн-- ");
//            for (int i = 0; i < Classes[2].Length; i++)
//            {
//                sd += Classes[2][i];
//                Console.Write(Classes[2][i] + " ");
//            }
//            double res3 = sa / Classes[2].Length;
//            Console.WriteLine($"Середній бал {Math.Round(res3, 0)} ", res3);
//        }



//        static void Main(string[] args)
//        { 
//                 Console.OutputEncoding = Encoding.Unicode;
//                 Console.InputEncoding = Encoding.Unicode;

//                 int[][] arr = new int[3][];

//                 Student s = new Student("Ivanov", "Vanya", "Petrovych", "15-АП", new DateTime(1992, 10, 12));
//                 s.FillArrayProg(arr);
//                 s.PrintInfo(arr);
                
//        }
        

        
//    }

    
//}
