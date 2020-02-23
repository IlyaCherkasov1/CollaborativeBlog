using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Laba3_2
{
    class Program
    {
        static void Main(string[] args)
        {
            //bool t = true;
            //if (t)
            //{
            //    Console.WriteLine("t - true");
            //}
            //else
            //{
            //    Console.WriteLine("t - false");
            //}
            //int[] mas = new int[] { 2, 3, 5, 6, 7 };
            //for (int i = 0; i < mas.Length; i++)
            //{
            //    Console.WriteLine(mas[i]);
            //}
            //Array.ForEach(mas, x => Console.WriteLine(x));
            Console.WriteLine(Sum(0));
            Console.WriteLine(Sum(1));
            Console.WriteLine(Sum(2));
            Console.WriteLine(Sum(10));
            double delta = Math.Pow(10, -3);
            double x1 = 0;
            double x2 = 0;
            int count = 1;
            do
            {
                x2 = x1;
                x1 = Sum(count);
                count++;
            }
            while (Math.Abs(x1 - x2) > delta);
            Console.WriteLine($"На {count} слагаемом точность вычислений превышает = {delta}");
        }

        private static double Sum(int count)
        {
            var first = 1.0;
            var sum = 0d;

            for (int i = 0; i < count; i++)
            {
                sum += first;
                first += 0.1;
            }
            return sum;
        }
    }
}
