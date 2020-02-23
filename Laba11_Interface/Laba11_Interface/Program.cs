using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Collections;
using ClassLibrary1;

namespace Laba11_Interface
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] arr = new int[] { 1, 12, 23, 13, 9, 11, 3, 7 };
            IComparer<int> cmp = new numbers();
            Array.Sort(arr, cmp);
            foreach (int i in arr)
            {
                Console.Write(i + " ");
            }
            Console.WriteLine();

            PointArray pa = new PointArray();
            pa.Add(new Point(-3, 2));
            pa.Add(new Point(-3, -2));
            pa.Add(new Point(3, 2));
            pa.Add(new Point(-2, -1));
            pa.Add(new Point(2, 3));
            pa.Add(new Point(4, 5));

            Array.Sort(pa.mas);
            foreach (var item in pa)
            {
                Console.WriteLine(item);
            }

            Console.WriteLine();
            foreach (Point i in pa.MyWrite())
            {
                Console.WriteLine(i);
            }


        }
        
    }
}
