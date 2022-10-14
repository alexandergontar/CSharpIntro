using System;

namespace Task3
{
    class Program
    {
        /// <summary>
        /// определение четности числа
        /// </summary>
        /// <param name="args"></param>
        static void Main(string[] args)
        {
            Console.Write("Введите число: ");
            int N = Convert.ToInt32(Console.ReadLine());

            if (N % 2 == 0)
            { 
                Console.WriteLine($"Введенное число {N} - четное");
            }
            else 
            {
                Console.WriteLine($"Введенное число {N} - нечетное");
            }
            Console.ReadKey();
        }
    }
}
