using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DomWork1
{
    class Program
    {
        static void Main(string[] args)
        {
            double vir,vir1;
            Console.Write("x=");
            int x =Convert.ToInt32(  Console.ReadLine());
       
            if (x >= -3 & x < -1) 
            {
                Console.WriteLine("формула");
            }
            else if (x >= -1 & x < 1) 

            {
                Console.WriteLine("y=0");

            }
            else if (x >= 1 & x <5) 
            {
                Console.Write("R=");
                int r = Convert.ToInt32(Console.ReadLine());
                vir = Math.Sqrt((Math.Pow(r, 2) - Math.Pow(x, 2)));
                Console.WriteLine("y="+vir);
            }

            else if (x >= 5 & x <= 7) 
            {
                vir1 = (x - 5) * (1/2d);
                Console.WriteLine("y=" +vir1 );
            }
            else Console.WriteLine("вы введи недопустимые элементы функции");
        }
    }
}
