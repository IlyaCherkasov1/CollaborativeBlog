using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClassLibraryUP2
{
    public class NumbersInSet
    {
        public NumbersInSet()
        {
            arr = new int[,]
            {
                {5,3,2,9},
                {7,3,1,9},
                {7,28,17,9},
                {19,11,16,32}

            };
            arrSetOfNumbers = new int[] { 13, 14, 15, 16 };
        }

        public int[,] WriteAllTheNumbersInTheSourceSet()
        {
            for (int i =0; i < arr.GetLength(0); i++)
            {
                for (int j = 0; j < arr.GetLength(1); j++)
                {
                    arr[i, j] = arrSetOfNumbers[i];
                }
            }
            return arr;
                
        }

        public void OutputArray(int[,] array)
        {
            for (int i = 0; i < array.GetLength(0); i++)
            {
                for (int j = 0; j < array.GetLength(1); j++)
                Console.Write(String.Format("{0,3}", array[i, j]));
                Console.WriteLine();
            }
        }

        public void OutputArrayOfNumers()
        {
            foreach (var item in arrSetOfNumbers)
            {
                Console.Write(item + " ");
            }
            Console.WriteLine();
        }

        private int[,] arr;
        private int[] arrSetOfNumbers;
    }
}
