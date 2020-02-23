using System.IO;
using System.Text;
using System.Text.RegularExpressions;
using System.Linq;

namespace _7_2
{
    class TextFile
    {
        string path = @"D:\TestFolder\test.txt";
        public string text = "";
        private char[] vovels = "aeyuio".ToCharArray();
        public TextFile()
        {
          
            this.text = File.ReadAllText(path);
       
        }

        public void ReplaceVowels(string text)
        {
            StringBuilder sb = new StringBuilder(text);

            for (int i = 1; i < text.Length; i++)
            {
                if ((text[i - 1] == ' ') && vovels.Contains(text[i]))
                {
                    sb[i] = char.ToUpper(sb[i]);
                }


            }
            System.Console.WriteLine(sb); 
          
        }
        public void ReplaceNumbers(string text)
        {
            StringBuilder sb = new StringBuilder(text);

            sb = sb.Replace("0", "zero");
            sb = sb.Replace("1", "one");
            sb = sb.Replace("2", "two");
            sb = sb.Replace("3", "tree");
            sb = sb.Replace("4", "four");
            sb = sb.Replace("5", "five");
            sb = sb.Replace("6", "six");
            sb = sb.Replace("7", "seven");
            sb = sb.Replace("8", "eight");
            sb = sb.Replace("9", "nine");
            System.Console.WriteLine(sb);
        }

        public void PosA(string text)
        {
            var regex = new Regex(@"(\w*)a(\w*)", RegexOptions.Compiled | RegexOptions.IgnoreCase);
            MatchCollection maches = regex.Matches(text);
            foreach (Match mach in maches)
            {
                System.Console.WriteLine(mach.Value);         
                System.Console.WriteLine("Index symbol: "+mach.Index);
            }


        }

    }
}
