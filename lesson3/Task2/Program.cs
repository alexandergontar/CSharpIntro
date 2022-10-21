using System;

namespace Task2
{
    class Program
    {
        /// <summary>
        /// Получаем числовой массив вводом чисел с клавиатуры
        /// </summary>
        /// <returns></returns>
        static int[] GetInputArray()
        {
            string[] inputString = Console.ReadLine().Split(" ");
            int size = inputString.Length;
            if (size > 0)
            {
                try
                {
                    int[] A = new int[size];
                    for (int i = 0; i < size; i++)
                    {
                        A[i] = Convert.ToInt32(inputString[i]);                      
                    }
                    return A;
                }
                catch (Exception ex)
                {

                    Console.WriteLine(ex.ToString());                    
                    return null;
                }
            }
            else
            {
                Console.WriteLine("Пустой ввод");
                Console.ReadKey();
                return null;
            }
        }

        /// <summary>
        /// Вычисляем расстояние между точкам А и В
        /// координаты точек в N-мерном пространстве
        /// задаются N-мерными массивами
        /// </summary>
        /// <param name="A">массив А</param>
        /// <param name="B">массив В</param>
        /// <returns></returns>
        static double GetDistance(int [] A, int [] B)
        {
            if (A.Length != B.Length)
            {
                Console.WriteLine("Размерность точек не совпадает");
                Console.ReadKey();
                return 0;
            }
            int distanceSquare = 0;
            int size = A.Length;
            for (int i = 0; i < size; i++)
            {
                distanceSquare += (A[i] - B[i]) * (A[i] - B[i]);
            }
            double distance = Math.Sqrt(distanceSquare);
            return distance;
        }
        
        /// <summary>
        /// приминяем вышеуказанные методы
        /// для 2-х точек в 3-мерных координатах
        /// </summary>
        /// <param name="args"></param>
        static void Main(string[] args)
        {
            Console.WriteLine("Введите 3 координаты точки А, разделенные пробелами: ");
            int[] A = GetInputArray();
            Console.WriteLine("Введите 3 координаты точки B, разделенные пробелами: ");
            int[] B = GetInputArray();
            if (A == null || B == null)
            {
                Console.WriteLine("Неверный ввод, нажмите любую клавишу для выхода.");
                Console.ReadKey();
                return;
            }
            if (A.Length != 3 || B.Length != 3)
            {
                Console.WriteLine("У точек должно быть 3 координаты");
                Console.ReadKey();
                return;
            }

            
            double distance = GetDistance(A, B);
            Console.WriteLine($"Расстояние мужду точками А и В равно: "+"{0: 0.00}", distance);
            Console.ReadKey();
        }
    }
}
