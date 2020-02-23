using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Text.RegularExpressions;
using System.IO;

namespace Laba8
{
    class Program
    {
        static void Main(string[] args)  // \b(0*(?:[1-9][0-9]? \ 
                                         //^([1-9]|[1-2][\d]|3[0-1])$
        {
            Regularki reg1 = new Regularki(@"D:\TestFolder\laba8.txt", @"(([0-2][0-9])|3[0-1])\.\.d{2}.\d{4}");
            reg1.Coincidence();
            Console.WriteLine("Введите идекс элемента: ");
            int i = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Элемент по индексу : ");
            Console.WriteLine(reg1[i]);
            while (Console.ReadKey().Key != ConsoleKey.Enter) { }
        }
    }


}

