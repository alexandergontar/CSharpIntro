using System;
using System.Collections.Generic;

namespace Task3
{
    class Program
    {
        static int GetInputNumber(string promptMessage)
        {
            Console.Write(promptMessage);
            int inputNumber;
            while (!Int32.TryParse(Console.ReadLine(), out inputNumber))
            {
                Console.Beep();
                Console.Write("Неверный ввод, повторите: ");
            }
            return inputNumber;
        }
       /// <summary>
       /// Создает вспомогательный одномерный массив
       /// </summary>
       /// <param name="pages"></param>
       /// <param name="rows"></param>
       /// <param name="columns"></param>
       /// <returns></returns>
        static int[] CreateBufferArray(int pages, int rows, int columns)//Создание вспомогательного одномерного массива -линейная развертка 3-х мерного
        {
            return new int[pages * rows * columns];
        }

        static int[,,] Create3DArray(int pages, int rows, int columns)
        {
            return new int[pages, rows, columns];
        }
        /// <summary>
        /// Заполняет массив случайными неповторяющимися числами
        /// !!Решение учебное, не для production использования!!
        /// </summary>
        /// <param name="array"></param>
        static void FillUniqueRandom(int[] array)
        {
            int size = array.Length;
            int k = 0; 
            int temp ;
            int tryNumber = 0;
            Console.WriteLine("\n\tМассив  " + size + " неповторяющихся случайных чисел\t");
            while (k < size)
            {
                int flag = 0;
                temp = new Random().Next(10, 99);
                for (int i = 0; i <= k; i++)
                {
                    if (array[i] == temp)
                    {
                        tryNumber++;
                        flag++;
                    }
                }
                if (flag == 0)
                {
                    array[k] = temp;
                    Console.Write(" " + array[k]);
                    k++;
                }
            }
            Console.WriteLine("\n\n\tЧисло неудачных попыток заполнения: " + tryNumber);
            
        }
        /// <summary>
        /// Заполнение 3-х мерного массива числами из
        /// одномерного соответствующей длины
        /// </summary>
        /// <param name="d3array"></param>
        /// <param name="array"></param>
        static void Fill3DArray(int[,,] d3array, int[] array)//Заполнение 3-х мерного массива числами из одномерного
        {
            int z = 0;
            int pages = d3array.GetLength(0);
            int rows = d3array.GetLength(1);
            int columns = d3array.GetLength(2);
            for (int i = 0; i < pages; i++)
            {
                for (int j = 0; j < rows; j++)
                {
                    for (int k = 0; k < columns; k++)
                    {
                        d3array[i, j, k] = array[z];
                        z++;
                    }
                }
            }            
        }
        /// <summary>
        ///  Заполняет массив случайными неповторяющимися числами
        ///  при помощи HashSet (предпочтительное решение)
        /// </summary>
        /// <param name="array"></param>
        static void FillUnique(int [] array) 
        {
            int size = array.Length;
            HashSet<int> set = new HashSet<int>();
            while (set.Count < size)
            {
                set.Add(new Random().Next(10, 100));
            }
            int i = 0;
            foreach (int item in set)
            {
                array[i] = item;
                i++;
            }
        }

      

        static void Print3Darray(int[,,] array) 
        {
            for (int i = 0; i < array.GetLength(0); i++)
            {
                Console.WriteLine($"\tPage {i+1} ====\n");
                for (int j = 0; j < array.GetLength(1); j++)
                {
                    for (int k = 0; k < array.GetLength(2); k++)
                    {
                        Console.Write($"\t{array[i, j, k]}({i},{j},{k})\t");
                    }
                    Console.WriteLine("\n");
                }
                Console.WriteLine();                
            }
        }
        static void Main(string[] args)
        {            
            Console.WriteLine("Заполнение 3-х мерного массива неповторяющими случайными числами."); 
            int lines = GetInputNumber("Введите число строк: ");
            int columns = GetInputNumber("Введите число столбцов: ");
            int pages = GetInputNumber("Введите число страниц: "); 
            int[] uniqueRandom = CreateBufferArray(pages, lines, columns);
            int[,,] result3D = Create3DArray(pages, lines, columns);           
           // FillUnique(uniqueRandom); // предпочтительно
            FillUniqueRandom(uniqueRandom); // учебная версия не для production use
            Fill3DArray(result3D, uniqueRandom);
            Print3Darray(result3D);
            Console.ReadKey();
        }
    }
}
