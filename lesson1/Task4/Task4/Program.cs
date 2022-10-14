using System;

namespace Task4
{
    class Program
    {
        /// <summary>
        /// определение четности чисел от 1 до N
        /// </summary>
        /// <param name="args"></param>
        static void Main(string[] args)
        {
            Console.Write("Введите число N: ");
            int N = Convert.ToInt32(Console.ReadLine());
            int i = 1; // начинаем счет с 1

            while (i <= N)
            {
                if (i % 2 == 0)
                {
                    Console.WriteLine(i +" - четное");
                }
                else
                {
                    Console.WriteLine(i + " - нечетное");
                }
                i++;
            }
            Console.ReadKey();
        }
    }
}
