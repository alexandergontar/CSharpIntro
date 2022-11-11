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

        /// <summary>
        /// Создает массив случайных вещественных чисел
        /// </summary>
        /// <param name="size">размер</param>
        /// <param name="lowerBound">нижнияя граница значений</param>
        /// <param name="upperBound">верхняя граница значений</param>
        /// <returns>массив "double"</returns>
        static double[] CreateDoubleArray(int size, double lowerBound, double upperBound)
        {
            double[] array = new double[size];

            for (int i = 0; i < array.Length; i++)            {
              
                array[i] = new Random().NextDouble(); //встроенный генератор 0...1
                array[i] = array[i] * (upperBound - lowerBound) + lowerBound; // приведение к заданному интервалу
            }
            return array;
        }
        /// <summary>
        /// вычисляет минимальное значение, максимальное и разность
        /// </summary>
        /// <param name="array"></param>
        /// <returns>разность</returns>
        static (double min, double max, double diff) MinMaxDouble(double[] array)
        {
            double min = array[0];
            double max = array[0];
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

            double diff = max - min;

            return (min, max, diff);
        }
        static void DisplayArray<T>(T[] array)
        {
            Console.Write("[");
            for (int i = 0; i < array.Length; i++)
            {
                if (i < array.Length - 1) Console.Write($"{array[i]}, ");
                else Console.Write($"{array[i].ToString()}");
            }
            Console.Write("]\n");
        }
        static void Main(string[] args)
        {
            Console.WriteLine("=== Определение разности между минимумом и максимумом массива вещественных чисел ===\n");
            int size = GetInputNumber("Введите размер массива: ");
            double lowerBound = (double)GetInputNumber("Нижняя граница (целое число): ");
            double upperBound = (double)GetInputNumber("Верхняя граница (целое число): ");
            double [] array = CreateDoubleArray(size, lowerBound, upperBound);
            DisplayArray<double>(array);
            Console.WriteLine("\n Отчет:");
            (double min, double max, double diff) = MinMaxDouble(array);
            Console.Write(" Минимум = {0: 0.00}, Максимум = {1: 0.00}, Разность = {2: 0.00}", min, max, diff);

            Console.ReadKey();
        }
    }
}
