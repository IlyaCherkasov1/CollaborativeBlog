using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RegexAndEnum
{
    class Program
    {
        static void Main(string[] args)
        {
            TextParser tp = new TextParser();
            Console.WriteLine(tp);
            Console.WriteLine(tp.ReplaseName());
        }
    }
}
