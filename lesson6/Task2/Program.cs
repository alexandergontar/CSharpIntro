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
        /// Находит точку пересечени двух линий: y = k1 * x + b1, y = k2 * x + b2 
        /// </summary>
        /// <param name="k1"></param>
        /// <param name="k2"></param>
        /// <param name="b1"></param>
        /// <param name="b2"></param>
        /// <returns>х и у - координаты точки пересечения</returns>
        static (double x, double y) LinearEquation(int k1, int k2, int b1, int b2)//Метод решает линейные уравнения
        {

            if (k1 != k2)
            {               
                double x = (double)(b1 - b2) / (double)(k2 - k1);
                double y = x * k1 + b1;
                x = Math.Round(x, 2);
                y = Math.Round(y, 2);
                return (x, y);
            }
            else
            {
                Console.WriteLine("k1 = k2 - Уравнение не имеет решения");
                Console.ReadKey();
                return (0, 0);
            }

        }
        static void Main(string[] args)
        {
            Console.WriteLine("========== Решение линейного уравнения. =========");
            Console.WriteLine("Введите 4 числа - \n" +
    "значения b1, k1, b2 и k2 в уравнениях y = k1 * x + b1, y = k2 * x + b2 : ");
            int k1 = GetInputNumber("k1 = ");
            int k2 = GetInputNumber("k2 = ");
            int b1 = GetInputNumber("b1 = ");
            int b2 = GetInputNumber("b2 = ");
            (double x, double y) = LinearEquation(k1, k2, b1, b2);
            Console.WriteLine($"Координаты точки пересечения: x = {x} ; y = {y}");
            Console.ReadKey();
        }
    }
}
