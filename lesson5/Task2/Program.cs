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

        static int[] CreateArray(int size, int minValue, int maxValue)
        {
            int[] array = new int[size];
            for (int i = 0; i < array.Length; i++)
            {
                array[i] = new Random().Next(minValue, maxValue + 1);
            }
            return array;
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

        /// <summary>
        /// Подсчитывает сумму элементов с
        /// нечетным индексом
        /// </summary>
        /// <param name="array"></param>
        /// <returns></returns>
        static int OddPositionSum(int[] array)
        {
            int sum = 0;
            for (int i = 0; i < array.Length; i++)
            {
                if (i % 2 != 0)
                {
                    sum += array[i];
                }
            }
            return sum;
        }
        static void Main(string[] args)
        {
            int size = GetInputNumber("Введите размер массива: ");
            int lowerBound = GetInputNumber("Введите нижнюю границу значений: ");
            int upperBound = GetInputNumber("Введите верхнюю границу значений: ");
            int [] array = CreateArray(size, lowerBound, upperBound);
            DisplayArray<int>(array);
            Console.WriteLine($"Сумма элементов на нечетных позициях равна:" +
                $" {OddPositionSum(array)}");
            Console.ReadKey();
        }
    }
}
