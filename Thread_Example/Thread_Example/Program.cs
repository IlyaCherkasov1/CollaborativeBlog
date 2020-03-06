using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace Thread_Example
{
    class Program
    {
        static void Main(string[] args)
        {
            using (var mutex = new Mutex(false, "RandomString"))
            {
                if (!mutex.WaitOne(TimeSpan.FromSeconds(3), false))
                {
                    Console.WriteLine("Another instance is running");
                    return;
                }
                RunProgram();
            }
          
        }

        private static void RunProgram()
        {
            Console.WriteLine("Running");
            Console.ReadKey();
        }
    }
}
