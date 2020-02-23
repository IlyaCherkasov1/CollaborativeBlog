using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace laba2
{
    class Program
    {
        static void Main(string[] args)
        {
            double x,y,z, expr1,expr2;

            Console.Write("y=");
            y = Convert.ToDouble(Console.ReadLine());
            Console.Write("x=");
            x = Convert.ToDouble(Console.ReadLine());
        
            expr1 = y / (y - 2);
            expr1 = Math.Pow(expr1, 2);

            expr2 = Math.Log(y)/(  Math.Pow(y, -3) + x);
            z = expr1 - expr2;
            Console.WriteLine(z);



        }
    }
}
