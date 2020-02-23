using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HomeWork3
{
    class Program
    {
        public delegate void MyDelegate(int[] arr);
        static void Main(string[] args)
        {
            int[] array = new int[] { 1, 5, 2, 1, 9 };
            MyDelegate[] delegates =  new MyDelegate[3] ;
            delegates[0] = AvverageSum;
            delegates[1] = Max;
            delegates[2] = Min;
            foreach(var i in delegates)
            {
                i(array);
            }
        }

        public static void  AvverageSum(int[] arr)
        {
            int sum = 0;
            for (int i = 0; i < arr.Length; i++)
            {
                sum += arr[i];
            }
            Console.WriteLine("Avverage sum = "+ (int)sum/arr.Length);
        }

        public static void Max(int[] arr)
        {
         Console.WriteLine("Max = " + arr.Max());
        }


        public static void Min(int[] arr)
        {
            Console.WriteLine("Min = " + arr.Min());
        }
    }
}
