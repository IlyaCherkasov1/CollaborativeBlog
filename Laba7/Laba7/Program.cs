using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Laba_7
{
    class Program
    {
        static void Main(string[] args)
        {
            SentensesFromCharArray sent = new SentensesFromCharArray("Potiently ,        Woiting     dfsd.".ToCharArray());
   
            
            
            Console.WriteLine("Исходный текст:");
            Console.WriteLine(sent.text);
            Console.WriteLine("");
            Console.WriteLine("Задание 1 ");
             sent.Replace(sent.text);
             sent.PrintChar1(sent.text);
            Console.WriteLine(" ");
              Console.WriteLine(" ");
            Console.WriteLine("Задание 2");
            Console.WriteLine("Отредоктированное предложение:");
            sent.DelSpace(sent.text);
            sent.PrintChar1(sent.output);
          
          Console.WriteLine();
           
        }
    }
}




