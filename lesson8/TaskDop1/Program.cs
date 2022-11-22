using System;

namespace TaskDop1
{
    class Program
    {
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
                Console.WriteLine("\n");
            }
        }
        static void Main(string[] args)
        {
            Console.WriteLine("Строки превращаем в столбцы, не используем дополнительный массив");
            int[,] matrix = CreateMatrix(4,5,0,9);
            PrintMatrix<int>(matrix);
            Console.WriteLine();
            for (int j = 0; j < matrix.GetLength(1); j++)
            {
                for (int i = 0; i < matrix.GetLength(0); i++)
                {
                    Console.Write(matrix[i,j]+"\t");
                }
                Console.WriteLine();
            }
            Console.ReadKey();
        }
    }
}
