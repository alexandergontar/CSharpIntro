using System;

namespace FillContour
{
    class Program
    {
        static void PrintImage(int [,] pic) 
        {
            for (int i = 0; i < pic.GetLength(0); i++)
            {
                for (int j = 0; j < pic.GetLength(1); j++)
                {
                    Console.Write($"{pic[i, j]} ");
                }
                Console.WriteLine();
            }
        }

         static  void FillImage(int row, int col, int [,] pic)
            {
                if (pic[row, col] == 0)
                {
                    pic[row, col] = 1;
                    FillImage(row - 1, col, pic);
                    FillImage(row, col - 1, pic);
                    FillImage(row + 1, col, pic);
                    FillImage(row, col + 1, pic);
                }
            }
        static void Main(string[] args)
        {
            int[,] pic = { {0, 0, 0, 0, 0, 0 },
                           {0, 1, 1, 1, 1, 0 },
                           {0, 1, 0, 0, 1, 0 },
                           {0, 1, 0, 0, 1, 0 },
                           {0, 1, 1, 1, 1, 0 },
                           {0, 0, 0, 0, 0, 0 }
                         };
            PrintImage(pic);
            
 
            FillImage(2, 2, pic);
            Console.WriteLine();
            PrintImage(pic);
            
            Console.ReadKey();
        }
    }
}
