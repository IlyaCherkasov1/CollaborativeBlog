using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClassLibraryUP2
{
    public class ClosestToAverage
    {
        public ClosestToAverage()
        {
            arr = new int[,]
            {
                {5,34,2,9},
                {7,3,5,6},
                {7,28,17,3},
                {19,11,1,32}

            };
        }

        public (int Iindex,int Jindex) CalculateClosesToAverage()
        {
        
            double average =  CalculateAvverageNumber(arr);
            double min = 100;
            int index1=0, index2=0;
            for (int i = 0; i < arr.GetLength(0); i++)
            {
                for (int j = 0; j < arr.GetLength(1); j++)
                {
                   if (Math.Abs(arr[i,j] - average) < min)
                    {
                        min = Math.Abs(arr[i, j] - average);
                        index1 = i;
                        index2 = j;

                    }
                }
            }
            return (index1, index2);
        }

        public double CalculateAvverageNumber(int[,] array)
        {
            double average = 0;
            double sum = 0;
            for (int i = 0; i < array.GetLength(0); i++)
                for (int j = 0; j < array.GetLength(1); j++)
                {
                    sum += array[i, j];
                }
            average = sum / array.Length;
            return average;
        }

     
    

        public void OutputArray()
        {
            for (int i = 0; i < arr.GetLength(0); i++)
            {
                for (int j = 0; j < arr.GetLength(1); j++)
                    Console.Write(String.Format("{0,3}", arr[i, j]));
                Console.WriteLine();
            }
        }

        private int[,] arr;
    }
}
