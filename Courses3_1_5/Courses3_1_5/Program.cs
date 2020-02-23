using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Courses3_1_5
{
    class Program
    {
        static void Main(string[] args)
        {
            string value = "Patiently     Waiting    Bad    husband";
            char[] CharArray = value.ToCharArray();
         
            PrintChar(DelSpace(CharArray));
         
        }
        public static char[] output = new char[64];
        
        public static char[] DelSpace(char[] text)
        { 
        bool NextWord = false;
        int k = -1;

            for (int i = 0; i < text.Length; i++)
            {
                k++;

                if (char.IsWhiteSpace(text[i]) && ((text[i + 1] == ',') || (text[i + 1] == '.') || (text[i + 1] == '?') || (text[i + 1] == '!')))
                {
                    output[k] = text[i + 1];
                    text[i + 1] = ' ';
                    k++;
                }

                if (char.IsWhiteSpace(text[i]) && char.IsWhiteSpace(text[i + 1]))
                {
                    output[k] = ' ';
                    NextWord = false;

                    for (int j = i; j < text.Length; j++)
                    {
                        if (char.IsWhiteSpace(text[j]) == false)
                        {
                            k++;
                            output[k] = text[j];
                            NextWord = true;
                            i = j;
                        }
                        else
                        {
                            if (NextWord)
                            {
                                break;
                            }
                        }

                    }
                }
                else
                {

                    output[k] = text[i];
                }


            }
            return output;
        }
        public static void PrintChar(char[] text)
        {
            for (int i = 0; i < text.GetLength(0); i++)
            {
                Console.Write(text[i]);
            }
        }
    }
}
