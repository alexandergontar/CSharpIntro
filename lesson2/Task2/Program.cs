using System;

namespace Task2
{
    class Program
    {
        /// <summary>
        /// определени 3-й цифры числа
        /// </summary>
        /// <param name="args"></param>
        static void Main(string[] args)
        {
          
            Console.Write("Введите Ваше число: ");

            int inputNumber;
            while (!int.TryParse(Console.ReadLine(), out inputNumber))//Проверка, что введено целое число
            {
                Console.Beep();//Звуковой сигнал при неправильном вводе
                Console.Write("Неправильный ввод \n" + "Введите число: ");
            }

            int firstThreeDigits = inputNumber;
            while (firstThreeDigits / 1000 != 0) // определение числа из первых трех чисел, если есть
            {
                firstThreeDigits = firstThreeDigits / 10;
            }

            if (inputNumber / 100 != 0) // контроль, что число трехзначное
            {
                Console.WriteLine("Третья цифра введенного числа " + inputNumber + " равна :  " + firstThreeDigits % 10);
            }
            else
            {
                Console.WriteLine("Третьeй цифры в введенном числе " + inputNumber + "  нет ");
            }
            Console.ReadKey();
        }
    }
}
