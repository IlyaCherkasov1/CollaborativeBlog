using System;
using System.Collections.Generic;
using System.Text;

namespace ConsoleApp7
{
    class SententesFromCharArray
    {
        char[] text;
        public SententesFromCharArray(char[] text)
        {
            this.text = text;
        }
        public SententesFromCharArray()
        {
            Console.WriteLine("Введите текст");
            this.text = Console.ReadLine().ToCharArray();
        }
        public char[][] GetWords()
        {
            var countWords = text.Count(x => ISMySeparator(x));
            var words = new char[countWord][];
            int start = 0, finish = 0, indexword = 0;
            while(start<text.Length)
            {
                finish = Array.FindIndex(text, start, x => IsMySeparator(x));
                if (finish > start+1)
                {
                    words[indexword] = new char[finish - start];
                    Array.Copy(text, start, words[indexword], 0, finish - start);
                    indexword++;
                }
                start = finish + 1;
            }
            Array.Resize(ref words, indexword);
            return words;
        }

        public char[] MaxLengthWords()
        {
            var words = GetWords();
            return words.Where(x => x.Length == words.Max(y => y.Length)).First();
        }
        private bool IsMySeparator (char x)
        {
            return char.IsWhiteSpace(x) || char.IsPunctuation(x);
        }
    }
}
