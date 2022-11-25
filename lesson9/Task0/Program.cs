using System;
using System.Text;
namespace Task0
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
                int wordLength = new Random().Next(minWordLength, maxWordLength);
                array[i] = String.Empty;
                for (int j = 0; j < wordLength; j++)
                {
                    int temp = new Random().Next(48, 90);
                    array[i] = string.Concat(array[i] + Convert.ToChar(temp));
                }
            }
            return array;
        }
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
        /// убирает из последовательности символов
        /// числовые символы
        /// </summary>
        /// <param name="word"></param>
        /// <returns></returns>
        static string StripDigits(string word) 
        {
            for (int i = 0; i < word.Length; i++)
            {               
                char c = word[i];
                int n = (int)c;                
                if (n >= 48 && n <= 57) // 48 - 57 диапазон кодов числовых символов               
                    word = word.Replace(word[i], ' ');                
            }
            return word.Replace(" ", String.Empty);           
        }
        static void Main(string[] args)
        {
            Console.WriteLine("Создание массива строк случайный символов и удаление числовых символов");             
            string[] words = new string[7];
            FillWordsArray(words, 10, 15);
            Console.WriteLine("Исходный массив:");
            DisplayArray<string>(words);
            for (int i = 0; i < words.Length; i++)
            {
                words[i] = StripDigits(words[i]);
            }
            Console.WriteLine("Без числовых символов:");
            DisplayArray<string>(words);
            Console.ReadKey();
        }
    }
}
