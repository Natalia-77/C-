﻿using System;
using System.Collections.Generic;
using System.Text;

namespace ConsoleApp1
{
    class Programm
    {

        static void Main(string[] args)
        {
            //Console.WriteLine("ввести строку =");
            //string s = Console.ReadLine();
            //Console.WriteLine("ввести символ =");
            //string str = Console.ReadLine();
            //s = s.Replace(str, str.ToUpper());
            //Console.WriteLine(s);
            //Console.WriteLine("===================");


            //int find = s.LastIndexOf(str,s.Length-1, StringComparison.CurrentCultureIgnoreCase);//шукає індекс входження підстроки в строку.
            //Console.Write(find);//вивела в консоль індекс(просто для перевірки)

            //s = s.Remove(find + 1);
            //Console.WriteLine(s);
            //Console.WriteLine("===================");


            //int count = 0;
            //Console.Write("ввести строку 1 = ");
            //string s1 = Console.ReadLine();
            //Console.Write("ввести строку 2 = ");
            //string s2 = Console.ReadLine();

            //for (int i = 0; i < s1.Length; i++)
            //{
            //    for (int j = 0; j < s2.Length; j++)
            //    {
            //        if (s1[i] == s2[j])
            //        {
            //            s1 = s1.Remove(i, 1);

            //            count++;
            //            break;
            //        }
            //    }
            //}
            //Console.WriteLine("Строка 1: {0}", s1);
            //Console.WriteLine("Строка 2: {0}", s2);
            //Console.WriteLine("Всього видалено {0}", count);
            //Console.WriteLine(s1.Length);



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
