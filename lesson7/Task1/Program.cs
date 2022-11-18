using System;

namespace Task1
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
        /// печатает матрицу элементов,
        /// если тип double, выводит 2 цифры после запятой
        /// </summary>
        /// <typeparam name="T"></typeparam>
        /// <param name="matrix"></param>
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
        /// создает матрицу вещественных чисел
        /// </summary>
        /// <param name="n"></param>
        /// <param name="m"></param>
        /// <param name="lowerBound"></param>
        /// <param name="upperBound"></param>
        /// <returns></returns>
        static double [,] CreateMatrixDouble(int n, int m, double lowerBound, double upperBound) 
        {
            double[,] matrix = new double[n, m];
            for (int i = 0; i < matrix.GetLength(0); i++)
            {
                for (int j = 0; j < matrix.GetLength(1); j++)
                {
                    matrix[i, j] = new Random().NextDouble() * (upperBound - lowerBound) + lowerBound;
                }                
            }
            return matrix;
        }
      

        static void Main(string[] args)
        {
            Console.WriteLine("Введите размер матрицы N x M, а также нижнюю и верхнюю границы значений.");
            int n = GetInputNumber("N = ");
            int m = GetInputNumber("M = ");
            double lowerBound = (double)GetInputNumber("Нижняя граница = ");
            double upperBound = (double)GetInputNumber("Верхняя граница = ");
            double [,] matrix = CreateMatrixDouble(n, m, lowerBound, upperBound);
            PrintMatrix<double>(matrix);
            
            Console.ReadKey();
        }
    }
}
