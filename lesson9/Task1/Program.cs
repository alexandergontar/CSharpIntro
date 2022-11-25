using System;

namespace Task1
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
        /// Выводит выводит числа в убывающем порядке
        /// от N до 1 (N......3 2 1)
        /// </summary3 
        /// <param name="N"></param>
        static void NaturalNumbersReversed(int N) 
        {
            if (N < 1)
            {
                Console.WriteLine("Число должно быть хотя бы не меньше 1");
                Console.ReadKey();
                return;
            }
            if (N == 1)
            {
                Console.WriteLine(1);
                return;
            }
            Console.Write(N+" ");
            NaturalNumbersReversed(N-1);
        }

       
        static void Main(string[] args)
        {
            Console.WriteLine("Вывод чисел от N до 1 (N..... 3 2 1)");
            int N = GetInputNumber("Введите целое число больше 1, N = ");
            NaturalNumbersReversed(N);
            Console.ReadKey();
        }
    }
}
