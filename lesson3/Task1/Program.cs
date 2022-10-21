using System;

namespace Task1
{
    class Program
    {
        /// <summary>
        /// ввод с клавиатуры целого +/- числа
        /// </summary>
        /// <returns></returns>
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
        /// проверка является ли целое как положительное, так 
        /// и отицательное число полиндромом
        /// </summary>
        /// <param name="inputNumber"></param>
        /// <returns></returns>
        static bool IsPalindrom(int inputNumber) 
        {
            int  rest, reversedNumber = 0, temp;
            temp = inputNumber; // запоминаем исходное число
            while (inputNumber != 0) // вычисляем "обратно развернутое" reversedNumber
            {
                rest = inputNumber % 10; 
                reversedNumber = reversedNumber * 10 + rest;
                inputNumber = inputNumber / 10;
            }
            if (temp == reversedNumber) // сравниваем с исходным
            {               
                return true;
            }
            else
            {        
                return false;
            }
            
        }

        /// <summary>
        /// проверка разрядности
        /// </summary>
        /// <param name="inputNumber"></param>
        /// <returns></returns>
        static bool IsNDigitLong(int inputNumber, int length) 
        {
            int count = 0;
            while (inputNumber > 0)
            {
                inputNumber /= 10;
                count++;
            }
            if (count == length)
            {
                return true;
            }
            else 
            { 
                return false;
            }
            
        }

        static void Main(string[] args)
        {          

            Console.Write("\n\n");
            Console.Write("Проверка, является ли число палиндромом:\n");
            Console.Write("------------------------------------------------");
            Console.Write("\n\n");

            Console.Write("Введите число: ");           
            int inputNumber = GetInputNumber();
            if (!IsNDigitLong(inputNumber, 5))
            {
                Console.WriteLine(@" Вы ввели не 5-значное число,
                это противоречит условию задачи, попробуйте еще раз.");
                Console.ReadKey();
                return;
            }
            
            if (IsPalindrom(inputNumber))
            {
                Console.Write("{0} -> палиндром.\n", inputNumber);
            }
            else 
            {
                Console.Write("{0} -> не палиндром.\n", inputNumber);
            }           
            Console.ReadKey();
        }
    }
}
