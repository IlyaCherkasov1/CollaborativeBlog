using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Laba5_1
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] mass = new int[] { 1, 3, 9, 17, 20 };
            int[] mass1 = new int[] { 50, 3, 9,5 ,2,1};
            int y = 18;
            //PrintAll(mass);
            //PrintAll(mass1);
            //Cratno(mass);
            //Interval(mass, y);
            //if (DecreaseCheck(mass1))
            //{
            //    Console.WriteLine("Decrease");
            //}
            // Дано два массива. Взять элементы из одной и которой нет в другой
            // пересечение - 
            
            
        } 
        public static void PrintAll(int[] mass)
        {
            Console.WriteLine(string.Join(", ", mass));
        }

        public static void Cratno(int[] mass)
        {
            Console.WriteLine("Count="+mass.Count(x => (x % 3 == 0) && (x % 5 != 0)));

        }
        public static void Interval(int[] mass1, int y)
        {
            for (int k = 0; k < mass1.Length; k++)
            {
                if (mass1.Length - 1 == k)
                    break;

                if ((mass1[k] < y) & (mass1[k + 1] >= y))
                    Console.WriteLine("k="+k);
            }
         
        }

        public static bool DecreaseCheck(int[] mass1)
        {
             if (mass1.SequenceEqual(mass1.OrderByDescending(x => x)))
                    return true;
            else
                return false;
        
        }
    }
}
   