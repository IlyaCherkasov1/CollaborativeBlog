using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _5_2_2
{
    class Program
    {
        static void Main(string[] args)
        {
            int n = 10;
   
        
            int[,] myStartArray = new int[n, n];
            int[,] newArray = SetSpesificValue(myStartArray);
            PrintMatrix(newArray);
        }
        private static int[,] SetSpesificValue(int[,] matrix)
        {
            Random rand = new Random();
            int[,] second = matrix;
            Console.WriteLine("Исходная матрица:");
            for (int i = 0; i < matrix.GetLength(0); i++)
            {
                for (int j = 0; j < matrix.GetLength(1); j++)
                {
                //  if ((i-5<= j) && (i <= (second.GetLength(0)-1) - j) || (i >= (second.GetLength(1) -1) - j) && i >= j)
                 
                //    {
                //        second[i, j] = 0;
                //    }
                //    else
                //    {
                //        second[i, j] = 1;
                //    }

                if ((i>=j) && (i<= (second.GetLength(0)/2)-1) || (i >= (second.GetLength(1) / 2-1) && i <= j))
                  {
                       second[i, j] = 100;
                     
                   }
                   else
                    {
                        second[i, j] = rand.Next(0,5);
                    }


        }
                
            }
            return second;
        }
        private static void PrintMatrix(int[,] matrix)
        {
            for (int i = 0; i < matrix.GetLength(0); i++)
            {
                for (int j = 0; j < matrix.GetLength(1); j++)
                {
                    Console.Write(" " + matrix[i, j]);
                }
                Console.WriteLine();
            }
            Console.ReadKey();
        }
    }
}
