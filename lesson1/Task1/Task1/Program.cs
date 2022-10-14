using System;

namespace Task1
{
    class Program
    {
        /// <summary>
        /// Сравниваем 2 числа        /// 
        /// </summary>
        /// <param name="args"></param>
        static void Main(string[] args)
        {
            Console.Write("Введите число a: ");
            int numA = Convert.ToInt32(Console.ReadLine());
            Console.Write("Введите число b: ");
            int numB = Convert.ToInt32(Console.ReadLine());

            if (numA > numB)
            {
                Console.WriteLine("Максимальное число max = " + numA);
                Console.WriteLine("Минимальное число min = " + numB);
            }
            else
            {
                Console.WriteLine("Максимальное число max = " + numB);
                Console.WriteLine("Минимальное число min = " + numA);
            }
            Console.ReadKey();
        }
    }
}
