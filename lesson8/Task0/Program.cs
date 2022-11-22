using System;

namespace Task0
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
        /// Пузырьковая сортировка
        /// </summary>
        /// <param name="array">Входной массив</param>
        static void BubbleSort(int[] array) 
        {
            int temp;
            int s = -1; // -1 = убывающая сортировка, 1 - возрастающая
            for (int j = 0; j < array.Length; j++) // простейшая пузырьковая сортировка
                for (int i = 0; i < array.Length - 1; i++)
                {

                    if (array[i] * s > array[i + 1] * s)
                    {
                        temp = array[i];
                        array[i] = array[i + 1];
                        array[i + 1] = temp;
                    }
                }
        }
        
        /// <summary>
        /// Сортировка строк матрицы по убыванию
        /// </summary>
        /// <param name="matrix"></param>
        static void SortRowsDescend(int [,] matrix) 
        {
            for (int i = 0; i < matrix.GetLength(0); i++)
            {
                int[] buffer = new int[matrix.GetLength(1)];
                for (int j = 0; j < matrix.GetLength(1); j++)
                {
                    buffer[j] = matrix[i, j];
                }
                //Array.Sort(buffer); // встроенная .NET сортировка
               // Array.Reverse(buffer);
                BubbleSort(buffer); // пузырьковая сортировка
                for (int j = 0; j < matrix.GetLength(1); j++)
                {
                    matrix[i, j] = buffer[j];
                }
            }
        }
        static int[,] CreateMatrix(int n, int m, int lowerBound, int upperBound)
        {
            int[,] matrix = new int[n, m];
            for (int i = 0; i < matrix.GetLength(0); i++)
            {
                for (int j = 0; j < matrix.GetLength(1); j++)
                {
                    matrix[i, j] = new Random().Next(lowerBound, upperBound + 1);
                }
            }
            return matrix;
        }
        static void PrintMatrix<T>(T[,] matrix)
        {
            for (int i = 0; i < matrix.GetLength(0); i++)
            {
                for (int j = 0; j < matrix.GetLength(1); j++)
                {
                    if (typeof(T) == typeof(double))
                    {
                        Console.Write("{0: 0.00}\t", matrix[i, j]);
                    }
                    else Console.Write($"{matrix[i, j]}\t");
                }
                Console.WriteLine();
            }
        }
            static void Main(string[] args)
        {
            Console.WriteLine("Введите размерность матрицы М х N, а также минимум и максимум значений элементов.\n");
            int M = GetInputNumber("M = ");
            int N = GetInputNumber("N = ");
            int min= GetInputNumber("Min = ");
            int max = GetInputNumber("Max = ");
            int[,] matrix = CreateMatrix(M, N, min, max);
            Console.WriteLine("\nЗаданная матрица: \n");
            PrintMatrix<int>(matrix);
            SortRowsDescend(matrix);
            Console.WriteLine("\nСортировка строк по убыванию: \n");
            PrintMatrix<int>(matrix);
            Console.ReadKey();
        }
    }
}
