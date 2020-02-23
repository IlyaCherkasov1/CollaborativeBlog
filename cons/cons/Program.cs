using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace cons
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] Omass = new int[] { 1, 2, 3, 4, 5 };
            int[] Omass1 = new int[] { 2, 5, 3, 2, -1 };
            PrintAll(Omass);
            if (Omass.SequenceEqual(Omass.OrderBy(x => x)))
                Console.WriteLine("increasing");
            if (Omass.All(x=>x>0))
                Console.WriteLine("Все элементы больше нуля");
            //  PrintAll(Omass.Intersect(Omass1).ToArray());// пересечение
            PrintAll(Omass1);
          // Console.WriteLine(Omass.Max());
            double sred;
           sred = Omass1.Average();
            int k = 0;
            for  (int i=0; i<Omass1.Length; i++  )
            {
             
                if (Omass1[i] < sred)
                {
                    k++;
                    Console.WriteLine(Omass1[i]);
                }
                   


            }
            Console.WriteLine(k);
            
        }
        static void PrintAll(int[] Omass)
        {
            Console.WriteLine(String.Join(", ", Omass));
        }
    }
}
