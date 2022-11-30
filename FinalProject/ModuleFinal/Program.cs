using System;

namespace ModuleFinal
{
    class Program
    {
        /// <summary>
        /// Заполняет массив строк случайными строками
        /// </summary>
        /// <param name="array"></param>
        /// <param name="minWordLength"></param>
        /// <param name="maxWordLength"></param>
        /// <returns>массив строк</returns>
        static string[] FillWordsArray(string[] array, int minWordLength, int maxWordLength)
        {
            int wordsNumer = array.Length;
            for (int i = 0; i < wordsNumer; i++)
            {
                int wordLength = new Random().Next(minWordLength, maxWordLength + 1);
                array[i] = String.Empty;
                for (int j = 0; j < wordLength; j++)
                {
                    int temp = new Random().Next(48, 90);
                    array[i] = string.Concat(array[i] + Convert.ToChar(temp));
                }
            }
            return array;
        }
        /// <summary>
        /// Выводит элементы массива
        /// </summary>
        /// <typeparam name="T">тип элементов</typeparam>
        /// <param name="array">масссив</param>
        static void DisplayArray<T>(T[] array)
        {
            Console.Write("[");
            for (int i = 0; i < array.Length; i++)
            {
                if (i < array.Length - 1) Console.Write($"{array[i]}\t");
                else Console.Write($"{array[i].ToString()}\t");
            }
            Console.Write("]\n");
        }
        /// <summary>
        /// Определение количества строк длиною не больше upperBound символов
        /// </summary>
        /// <param name="array">массив строк</param>
        /// <param name="upperBound">ограничение по длине строки</param>
        /// <returns>число строк в массиве не длиннее заданной длины</returns>
        static int CountTruncated(string[] array, int upperBound)
        {
            int size = array.Length;
            int count = 0;
            for (int i = 0; i < size; i++)
            {
                if (array[i].Length <= upperBound) count++;
            }
            return count;
        }
        /// <summary>
        /// Заполнение массива строками длиной от 1 по 3 символа
        /// </summary>
        /// <param name="arrayIn"></param>
        /// <param name="arrayOut"></param>
        /// <param name="upperBound"></param>
        /// <returns></returns>
        static void FillModifWordsArray(string[] arrayIn, string[] arrayOut, int upperBound)//Заполнение массива строками длиной от 1 по 3 символа
        {
            int j = 0;
            int size = arrayIn.Length;
            for (int i = 0; i < size; i++)
            {
                if (arrayIn[i].Length <= upperBound)
                {
                    arrayOut[j] = arrayIn[i];
                    j++;
                }
            }
            //return arrayOut;
        }
        static void Main(string[] args)
        {
            Console.WriteLine("Создание массива строк случайных символов.");
            string[] inputArray = new string[15];
            FillWordsArray(inputArray, 1, 7);
            Console.WriteLine("Исходный массив:");
            DisplayArray<string>(inputArray);
            int outputArrayLength = CountTruncated(inputArray, 3);
            string[] outputArray = new string[outputArrayLength];
            FillModifWordsArray(inputArray, outputArray, 3);
            Console.WriteLine($"\nВыходной массив из строк не длиннее 3-х символов:");
            DisplayArray<string>(outputArray);
            Console.ReadKey();
        }
    }
}
