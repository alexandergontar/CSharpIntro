using System;

namespace Task3
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
        /// <summary>
        /// Рекурсивная функция Аккермана
        /// </summary>
        /// <param name="m">параметр m</param>
        /// <param name="n">параметр n</param>
        /// <returns>Значение функции Аккермана</returns>
        static double AkkermanFunction(int m, int n)
        {
            if (m == 0) return n + 1;
            if (n == 0) return AkkermanFunction(m - 1, 1);
            else return AkkermanFunction(m - 1, (int)AkkermanFunction(m, n - 1));
        }
        static void Main(string[] args)
        {
            Console.WriteLine("Введите числ M и N, желательно не больше 3 (например, 2 и 3) для вычисления функции Аккермана.");
            int M = GetInputNumber("M = ");
            int N = GetInputNumber("N = ");
            Console.WriteLine($"\nЗначение функции Аккермана равно: {AkkermanFunction(M,N)}");
            Console.ReadKey();
        }
    }
}
