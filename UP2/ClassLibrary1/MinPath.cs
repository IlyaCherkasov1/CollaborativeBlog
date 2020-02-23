using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClassLibraryUP2
{
   public class MinPath
    {
        public MinPath()
        {
            arr = new int[,]
            {
                {5,3,2,9},
                {7,3,1,9},
                {7,28,17,9},
                {19,11,16,32}

            };
            path = new List<int>();
        }

        public List<int> FindMinPath()
        {
            path.Add(arr[1,1]);
            int i = 1;
            int j = 1;
            while (i < arr.GetLength(0) - 1 && j < arr.GetLength(1) - 1)
            {
                if (FirstMin(arr[i, j + 1], arr[i + 1, j]))
                {
                    path.Add(arr[i, j + 1]);
                    j += 1;

                }
                else
                {
                    path.Add(arr[i + 1, j]);
                    i += 1;
                }
                if (i == arr.GetLength(0)-1)
                    for (int k = j+1; k < arr.GetLength(0); k++)
                    {
                        path.Add(arr[i, k]);
                    }

                if (j == arr.GetLength(1) - 1)
                    for (int k = i + 1; k < arr.GetLength(1); k++)
                    {
                        path.Add(arr[k,j]);
                    }

            }
                
            return path;
        }

        private bool FirstMin(int a, int b)
        {
            if (a < b)
                return true;
            return false;
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

        public void OutputList()
        {
            foreach (int i in path)
            {
                Console.Write(i + " ");
            }
            Console.WriteLine();
        }

        private int[,] arr;
        private List<int> path;
    }
}
