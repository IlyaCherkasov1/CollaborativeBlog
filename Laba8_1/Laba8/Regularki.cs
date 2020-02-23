using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Text.RegularExpressions;
using System.IO;

namespace Laba8
{
    class Regularki
    {
        public string text;
        public string path;
        public string pattern;

        public Regularki(string path, string pattern)
        {
            this.path = path;
            this.text = File.ReadAllText(path);
            this.pattern = pattern;
          
        }

        public void Coincidence()
        {
            Console.WriteLine(text);
            Regex regex = new Regex(pattern);
            MatchCollection matches = regex.Matches(text);
            Console.ForegroundColor = ConsoleColor.Red;
            foreach (Match match in matches)
            {
               
                Console.WriteLine(match.Value);
              
            }
            Console.ResetColor();
        }

        public char? this[int index] // будет обращаться к совпадениям
        {

            get  // Возврат значения, которое определяет индекс.
            {
                Regex regex = new Regex(pattern);
                Match match = regex.Match(text);
          
                bool b = false;

                MatchCollection myMatch = Regex.Matches(text, pattern);
                foreach (Match i in myMatch)
                {
                    for (int j =i.Index; j<i.Index+match.Length;j++)
                    {
                        if (index == j)
                            b = true;

                    }
                        
                }

                if (b == false)
                {
                    Console.WriteLine("Вы вышли за границу");
               
                    return null; 
                }
                else
                { 
                    return text[index];
                }
            }
       

        }
    }
}
