// нажатия клавиш - вызывающих специализированные команды консоли
using System;
using System.Collections;
using System.Linq;
using test;

namespace ConsoleApplication1
{
    class compare 
    {

        public static void Main()
        {
            int x = 345;
            int  sum = 0;
               while(x > 0)
            {
                sum += x % 10;
                x /= 10;
            }
            Console.WriteLine(sum) ;
        }
    }
}