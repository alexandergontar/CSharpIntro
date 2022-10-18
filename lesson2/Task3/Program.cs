using System;

namespace Task3
{
    class Program
    {
        static int GetInputNumber()
        {  
            int inputNumber;
            Int32.TryParse(Console.ReadLine(), out inputNumber);
            return inputNumber;
        }

        static void Main(string[] args)
        {
            while (true)
            {
                Console.Write("Введите число от 1 по 7 :   ");//Обработка вводимого     
                int weekDayNumber = GetInputNumber();

                if (weekDayNumber >= 1 && weekDayNumber <= 7)//Проверка вводимого
                {
                    if (weekDayNumber == 6 || weekDayNumber == 7)
                    {
                        Console.WriteLine(weekDayNumber + "     Сегодня выходной  ");
                    }
                    else
                    {
                        Console.WriteLine(weekDayNumber + "     Сегодня будний день   ");
                    }
                    break;
                }
                Console.Beep();//Звуковой сигнал при неверном вводе
                Console.WriteLine("Неверный ввод.");
            }
            Console.ReadKey();
        }
    }
}
