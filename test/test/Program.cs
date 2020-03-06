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
            string s1 = "cat";
            string s2 = "cat";
            s2 = "Dog";
            Console.WriteLine(s1 + " " + s2);
        }
    }
}