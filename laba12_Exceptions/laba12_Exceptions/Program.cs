using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace laba12_Exceptions
{
    class Program
    {
        static void Main(string[] args)
        {
            Calculater a = new Calculater(100);
            Calculater b = new Calculater(100);
            try
            {
                Console.WriteLine(a + b);
            }
            catch (DischargeOverflowException e)
            {
                Console.WriteLine(e.Message);
                Console.WriteLine(e.StackTrace);
            }
            finally
            {
                Console.WriteLine("eror");
            }
        

        Test();

        }

        private static void Test()
        {
            Calculater a = new Calculater(100);
            Calculater b = new Calculater(100);
            try
            {
                Console.WriteLine(a + b);
            }
            catch (DischargeOverflowException e)
            {
                Console.WriteLine(e.Message);
                Console.WriteLine(e.StackTrace);
            }
            finally
            {
                Console.WriteLine("eror");
            }
        }
    }
}
