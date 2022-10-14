using System;

namespace Task2
{
    class Program
    {
        /// <summary>
        /// Находим максимум из 3-х чисел
        /// </summary>
        /// <param name="args"></param>
        static void Main(string[] args)
        {
             // ввод
            Console.Write("Введите число A: ");
            int numA = Convert.ToInt32(Console.ReadLine());
            Console.Write("Введите число B: ");
            int numB = Convert.ToInt32(Console.ReadLine());
            Console.Write("Введите число C: ");
            int numC = Convert.ToInt32(Console.ReadLine());
            // вывод результата
            Console.Write("Максимальное число: ");
            if (numA > numB && numA > numC) 
            { 
                Console.WriteLine(numA);
            }
            else if (numB > numA && numB > numC) 
            { 
                Console.WriteLine(numB);
            }
            else 
            { 
                Console.WriteLine(numC);
            } 
            Console.ReadKey();
        }
    }
}
