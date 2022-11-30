using System;

namespace Task2
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
        /// Считает сумму натуральных чисел от M до N
        /// методом рекурсии
        /// !! M < N !!
        /// </summary>
        /// <param name="M"></param>
        /// <param name="N"></param>
        /// <param name="sum"></param>
        /// <returns></returns>
        static int NaturalNumbersSum(int M, int N, int sum)
        {
            if (M > N)
            {
                Console.WriteLine("M должно быть < N !");
                Console.ReadKey();
                return 0;
            }
            if (M == N)
            {
                Console.Write(N + "   ");
                sum += N;
                Console.Write(sum);
                return sum;
            }
            else
            {
                Console.Write(M + " ");
                return NaturalNumbersSum(M + 1, N, sum + M);
               // return sum;
            }

        }
        static void Main(string[] args)
        {
            Console.WriteLine("Сумма натуральных числе от M до N ( M должно быть <  N)");
            int M = GetInputNumber("M = ");
            int N = GetInputNumber("N = ");
            int sum = NaturalNumbersSum(M, N, 0);
            
            Console.WriteLine($"\nСумма натуральных числе от {M} до {N} равна: {sum}");
            Console.ReadKey();
        }
    }
}
