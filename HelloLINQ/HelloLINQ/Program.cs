using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Linq;

namespace HelloLINQ
{
    class Program
    {
        static void Main(string[] args)
        {
            //NewMethod1();
            //NewMethod();
            // NewMethod2();
        }

        private static void NewMethod2()
        {
            string[] numbers = { "0042", "010", "9", "27" };
            int[] nums = numbers.Select(s => int.Parse(s)).OrderBy(s => s).ToArray();
            foreach (var i in nums)
            {
                Console.WriteLine(i);
            }
        }

        private static void NewMethod1()
        {
            string[] greetings = { "hello world", "hello LINQ", "hello Apress" };
            var items =
                from s in greetings
                where s.EndsWith("LINQ")
                select s;
            foreach (var i in items)
                Console.WriteLine(i);
        }

        private static void NewMethod()
        {
            XElement books = XElement.Parse(
        @"<books>
        <book>
        <title>Pro LINQ: Language Integrated Query in C# 2010</title>
        <author>Joe Rattz</author>
        </book>
        <book>
        <title>Pro .NET 4.0 Parallel Programming in C#</title>
        <author>Adam Freeman</author>
        </book>
        <book>
        <title>Pro VB 2010 and the .NET 4.0 Platform</title>
        <author>Andrew Troelsen</author>
        </book>
        </books>");
            var titles =
            from book in books.Elements("book")
            where (string)book.Element("author") == "Joe Rattz"
            select book.Element("title");
            foreach (var title in titles)
                Console.WriteLine(title.Value);
        }
    }
}
