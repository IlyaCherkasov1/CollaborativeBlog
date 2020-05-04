using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.IO;

namespace Thread_Example
{
    class Program
    {

        static void Main(string[] args)
        {
            Parallel.Invoke(
            () =>
            {
                Console.WriteLine("сразу");
            },

            () =>
            {
                Console.WriteLine("все");

            },

            () =>
            {
                Console.WriteLine("задачи");

            });
        }

        static int i;

         static void Asinc(int i)
        {

        }
    }
}
