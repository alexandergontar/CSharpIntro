using System;
using System.Text;
using System.Linq;

namespace Task1
{
    class Program
    {
        /// <summary>
        /// подсчет числел > 0 рекурсией
        /// </summary>
        /// <param name="array">входной массив</param>
        /// <param name="index">индексатор</param>
        /// <param name="countPos">счетчик положительных чисел</param>
        /// <returns>countPos</returns>
        static int CountPositivRecursive(int[] array, int index, int countPos)//метод определяет количество чисел больше 0.
        {
            if (index < 0) return countPos; //условие заверешния рекурсии
            else if (array[index] <= 0) return CountPositivRecursive(array, index - 1, countPos);
            else return CountPositivRecursive(array, index - 1, countPos + 1);
        }
        /// <summary>
        /// простой счетчик положительных чисел
        /// </summary>
        /// <param name="array"></param>
        /// <returns>countPositive</returns>
        static int CountPositive(int [] array) 
        {
            int countPositive = 0;
            for (int i = 0; i < array.Length; i++)
            {
                if (array[i] > 0)
                {
                    countPositive++;
                }
            }
            return countPositive;
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
        /// получает числосой массив из строки числовых символов,
        /// разделенных пробелами или запятыми и пробелами, пустые
        /// строки удаляются
        /// </summary>
        /// <param name="message"></param>
        /// <returns>числовой массив</returns>
        static int[] InputArray(string message)
        {
            int[] numbers;
            int pars;
            Console.WriteLine(message);
            // возвращает строковый массив без пустых строк
            numbers = Console.ReadLine().Split(new[] {' ', ','}, StringSplitOptions.RemoveEmptyEntries)
                // Linq-запрос и лямда выражение преобразуют числовые символы в числа, в неуспешном случае подставляют нули
                .Select(e => int.TryParse(e, out pars) ? pars : 0).ToArray(); // и преобразуют в массив
            return numbers;
        }


        static void Main(string[] args)
        {
            int[] numbers = InputArray("Введите числа через пробелы или запятые: ");
            DisplayArray<int>(numbers);
            Console.WriteLine("Подсчет положительных чисел метеодом рекурсии : " + CountPositivRecursive(numbers, numbers.Length - 1, 0) + "\n  ");
            Console.WriteLine("Подсчет положительных чисел : " + CountPositive(numbers));
            Console.ReadKey();

        }
    }
}
