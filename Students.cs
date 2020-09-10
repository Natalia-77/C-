using System;
using System.Collections.Generic;
using System.Text;

namespace ConsoleApp1
{
    class Students
    {

        private string _surname;
        public string Surname
        {
            get { return _surname; }
            private set { _surname = value; }
        }

        private string _name;
        public string Name
        {
            get { return _name; }
            private set { _name = value; }
        }

        private string _secondname;
        public string Secondname
        {
            get { return _secondname; }
             private set { _secondname = value; }
        }
        private string _group;
        public string Group
        {
            get { return _group; }
            set { _group = value; }
        }

        private DateTime dates;

        private double[] marks = new double[5];//масив оцінок.
        public double this[int index]//індексатор.
        {
            get
            {
                return marks[index];
            }
            set
            {
                marks[index] = value;
            }
        }

        private double[][] Classes = new double[3][] { new double[0], new double[0], new double[0] };   //рваний масив -предмети,з яких будуть проставлені оцінки.
        public double[][] Classe
        {
            get { return Classes; }
        }

        public Students(string surname, string name, string secondname, string group, DateTime date)//конструктор приймає,ПІБ,групу та дату народження.
        {
            _surname = surname;
            _name = name;
            _secondname = secondname;
            _group = group;
            dates = date;
            for (int i = 0; i < marks.Length; i++)
            {
                marks[i] = 0;
            }
            Classes[0] = new double[5];
            Classes[1] = new double[5];
            Classes[2] = new double[5];

        }

        
        public string Full//readonly property повне імя студента.
        {
            get
            {
                return (_surname +' '+ _name +' '+ _secondname);
                
            }
        }

        public void SetProg(int[] a)//встановлення оцінок по Програмуванню.
        {
            int n;
            Console.WriteLine("Введіть кількість оцінок,яка буде виставлена по дисципліні --Програмування--\n");
            n = Int32.Parse(Console.ReadLine());
            marks = new double[n];
            for (int i = 0; i != n; ++i)
            {
                marks[i] = Classes[0][i]; Console.Write("Оцінка номер [{0}]",i+1);
                Classes[0][i] = int.Parse(Console.ReadLine());
               

            }
            
            Console.WriteLine();
           
        }



          public void SetDesign(int[] a)//встановлення оцінок по Дизайну.
          {
                int n;
                Console.WriteLine("Введіть кількість оцінок,яка буде виставлена по дисципліні --Дизайн--\n");
                n = Int32.Parse(Console.ReadLine());
                marks = new double[n];
                for (int i = 0; i != n; ++i)
                {
                    marks[i] = Classes[1][i]; Console.Write("Оцінка номер [{0}]", i + 1);
                    Classes[1][i] = int.Parse(Console.ReadLine());
                   
                }
                Console.WriteLine();
            
          }


         public void SetAdmin(int[] a)//встановлення оцінок по Адмініструванню.
         {
                int n;
                Console.WriteLine("Введіть кількість оцінок,яка буде виставлена по дисципліні --Адміністрування--\n");
                n = Int32.Parse(Console.ReadLine());
                marks = new double[n];
                for (int i = 0; i != n; ++i)
                {
                    marks[i] = Classes[2][i]; Console.Write("Оцінка номер [{0}]", i + 1);
                    Classes[2][i] = int.Parse(Console.ReadLine());                   

                }
                Console.WriteLine();
         }

        public double AveProg//середній бал про Програмуванню.
        {
           
            get
            {
                double sp = 0;
                int counter = 0;
                
                for (int i = 0; i < Classes[0].Length; i++)
                {
                        sp += Classes[0][i];
                        if(Classes[0][i]!=0)
                        counter++;                 


                }
               
                double a = sp/counter ;
               // Console.WriteLine($"Середній бал по дисципліні Програмування:{Math.Ceiling(a) } ", a);
                return a;
            }


        }

        public double AveDes//середній бал по Дизайну.
        {

            get
            {
                double sd = 0;
                int counter1 = 0;
                for (int i = 0; i < Classes[1].Length; i++)
                {                   
                    sd += Classes[1][i];
                    if(Classes[1][i]!=0)
                    counter1++;
                   
                }
                double d = sd / counter1;
                //Console.WriteLine($"Середній бал по дисципліні Дизайн :{Math.Ceiling(d) } ", d);
                return d;
            }


        }


        public double AveAd//середній бал по Адмініструванню.
        {

            get
            {
                double sa = 0;
                int counter2 = 0;
                for (int i = 0; i < Classes[2].Length; i++)
                {                   
                    sa += Classes[2][i];
                    if(Classes[2][i]!=0)
                    counter2++;       
                                        
                }
                double b = sa / counter2;
               // Console.WriteLine($"Середній бал по дисципліні Адміністрування: {Math.Ceiling(b) } ", b);
                 return b;
            }


        }


        public double Finall//середній бал по всім предметам.
        {

            get
            {
                double fin = 0;
                int col= 0;

                for (int i = 0; i < Classes.Length; i++)
                {

                    for (int j = 0; j < Classes[i].Length; j++)
                    {
                        fin += Classes[i][j];
                        if (Classes[i][j] != 0)
                        col++;
                    }

                    Console.WriteLine();

                }
                double c = fin/ col;
                // Console.WriteLine($"Середній бал по по всіх дисциплінах: {Math.Ceiling(с) } ", с);
                return c;
            }


        }

        public void Age(DateTime dates)
        {
            DateTime today = DateTime.Today;
            TimeSpan age = today - dates;
            double ageInDays = age.TotalDays;
            double daysInYear = 365;
            double ageInYears = ageInDays / daysInYear;
            Console.WriteLine("Вік студента " + (int)ageInYears);
           
        }

        public void Clear()
        {

            for (int i = 0; i < Classes.Length; i++)
            {

                for (int j = 0; j < Classes[i].Length; j++)
                {

                    if (Classes[i][j] != 0)
                    {
                        Classes[i][j] =0;
                    }

                }

               

            }

        }



        public void PrintInfo()
        {
            //DateTime today = DateTime.Today;
            //TimeSpan age = today - dates;
            //double ageInDays = age.TotalDays;
            //double daysInYear = 365;
            //double ageInYears = ageInDays / daysInYear;

            Console.WriteLine("Ім я " + _name);
            Console.WriteLine("Прізвище " + _surname);
            Console.WriteLine("По-батькові " + _secondname);
            Console.WriteLine("Група " + _group);
            Console.WriteLine("Дата народження " + dates.ToString("D"));
            Console.WriteLine("=========================");            
            Console.Write("Дисципліна --Програмування-- ");
            double sp = 0, sa = 0, sd = 0;
            for (int i = 0; i < Classes[0].Length; i++)
            {
                sp += Classes[0][i];
                Console.Write(Classes[0][i] + " ");
            }
            Console.WriteLine();

            Console.Write("Дисципліна --Адміністрування-- ");
            for (int i = 0; i < Classes[1].Length; i++)
            {
                sa += Classes[1][i];
                Console.Write(Classes[1][i] + " ");
            }
            Console.WriteLine();

            Console.Write("Дисципліна --Дизайн-- ");
            for (int i = 0; i < Classes[2].Length; i++)
            {
                sd += Classes[2][i];
                Console.Write(Classes[2][i] + " ");
            }
            Console.WriteLine();
        }


        public void Print()
        {
            Console.WriteLine("group"+_group);
            for (int i = 0; i < Classes.Length; i++)
            {

                for (int j = 0; j < Classes[i].Length; j++)
                {
                    Console.Write("{0} ", Classes[i][j]);
                }

                Console.WriteLine();

            }

        }
        
    }

    class Program
    { 
    
        static void Main(string[] args)
        {
            Console.OutputEncoding = Encoding.Unicode;
            Console.InputEncoding = Encoding.Unicode;

            int[] arr = new int[20];
          
            
            Students s = new Students("Petrov", "Ivan", "Petrovych", "15-АП", new DateTime(1992, 10, 12));
            //-----Повне прізвище,ім"я,по-батькові--------
            Console.WriteLine("Повне прізвище, ім!я, по - батькові студента {0}",s.Full);
           

            //----Встановлення оцінок по дисциплінам--------
             s.SetProg(arr);
             s.SetDesign(arr);
             s.SetAdmin(arr);
            // s.Print();

            //-----Cередній бал з програмування-----------
            Console.WriteLine($"Середній бал по дисципліні Програмування: {Math.Ceiling(s.AveProg) }", s.AveProg);
            Console.WriteLine($"Середній бал по дисципліні Дизайн : {Math.Ceiling(s.AveDes) } ", s.AveDes);
            Console.WriteLine($"Середній бал по дисципліні Адміністрування :{Math.Ceiling(s.AveAd) } ", s.AveAd);
            Console.WriteLine($"Середній бал по всім дисциплінам :{Math.Ceiling(s.Finall) } ", s.Finall);

            //----Вік студента----
            //----Вводити дату народження(щоб порахувало повних років) через крапку в один рядок.Наприклад,12.08.1990
            //Console.WriteLine("Введіть дату народження студента(через крапку в один рядок)");
            //string age = Console.ReadLine();
            //DateTime birth = DateTime.Parse(age);                    
            //s.Age(birth);
            //----Заміна номеру групи на новий------
            Console.WriteLine("Заміна номеру групи на новий: ");
            s.Group = "22-КЕ";
            s.PrintInfo();
           // s.Print();
            //----Очищення оцінок--------
           // s.Clear();
            //s.Print();



        }



    }


}
   
