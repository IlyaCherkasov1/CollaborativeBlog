using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp2
{
    class Program
    {
        static void Main(string[] args)
        {
            double x1, x2, x3, y1, y2, y3, s, p, pp, st1, st2, st3;
            Console.Write("x1=");
            x1 = Convert.ToDouble(Console.ReadLine());
            Console.Write("y1=");
            y1 = Convert.ToDouble(Console.ReadLine());
            Console.Write("x2=");
            x2 = Convert.ToDouble(Console.ReadLine());
            Console.Write("y2=");
            y2 = Convert.ToDouble(Console.ReadLine());
            Console.Write("x3=");
            x3 = Convert.ToDouble(Console.ReadLine());
            Console.Write("y3=");
            y3 = Convert.ToDouble(Console.ReadLine());

            st1 = Math.Sqrt(Math.Pow((x2 - x1), 2) + Math.Pow((y2 - y1), 2));
            st2 = Math.Sqrt(Math.Pow((x3 - x2), 2) + Math.Pow((y3 - y2), 2));
            st3 = Math.Sqrt(Math.Pow((x3 - x1), 2) + Math.Pow((y3 - y1), 2));

            p = st1 + st2 + st3;
            pp = p / 2;
            s = Math.Sqrt(pp * (pp - st1) * (pp - st2) * (pp - st3));
            Console.WriteLine("P=" + p);
            Console.WriteLine("S=" + s);
        }
    }
}
