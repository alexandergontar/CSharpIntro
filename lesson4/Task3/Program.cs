using System;

namespace Task3
{
    class Program
    {
        static int GetInputNumber()
        {
            int inputNumber;
            while (!Int32.TryParse(Console.ReadLine(), out inputNumber))
            {
                Console.Beep();
                Console.Write("Неверный ввод, повторите: ");
            }
            return inputNumber;
        }
        /// <summary>
        /// Создает массив целых чисел
        /// </summary>
        /// <param name="size">длина</param>
        /// <param name="minValue">наименьшее значение элемента</param>
        /// <param name="maxValue">наибольшее значение элеента</param>
        /// <returns>массив целых чисел</returns>
        static int[] CreateArray(int size, int minValue, int maxValue) 
        {
            int[] array = new int[size];
            for (int i = 0; i < array.Length; i++)
            {
                array[i] = new Random().Next(minValue, maxValue + 1);
            }
            return array;
        }

        /// <summary>
        /// выводит массив
        /// </summary>
        /// <typeparam name="T">тип элемнтов массива</typeparam>
        /// <param name="array">массив</param>
        static void DisplayArray<T>(T [] array) 
        {
            Console.Write("[");
            for (int i = 0; i < array.Length; i++)
            {
                if(i < array.Length -1) Console.Write($"{array[i]}, ");
                 else Console.Write($"{array[i].ToString()}");
            }
            Console.Write("]");
        }
        static void Main(string[] args)
        {
            Console.Write("Введите размер создаваемого массива: ");
            int size = GetInputNumber();
            Console.Write("Введите минимальное значение элементов массива: ");
            int minValue = GetInputNumber();
            Console.Write("Введите максимальное значение элементов массива: ");
            int maxValue = GetInputNumber();
            
            int[] array = CreateArray(size, minValue, maxValue);
            DisplayArray<int>(array);
            Console.ReadKey();
        }
    }
}
