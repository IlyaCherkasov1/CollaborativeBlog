using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClassLibraryUP2
{
    public class OddNumbers
    {
        public OddNumbers()
        {
            arr = new int[,]
            {
                {5,3,2,9},
                {7,3,1,9},
                {7,28,17,9},
                {19,11,16,32}

            };
        }

        public int[,] IncreaceOddNumbers()
        {
            int oddNumbers = FindFirstOddNumber();
            if (oddNumbers != 0)
            {
                for (int i = 0; i < arr.GetLength(0); i++)
                    for (int j = 0; j < arr.GetLength(1); j++)
                    {
                        if (arr[i, j] % 2 == 1)
                        {
                            arr[i, j] += oddNumbers;
                        }
                    }
            }
            return arr;
        }

        private int FindFirstOddNumber()
        {
            int oddNumbers = 0;
            for (int i = 0; i < arr.GetLength(0); i++)
                for (int j = 0; j < arr.GetLength(1); j++)
                {
                    if (arr[i, j] % 2 == 1)
                    {
                        oddNumbers = arr[i, j];
                        return oddNumbers;
                    }
                }
            return oddNumbers;
        }

    
        public void OutputArray()
        {
            for (int i = 0; i < arr.GetLength(0); i++)
            {
                for (int j = 0; j < arr.GetLength(1); j++)
                    Console.Write(String.Format("{0,5}", arr[i, j]));
                Console.WriteLine();
            }
            Console.WriteLine();
        }

        private int[,] arr;
    }
  
}
