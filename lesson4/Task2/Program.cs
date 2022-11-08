using System;

namespace Task2
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

        static int SumOfDigits(int number) 
        {
            int sum = 0;
            if (number < 0) number = -number;
            while (number > 0) // пока в числе остаются цифры
            {
                sum = sum + number % 10; //приплюсовываем последнюю цифру числа
                number = number / 10; // убираем последнюю цифру
            }          
            return sum;
        }
        /// <summary>
        /// вычисляем сумму цифр в числе
        /// </summary>
        /// <param name="args"></param>
        static void Main(string[] args)
        {
            Console.Write(" Введите число: ");
            int number = GetInputNumber();

            Console.WriteLine($" Сумма цифр в числе: {SumOfDigits(number)}");
            Console.ReadKey();
        }
    }
}
