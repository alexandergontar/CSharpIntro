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
        /// <summary>
        /// Выводит двумерный массив,
        /// если тип double выводит
        /// 2 знака после запятой
        /// </summary>
        /// <typeparam name="T">тип элементов</typeparam>
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
        /// Выводит значение элемента матрицы по
        /// номерам строки и столбца
        /// </summary>
        /// <param name="matrix"></param>
        /// <param name="lineNumber"></param>
        /// <param name="columnNumber"></param>
        static void PrintMatrixElement<T>(T [,] matrix, int lineNumber, int columnNumber) 
        {
            if (lineNumber < 1 ||
             lineNumber > matrix.GetLength(0) ||
             columnNumber < 1 ||
             columnNumber > matrix.GetLength(1))
            {
                Console.WriteLine("Указанная позиция отсутствует.");
            }
            else
            {
                Console.WriteLine($"Элемент существует, значение =" +
                    $" {matrix[lineNumber - 1, columnNumber - 1]}");
            }
        }

        static void Main(string[] args)
        {
            Console.WriteLine("Вывод элемента матрицы по номерам строки и столбща.");
            Console.WriteLine("Введите размеры матрицы M x N а также верхнюю и нижнюю границы значений");
            int M = GetInputNumber("M = ");
            int N = GetInputNumber("N = ");
            int lowerBound = GetInputNumber("Нижняя граница = ");
            int upperBound = GetInputNumber("Верхняя граница = ");
            int[,] matrix = CreateMatrix(M, N, lowerBound, upperBound);            
            PrintMatrix<int>(matrix);      
            int lineNumber = GetInputNumber("Введите номер строки: ");
            int columnNumber = GetInputNumber("Введите номер столбца: ");
            PrintMatrixElement<int>(matrix, lineNumber, columnNumber);
         
            Console.ReadKey();
        }
    }
}
