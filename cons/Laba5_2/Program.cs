using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Laba5_2
{
    class Program
    {
        static void Main(string[] args)
        {
            int[,] matrix = new int[3, 3]           //найти треугольник с самой большой площадью
            {
               {4,2,5},
               {12,15,18},
               {7,10,8}
  
            };          
            Console.WriteLine("Getlength(0)="+matrix.GetLength(0));
            Console.WriteLine("Getlength(1)=" + matrix.GetLength(1));
            Console.WriteLine("Length="+matrix.Length);
            PrintMatr(matrix);
            LargestArea(matrix);
             

        }

        private static void LargestArea(int[,] matrix)
        {
            double max = 0;
           for (int i=0; i<matrix.GetLength(0); i++)
            { 
            double s = 0;
            double p = 0;
            double a = 0;
            double b = 0;
            double c = 0;
            double pp = 0;
            


                for (int j = 0; j < matrix.GetLength(1); j++)
                {
                   switch (j)
                    {
                        case 0:
                            a = matrix[i,j];
                            p += a;
                            break;
                        case 1:
                            b = matrix[i, j]; 
                            p += b;
                            break;
                        case 2:
                            c = matrix[i, j];
                            p += c;
                            pp = p / 2;
                            s = Math.Sqrt(pp * (pp - a) * (pp - b) * (pp - c));
                            if (s > max)
                                max = s;
                            Console.WriteLine(Math.Round(s,2));
                            break;
                    }
                    
                }
            }
            Console.WriteLine();
            Console.WriteLine("максимальная площадь="+Math.Round(max,2));

        }

        private static void PrintMatr(int [,] matrix)
        {
           for (int i=0; i<matrix.GetLength(0); i++)
            {
                for (int j=0; j<matrix.GetLength(1); j++)
                {
                    Console.Write("\t" + matrix[i, j]);// \t - Знак табуляции 
                }
                Console.WriteLine() ;
            }
        }
    }
}
