using System;

namespace ConsoleApp7
{
    class Program
    {
        static void Main(string[] args)
        {
            SententesFromCharArray sent = new SententesFromCharArray("Ia ebal menya sosali   .".ToCharArray());
            Console.WriteLine("Слова в тексте");
            foreach (var item in sent.GetWords())
            {
                Console.WriteLine(item);
            }
            Console.WriteLine("Самое длинное слово");
            Console.WriteLine(sent.MaxLengthWords());
        }
    }
}
