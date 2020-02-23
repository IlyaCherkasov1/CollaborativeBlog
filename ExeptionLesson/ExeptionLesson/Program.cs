using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ExeptionLesson
{
    class Program
    {
        static void Main(string[] args)
        {
            while (true)
            {
                int result = 0;
                var input = Console.ReadLine();
                if (int.TryParse(input, out  result))
                {
                    Console.WriteLine($"int {result}");
                    break;
                }
                else
                {
                    Console.WriteLine("incorrecdt input");
                }
            }

            int i = 5;
            try
            {
                //throw new DivideByZeroException();
                throw new MyOwnException();

            }
            catch ( DivideByZeroException ex) when (i == 5)
            {
                Console.WriteLine(ex.Message + "i = 5");
            }
            catch (MyOwnException ex)
            {
                Console.WriteLine(ex.Message);
            }
            finally
            {
                Console.WriteLine("end work");
            }

        }
    }
}
