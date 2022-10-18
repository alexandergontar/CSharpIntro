using System;

namespace Task1
{
    class Program
    {

        /// <summary>
        /// ввод с клавиатуры числа, с защитой от неверного ввода
        /// </summary>
        /// <returns>введеное целое число</returns>
        static int GetInputNumber()
        {    
            int inputNumber;
            Int32.TryParse(Console.ReadLine(), out inputNumber);
            return inputNumber;
        }
        /// <summary>
        /// Определение второй цифры 3-х значного числа
        /// </summary>
        /// <param name="args"></param>
        static void Main(string[] args)
        {               
            Console.Write("Введите число от 100 по 999 :   ");//Обработка ввода 
            while (true)
            {
                int inputNumber = GetInputNumber();

                if (inputNumber >= 100 && inputNumber <= 999)//Проверка вводимого
                {
                    int secondDigit = (inputNumber % 100 - inputNumber % 10) / 10;
                    Console.WriteLine($"Вторая цифра введенного числа : {secondDigit} "); ;
                    break;
                }
                Console.Beep();//Звуковой сигнал при неправильном вводе
                Console.WriteLine("Неверный ввод.");
            }
            Console.ReadKey();
        }
    }
}
