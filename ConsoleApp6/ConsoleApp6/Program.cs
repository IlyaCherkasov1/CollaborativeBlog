using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp6
{
    class Program
    {
        static void Main(string[] args)
        {
            char[] chars = new char[4];

            chars[0] = 'X';        // Character literal
            chars[1] = '\x0058';   // Hexadecimal
            chars[2] = (char)88;   // Cast from int type
            chars[3] = '\u0058';   // Unicode

            foreach (char c in chars)
            {
                Console.Write(c + " ");
            }
            char x = 'Ь';
            Console.WriteLine((int)x);


        }
    }
}
