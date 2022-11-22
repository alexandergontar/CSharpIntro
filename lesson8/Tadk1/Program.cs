using System;

namespace Tadk1
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
        /// Находит максимум, минимум массива и их разность
        /// </summary>
        /// <param name="array"></param>
        /// <returns></returns>
        static (int min, int max, int diff) MinMax(int[] array)
        {
            int min = array[0];
            int max = array[0];
            for (int i = 1; i < array.Length; i++)
            {
                if (array[i] < min)
                {
                    min = array[i];
                }
                if (array[i] > max)
                {
                    max = array[i];
                }
            }
            int diff = max - min;
            return (min, max, diff);
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
                        Console.Write("{0: 0.00} ", matrix[i, j]);
                    }
                    else Console.Write($"{matrix[i, j]} ");
                }
                Console.WriteLine();
            }
        }

        /// <summary>
        /// Находит индекс элемента по его значению
        /// </summary>
        /// <param name="array"></param>
        /// <param name="findValue"></param>
        /// <returns></returns>
        static int FindElementIndex(int[] array, int findValue) 
        {
            int position = 0;
            for (int i = 0; i < array.Length; i++)
            {
                if (array[i] == findValue)
                {                    
                    position = i;
                    break;
                }
            }
            return position;
        }       
        /// <summary>
        /// Создает массив сумм элементов
        /// строк матрицы
        /// </summary>
        /// <param name="matrix"></param>
        /// <returns></returns>
        static int[] LinesSums(int[,] matrix) 
        {
            int[] sums = new int[matrix.GetLength(0)];
            for (int i = 0; i < matrix.GetLength(0); i++)
            {
                int sum = 0;
                for (int j = 0; j < matrix.GetLength(1); j++)
                {
                    sum += matrix[i, j];
                }                
                sums[i] = sum;
            }
            return sums;
        }
        static void Main(string[] args)
        {
            Console.WriteLine("Зададим матрицу целых числел размером: M х N");
            int M = GetInputNumber("M = ");
            int N = GetInputNumber("N = ");
            int lowerBound = GetInputNumber("Введите нижнюю границу значений: ");
            int upperBound = GetInputNumber("Введите верхнюю границу значений: ");
            int[,] matrix = CreateMatrix(M, N, lowerBound, upperBound);
            PrintMatrix<int>(matrix);                        
            int[] sums = LinesSums(matrix);            
            (int min, int max, int diff) = MinMax(sums);
            int index = FindElementIndex(sums, min);
            Console.WriteLine($"Номер строки с наименьшей суммой элементов = {index + 1}, сумма  = {min}");
            
            Console.ReadKey();
        }
    }
}
