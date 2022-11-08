using System;

namespace Task1
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
        /// <summary>
        /// умножаем 1 на число N-раз
        /// number ^ power = (1 * number * number ....) - power раз
        /// </summary>
        /// <param name="number"></param>
        /// <param name="power"></param>
        /// <returns>(1 * number * number ....) - power раз</returns>
        static int GetPower(int number, int power) 
        {
            int product = 1;
            for (int i = 0; i < power; i++)
            {
                product *= number;
            }            
            return product;
        }
        /// <summary>
        /// возведение в степень циклом
        /// </summary>
        /// <param name="args"></param>
        static void Main(string[] args)
        {
            int number, power;
            Console.Write("Введите число: ");
            number = GetInputNumber();           
            Console.Write("Введите степень: ");
            power = GetInputNumber();

            int result = GetPower(number, power);

            Console.WriteLine($" {number} ^ {power} = {result} ");
            Console.ReadKey();
        }
    }
}
