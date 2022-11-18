using System;

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
        /// считает  и выводит среднее арифметическое
        /// для каждой колонки элементов матрицы
        /// </summary>
        /// <param name="matrix"></param>
        static void DispColumnsAvg(int [,] matrix) 
        {
            for (int j = 0; j < matrix.GetLength(1); j++)
            {
                Console.Write($"{j + 1}/  ");
                int sum = 0;
                for (int i = 0; i < matrix.GetLength(0); i++)
                {
                    Console.Write(matrix[i, j] + " ");
                    sum += matrix[i, j];
                }
                double avg = (double)sum / matrix.GetLength(0);
                Console.WriteLine(" - Ср. арифм = {0:  0.00}", avg);
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

        static void Main(string[] args)
        {
            Console.WriteLine("Вычисление средних арифметический значений колонок числовой матрицы.");
            Console.WriteLine("Введите размер матрицы N x M, а также нижнюю и верхнюю границы значений.");
            int n = GetInputNumber("N = ");
            int m = GetInputNumber("M = ");
            int lowerBound = GetInputNumber("Нижняя граница = ");
            int upperBound = GetInputNumber("Верхняя граница = ");            
            int[,] matrix = CreateMatrix(n, m, lowerBound, upperBound);
            Console.WriteLine("Исходная матрица:");
            PrintMatrix<int>(matrix);
            Console.WriteLine("Средние арифметические по колонкам");
            DispColumnsAvg(matrix);
      
            Console.ReadKey();
        }
    }
}
