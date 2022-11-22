using System;

namespace Task4
{
    class Program
    {
        /// <summary>
        /// Определяет число концентрических контуров для заполнения
        /// матрицы
        /// </summary>
        /// <param name="size">размерность квадратной матрицы</param>
        /// <returns>Число контуров заполнения</returns>
        static int ConcentricRounds(int size)//определение необходимого количества проходов для заполнения массива
        {
            int maxTemp = size;
            int roundsNumber;
            roundsNumber = maxTemp / 2;
            if (maxTemp % 2 != 0)
            {
                roundsNumber++;
            }
            return roundsNumber;
        }

        /// <summary>
        /// Заполняет матрицу возрастающими
        /// числами по спирали
        /// </summary>
        /// <param name="matrix"></param>
        /// <param name="roundNumber"></param>
        /// <returns></returns>
        static int[,] SpiralFill(int[,] matrix, int roundNumber)//Заполнение искомого массива заданным способом
        {
            int startNumber = 1;
            int roundCount = 0;
            int size = matrix.GetLength(0);
            while (roundCount < roundNumber)
            {
                for (int j = 0 + roundCount; j < size - roundCount; j++)
                {
                    matrix[0 + roundCount, j] = startNumber;
                    startNumber++;
                }
                for (int i = 1 + roundCount; i < (size - 1 - roundCount); i++)
                {
                    matrix[i, size - roundCount - 1] = startNumber;
                    startNumber++;
                }
                for (int j = size - roundCount - 1; j >=  roundCount; j--)
                {
                    matrix[size - 1 - roundCount, j] = startNumber;
                    startNumber++;
                }
                for (int i = size - 2 - roundCount; i > roundCount; i--)
                {
                    matrix[i, roundCount] = startNumber;
                    startNumber++;
                }
                roundCount++;
            }
            if (size % 2 != 0)
            {
                matrix[(size / 2), (size / 2)] = startNumber - 2;
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
            Console.WriteLine("Пример \" спирального\" заполнения квадратной матрицы 4х4.");
            int size = 4;
            int[,] matrix = new int[size, size];
            int rounds = ConcentricRounds(size);
            SpiralFill(matrix, rounds);
            PrintMatrix<int>(matrix);
            Console.ReadKey();
        }
    }
}
