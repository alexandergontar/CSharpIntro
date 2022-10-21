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

        static void DisplayAscendingCubicNumbers(int N) 
        {            
            int i = 1;
            while (i <= N)
            {
                Console.WriteLine($"| {i} |\t| {i * i * i} |");
                i++;
            }
        }
        static void Main(string[] args)
        {
            Console.Write("Введите число N > 1: ");
            int N = GetInputNumber();
            DisplayAscendingCubicNumbers(N); 
            Console.ReadKey();
        }
    }
}
