using System;
using System.Collections.Generic;
using System.Text;
using System.Linq;

namespace ConsoleApp1
{


    class Programm
    {
        static void CoString(string stroka)
        {
            int kol = 0;//лічильник кількості літер в строці.
            int koldigit = 0, kolprep = 0;
            int pkol = 0;
            string punkt = ".,!?";
            string probel = " ";
           
            Console.WriteLine("Кількість символів в строці :{0}", stroka.Length);
            Console.WriteLine("===============================");
            foreach (var el in stroka)
            {
                if (char.IsLetter(el))
                    kol++;
                if (char.IsDigit(el))
                    koldigit++;
                foreach (char punct in punkt)
                    if (el == punct)                   
                        kolprep++;                        
                foreach(char p in probel)
                        if(el==p)                   
                        pkol++;             

                
            }
                Console.WriteLine("Кількість літер в строці :{0}", kol);
                Console.WriteLine("Кількість літер у нижньомі регістрі : " + stroka.Count(Char.IsLower));
                Console.WriteLine("Кількість літер у верхньому регістрі : " + stroka.Count(Char.IsUpper));
                Console.WriteLine("Кількість цифр у строці:{0}", koldigit);
                Console.WriteLine("Кількість знаків пунктуації {0}",kolprep);
                Console.WriteLine("Кількість пробілів {0}",pkol);
               
                
            


        }

        static void Main(string[] args)
        {
            Console.OutputEncoding = Encoding.Unicode;
            Console.InputEncoding = Encoding.Unicode;

            

            Console.WriteLine("ввести строку =");
            string s = Console.ReadLine();
            Console.WriteLine();
            CoString(s);
            Console.WriteLine("===================");
            //Console.WriteLine("ввести символ =");
            //string str = Console.ReadLine();
            //s = s.Replace(str, str.ToUpper());
            //Console.WriteLine(s);
            //Console.WriteLine("===================");


            //int find = s.LastIndexOf(str, s.Length - 1, StringComparison.CurrentCultureIgnoreCase);//шукає індекс входження підстроки в строку.
            //Console.Write(find);//вивела в консоль індекс(просто для перевірки)

            //s = s.Remove(find + 1);
            //Console.WriteLine(s);
            //Console.WriteLine("===================");



            //Console.Write("ввести строку 1 = ");
            //string s1 = Console.ReadLine();
            //Console.Write("ввести строку 2 = ");
            //string s2 = Console.ReadLine();

            //int count = 0,//рахує кількість видалених літер.
            //len = s2.Length;
            //string s3 = "";//створила додаткову строчку,куди буду записувати видалені літери.

            //for (int i = 0; i < s1.Length; i++)
            //{

            //    for (int j = 0; j < s2.Length; j++)
            //    {
            //        if (s1[i] == s2[j])
            //        {
            //            if (s2.Contains(s1[i]))
            //            {

            //                s3 += s1[i];//ось тут записую в новостворену строчку значення видалених символів.

            //            }

            //            s1 = s1.Remove(i, 1);
            //            count++;
            //            break;

            //        }
            //    }
            //}

            //Console.WriteLine("Строка 1: {0}", s1);
            //Console.WriteLine("Строка 2: {0}", s2);
            //Console.WriteLine("Строка 3: {0}", s3);
            //Console.WriteLine("Всього видалено {0}", count);
            //Console.WriteLine("Довжина Строки 1 після видалення:{0} ",s1.Length);

            //int kol = 0; //кількість літер.
            //char pred = ' '; //попередній символ.

            //foreach (char ch in s3) //тут кожен окремий символ беру за основу для порівняння.
            //{
            //    foreach (char cha in s3) //іду по всім символам строки.

            //        if (cha != pred && cha == ch) //поточний символ має бути рівним символу-основі і не бути рівним попередньому символу-основі.
            //            kol++; //кількість літер.

            //        if (kol != 0) //якщо не рівно нулю,то виводимо в консоль результат.
            //            Console.WriteLine("Кількість літер  {0} = {1}", ch, kol); //виводжу в консоль символ і його кількість в цій строці.

            //        kol = 0; //обнуляю,для пошуку наступної кількості літер.
            //        pred = ch; //Переходжу на наступну літеру(яку беру за основу для порівнянн) строки.

            //}




        }
    }
}
