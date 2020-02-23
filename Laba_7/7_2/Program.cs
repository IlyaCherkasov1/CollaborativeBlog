using System;
using System.IO;
using System.Text;
using System.Text.RegularExpressions;

namespace _7_2
{
    class Program
    {
        static void Main(string[] args)
        {
            TextFile folder = new TextFile();
            Console.WriteLine("Исходынй текст:");
            Console.WriteLine(folder.text);
            Console.WriteLine();
            Console.WriteLine("Гласные начинать с прописной буквы:");
            folder.ReplaceVowels(folder.text);
            Console.WriteLine();
            Console.WriteLine("Замена цифр словами:");
            folder.ReplaceNumbers(folder.text);
            Console.WriteLine( );
            folder.PosA(folder.text);


        }
    }

}
