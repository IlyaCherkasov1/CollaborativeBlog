using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace laba5
{
    class Program
    {
        static void Main(string[] args)
        {
            int mass = new int[] { 1, 2, 3, 4, 5, 15, 20 };
            PrintAll(mass);
        }
        public static void PrintAll(int[] mass)
        {
            Console.WriteLine(string.Join (", ", mass));
        }
    }
}
