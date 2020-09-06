//using System;
//using System.Collections.Generic;
//using System.Text;

//namespace ConsoleApp1
//{
//    class Mas1
//    {
//        static void Main(string[] args)
//        {
//            Console.OutputEncoding = Encoding.Unicode;
//            Console.InputEncoding = Encoding.Unicode;

//            //Сжать массив, удалив из него все 0 и, заполнить ос-
//            //вободившиеся справа элементы значениями –1


//            int count = 0;
//            int[] array = { 5, 4, 0, 0, 1, 0, 4, 0, 9 };


//            Console.WriteLine("Початковий масив значень : ");
//            //Console.WriteLine();

//            foreach (int el in array)
//            {
//                Console.Write(el + " ");
//            }

//            Console.WriteLine();


//            for (int i = 0; i < array.Length; i++)
//            {
//                if (array[i] == 0)
//                    count++;
//                else
//                    array[i - count] = array[i];
//            }
//            for (int i = array.Length - count; i < array.Length; i++)
//            {
//                array[i] = -1;
//            }


//            foreach (int item in array)
//            {
//                Console.Write(item + " ");
//            }

//            Console.WriteLine();



//            //Преобразовать массив так, чтобы сначала шли все 
//            //отрицательные элементы, а потом положительные
//            //(0 считать положительным)

//            // Перетворений і відсортований масив

//            int kol = 0;
//            int[] array1 = { -5, -10, 0, 2, 1, 14, -2, -1, 5 };
//            int[] temp = new int[array1.Length];
//            Console.WriteLine();
//            Console.WriteLine("Початковий масив значень : ");
           

//            foreach (int el in array1)
//            {
//                Console.Write(el + " ");
//            }

//            //Console.WriteLine();
//            for (int i = 0; i < array1.Length - 1; ++i)
//                for (int j = i + 1; j < array1.Length; ++j)
//                    if (array1[i] > array1[j])
//                    {
//                        temp[i] = array1[i];
//                        array1[i] = array1[j];
//                        array1[j] = temp[i];
//                    }


//            foreach (int el in array1)
//            {
//                Console.Write(el + " ");
//            }
//            Console.WriteLine();

//            //Перетворений і НЕ відсортований масив.

//            int k = 0;
//            int[] array2 = { -5, -4, 0, 21, 12, 4, -2, -1, 5 };
//            int[] array3 = new int[array2.Length];

//            Console.WriteLine();
//            Console.WriteLine("Початковий масив значень :");           

//            foreach (int el in array2)
//            {
//                Console.Write(el + " ");
//            }


//            for (int i = 0; i < array2.Length; i++)
//            {
//                if (array2[i] < 0)
//                {
//                    array3[k] = array2[i];
//                    k++;
//                }

//            }

//            for (int i = 0; i < array2.Length; i++)
//            {
//                if (array2[i] >= 0)
//                {
//                    array3[k] = array2[i];
//                    k++;
//                }
//            }

//            array3.CopyTo(array2, 0);
//            Console.WriteLine();
//            foreach (int el in array2)
//            {
//                Console.Write(el + " ");
//            }
//            Console.WriteLine();


//            //Написать программу, которая предлагает пользова-
//            //телю ввести число и считает, сколько раз это число
//            //встречается в массиве.



//            var rnd = new Random();
//            var array4 = new int[25];
//            for (int i = 0; i < array4.Length; i++)
//            {
//                array4[i] = rnd.Next(0, 11);
//            }
//            int number, kolvo = 0;
//            Console.WriteLine();
//            Console.WriteLine("Рандомно сформований масив:");
//            foreach (int el in array4)
//            {
//                Console.Write(el + " ");
//            }
//            Console.WriteLine();
//            Console.Write("Введіть число від 0 до 10: \n");
//            number = int.Parse(Console.ReadLine());
//            Console.WriteLine();

//            for (int i = 0; i < array4.Length; i++)
//            {
//                if (array4[i] == number)
//                {
//                    kolvo++;
//                }
//            }
//            Console.WriteLine($"Кількість числа {number} в масиві становить {kolvo} \n");
//            Console.WriteLine("========================================================\n");


//            //В двумерном массиве порядка M на N поменяйте 
//            //местами заданные столбцы.

//            int[,] array6 = new int[7, 7];
//            var random = new Random();
//            int col, col2,temp_t,row,row2 = 0;

//            for (int i = 0; i < 7; i++)
//            {
//                for (int j = 0; j < 7; j++)
//                {
//                    array6[i, j] = random.Next(100);
//                    Console.Write("{0,6}", array6[i, j]);
                   
//                }
//                Console.WriteLine();
//            }
//            Console.WriteLine("Введіть номер першої колонки");
//            col = int.Parse(Console.ReadLine());
//            Console.WriteLine("Введіть номер другої колонки");
//            col2 = int.Parse(Console.ReadLine());

//            for (int i = 0; i < 7; i++)
//            {
//                for (int j = 0; j < 7; j++)
//                {
//                    if (j == col - 1)
//                    {
//                        temp_t = array6[i, j];
//                        array6[i, j] = array6[i, col2 - 1];
//                        array6[i, col2 - 1] = temp_t;
//                    }
//                }
//            }

//            for (int i = 0; i < 7; i++)
//            {
//                for (int j = 0; j < 7; j++)
//                {
                   
//                    Console.Write("{0,6}", array6[i, j]);

//                }
//                Console.WriteLine();
//            }

//            Console.WriteLine("Ви можете поміняти місцями і рядочки\n");
//            Console.WriteLine("Введіть номер першого рядочка");
//            row = int.Parse(Console.ReadLine());
//            Console.WriteLine("Введіть номер другого рядочка");
//            row2 = int.Parse(Console.ReadLine());


//            for (int i = 0; i < 7; i++)
//            {
//                for (int j = 0; j < 7; j++)
//                {
//                    if (i == row - 1)
//                    {
//                        temp_t = array6[i, j];
//                        array6[i, j] = array6[row2-1,j];
//                        array6[row2-1,j] = temp_t;
//                    }
//                }
//            }

//            for (int i = 0; i < 7; i++)
//            {
//                for (int j = 0; j < 7; j++)
//                {

//                    Console.Write("{0,6}", array6[i, j]);

//                }
//                Console.WriteLine();
//            }
//        }
//    }
//}



