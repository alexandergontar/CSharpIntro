using System;

namespace Task2
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
                        Console.Write("{0: 0.00}\t", matrix[i, j]);
                    }
                    else Console.Write($"{matrix[i, j]}\t");
                }
                Console.WriteLine("\n");
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

        /// <summary>
        /// Умножние матриц
        /// </summary>
        /// <param name="matrixA">матрица А</param>
        /// <param name="matrixB">матрица В</param>
        /// <returns>С = А х В</returns>
        static int[,] MultiplyMatrix(int[,] matrixA, int[,] matrixB)//Перемножение матриц
        {
            int linesNumberA = matrixA.GetLength(0);
            int columnsNumberA = matrixA.GetLength(1);
            int columnsNumberB = matrixB.GetLength(1);
            int[,] matrixC = new int[linesNumberA, columnsNumberB];
            for (int i = 0; i < linesNumberA; i++)
            {
                for (int j = 0; j < columnsNumberB; j++)
                {
                    matrixC[i, j] = 0;
                    for (int k = 0; k < columnsNumberA; k++)
                    {
                        matrixC[i, j] += matrixA[i, k] * matrixB[k, j];
                    }
                }
            }
            return matrixC;
        }

        static void Warning() 
        {
            Console.WriteLine("\n\tОперация умножения двух" +
                " матриц выполнима только в том случае, если \n\t" +
                "число столбцов в первом сомножителе равно числу строк во втором;\n\t" +
                " в этом случае говорят, что матрицы согласованы.");
        }

        static void Main(string[] args)
        {
            Console.WriteLine("\t===============Умножение двух матриц=============");
            Warning();
            int l = GetInputNumber("Введите число строк матрицы А = ");
            int m = GetInputNumber("Введите число столбцов матрицы А = ");
            int n = GetInputNumber("Введите число столбцов матрицы В = ");
            int[,] matrixA = CreateMatrix(l, m, 0, 9);
            int[,] matrixB = CreateMatrix(m, n, 0, 9);            
            int[,] matrixC = MultiplyMatrix(matrixA, matrixB);
            Console.WriteLine("Матрица А:");
            PrintMatrix<int>(matrixA);
            Console.WriteLine("Матрица В:");
            PrintMatrix<int>(matrixB);
            Console.WriteLine("Матрица С = А х В:");
            PrintMatrix<int>(matrixC);
            Console.ReadKey();
        }
    }
}
