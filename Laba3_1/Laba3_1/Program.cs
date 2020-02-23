using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Laba3_1
{
    class Program
    {
        static void Main(string[] args)
        {
            double  vir1;
            double vir;

            Console.Write("x=");
            int x = Convert.ToInt32(Console.ReadLine());
            Console.Write("R=");
            int r = Convert.ToInt32(Console.ReadLine());

            if (x >= -10 & x < -8)
            {
                Console.WriteLine("y=-3");
            }
           
            else if (x >= -8 & x < -3)
            {
                vir1 = 3 * ((x + 8) / 5d) - 3;
                Console.WriteLine("y="+vir1);
              
            }
            else if (x >= -3 & x < 3)
            {
                vir = -Math.Sqrt((Math.Pow(r, 2) - Math.Pow(x, 2)));
             //  vir= -Math.Sqrt(Math.Pow(r, 2)-(x)
                Console.WriteLine("y=" + vir);
            }
            else if (x >= 3 & x < 5) 
            {
                Console.WriteLine("y="+(x-3));
            }
            else if (x >= 5 & x <= 8)
            {
           
            }
            else Console.WriteLine("вы введи недопустимое значение  функции");
        }
    }
}
