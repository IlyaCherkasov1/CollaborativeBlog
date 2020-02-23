using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LekciaMassZadanie3
{
    class Program
    {
        static void Main(string[] args) // среди суммы четных в строке найти максимальный
        {
            int[,] matrix = new int[3, 3]           
 {
               {4,2,5},
               {12,15,18},
               {7,10,8}

 };
            PrintMatr(matrix);
            Macsim(matrix);



        }

        private static void GetMatrix(int n, int m, bool LsRandom ) //генерирует массив NxM случайно или не случайно, в зависимости от параметров LsRandom
        {
           
        }

        private static void Macsim(int[,] matrix)
        {
            int sum;
            int max = 0;
            for (int i = 0; i < matrix.GetLength(0); i++)
            {
                sum = 0;
                for (int j = 0; j < matrix.GetLength(1); j++)
                {
                    if (matrix[i, j] % 2 == 0)
                        sum += matrix[i, j];  
                }
                Console.WriteLine("Сумма="+sum);
                if (sum > max)
                    max = sum;
            
            }
           
            Console.WriteLine("\n Макс суммы четных в строке = "+max);

        }

        private static void PrintMatr(int[,] matrix)
        {
            for (int i = 0; i < matrix.GetLength(0); i++)
            {
                for (int j = 0; j < matrix.GetLength(1); j++)
                {
                    Console.Write("\t" + matrix[i, j]);// \t - Знак табуляции 
                }
                Console.WriteLine();
            }
        }
    }
}
