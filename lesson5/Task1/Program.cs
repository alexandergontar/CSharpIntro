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



        static int EvenNumbersQuantity(int[] array)
        {
            int EvenNumbersQuantity = 0;
            for (int i = 0; i < array.Length; i++)
            {
                if (array[i] % 2 == 0)
                {
                    EvenNumbersQuantity++;
                }
            }
            return EvenNumbersQuantity;
        }
        static void Main(string[] args)
        {
            Console.WriteLine("Подсчет кол-ва четных чисел в массиве 3-х значных чисел.");
            int size = GetInputNumber("Задайте размер массива: ");
            int [] array = CreateArray(size, 100, 1000);
            DisplayArray<int>(array);
            Console.WriteLine($"Число четных чисел в массиве: " + 
                $"{EvenNumbersQuantity(array)}");
            Console.ReadKey();
        }
    }
}
