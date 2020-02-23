using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace laba3attempt
{
    class Program
    {
        static void Main(string[] args)
        {
            decimal delta = 0.0000001m;       // Math.Pow(10, -6);
            decimal y=0m; 
            decimal x = -0.6m;
            int nachalo1 = 1;
            decimal nachalo2 = 2.0m;
           decimal vir = 0m;
            int i = 0;
            int first = 1;
            int sign = -1;
            decimal firstSlog = 0m;
            double Thirdstolb = 0;
            double x1;

            Console.WriteLine("x    |           Тейлор                           |   Math");

            do
            {
                
                i++;
                firstSlog = vir;
                vir = first + 1 * sign * (((nachalo1 + i) * (nachalo2 + i)) / nachalo2) *Convert.ToDecimal( Math.Pow(Convert.ToDouble(x), i));
                if ((Math.Abs(firstSlog - vir) < delta) & i != 0 & i!=3) 

                {
                    if (x != 0)              
                    {
                        x1 = Convert.ToDouble(1 + x); 
                        Thirdstolb = Math.Pow(x1, -3);
                        Console.WriteLine("-------------------------------------------------------------");
                        Console.WriteLine("{0} | на {1} слагаеме; y={2} | {3} ", x, i, y, Thirdstolb);
                    }                
 




                    y = 0m;
                    nachalo1 = 1;
                    nachalo2 = 2.0m;
                    i = 0;
                    first = 2;
                    sign = -1;
                    vir = 0m;
                    y = 0m;
                    sign = 1;
                    x += 0.1m;

                    if (x == 0.9m) 
                        break;
                }
                
                if (first==1)
                    first = 0;
                if (first == 2)
                    first = 1;
                sign = -sign;
                y += vir;
            }
            while (true);

        }
    }
}
