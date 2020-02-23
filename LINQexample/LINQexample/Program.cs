
using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LINQexample
{
    class Program
    {
        static void Main(string[] args)
        {
            RepeatDistinct();
        }

        private static void RepeatDistinct()
        {
            int[] factors = { 2, 2, 1, 1, 3, 4, 5 };
            var uniqueFactors = factors.Distinct();
            Console.WriteLine(string.Join(" ", uniqueFactors));
        }

        private static void Zip()
        {
            string[] words = { "a", "b", "c", "d", "e" };
            int[] numbers = { 1, 2, 3 };
            var result = words.Zip(numbers, (w, n) => w + n);
            Console.WriteLine(string.Join(" ", result));
        }

        private static void DefaultAndEmpty()
        {
            string[] word = { "one", "two", "three" };
            var result = word.Where(w => w.Length == 9).DefaultIfEmpty("unknown").Count();
            Console.WriteLine(result);
        }

        private static void Repeat()
        {
            var allOnes = Enumerable.Repeat("one", 4);
            DefaultOutput(allOnes);
        }

        private static void DefaultOutput(IEnumerable<string> allOnes)
        {
            Console.WriteLine(string.Join(" ", allOnes));
        }


        private static void RandomEven()
        {
            var allEven = Enumerable.Range(0, 10).Where(n => n % 2 == 0);
            foreach (var i in allEven)
                Console.WriteLine(i);
        }

        private static void Single()
        {
            string[] words = { "one", "two", "three" };
            var longest = words.Max(w => w.Length);
            var longestWord = words.Where(w => w.Length == longest).Single();
            Output(longestWord);
        }

        private static void Output(string arr)
        {
            foreach (var i in arr)
                Console.WriteLine(i);
        }

        private static void LookUp()
        {
            List<string> colors = new List<string>
            {
                "red",
                "green",
                "blue",
                "yellow"
            };
            var result = colors.ToLookup(c => c.Length);
            foreach (IGrouping<int, string> packageGroup in result)
            {
                Console.WriteLine(packageGroup.Key);
                foreach (string str in packageGroup)
                    Console.WriteLine("    {0}", str);
            }
        }

        private static void toArray()
        {
            var asAray = Enumerable.Range(0, 4).Select(x => "word" + x).ToArray();
            foreach (var i in asAray)
                Console.WriteLine(i);
        }

        private static void AppendInString()
        {
            var words = new[] { "w1", "w2", "w3", "w4" };
            var text = words.Aggregate(new StringBuilder(), (a, b) => a.Append(b + "."));
            Console.WriteLine(text);
        }

        private static void min()
        {
            string[] words = { "three", "two", "four" };
            var min = words.Min(x => x.Length);
            Console.WriteLine(min);
        }

        private static void Distinct()
        {
            int[] factors = { 2, 2, 3, 5, 5 };
            int uniqueFacotrs = factors.Distinct().Count();
            Console.WriteLine(uniqueFacotrs);
        }
    }
}
