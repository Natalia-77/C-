//using System;
//using System.Collections.Generic;
//using System.Text;

//namespace ConsoleApp1
//{
//    class Mas1
//    {
//        static void Main(string[] args)
//        {
//            int count = 0;
//            int[] array1 = { 5, 4, 0, 0, 1, 0, 4, 0, 9 };
//            int[] array2 = new int[array1.Length];

//            Console.WriteLine("Початковий масив значень : ");
//            Console.WriteLine();
           
//            foreach (int el in array1)
//            {
//                Console.Write(el+" ");
//            }

//            Console.WriteLine();

//            for (int i = 0; i < array1.Length; i++)
//            {
//                if (array1[i] != 0)
//                {
//                    array2[count] = array1[i];
//                    count++;
//                }
//            }
//            for (int i = count; i < array1.Length; i++)
//            {
//                array2[i] = -1;
//            }
                    

//            Console.WriteLine();
//            Console.WriteLine("Новий масив значень : ");
//            Console.WriteLine();
          

//            foreach (int item in array2)
//            {
//                Console.Write(item + " ");
//            }

//            Console.WriteLine();

//            Console.ReadLine();
//        }
//    }
//}



