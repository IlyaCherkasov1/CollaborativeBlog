using System;

namespace _7_1
{
    class SentensesFromCharArray
    {
        public char[] text;
        public char[] output = new char[64];
        public SentensesFromCharArray()
        {
            Console.WriteLine("Введите текст");
            this.text = Console.ReadLine().ToCharArray();
        }
        public SentensesFromCharArray(char[] text)
        {
            this.text = text;
        }

        public void Replace(char[] text)
        {

            for (int i = 0; i < text.GetLength(0); i++)
            {
                if (text[i] == 'o')
                {
                    text[i] = 'a';

                }
            }

            Console.WriteLine("Преобразованный текст: ");
        }

        public void DelSpace(char[] text)
        {
            bool NextWord = false;
            int k = -1;

            for (int i = 0; i < text.Length; i++)
            {
                k++;

                if (char.IsWhiteSpace(text[i]) && ((text[i + 1] ==',') || (text[i + 1] == '.') || (text[i + 1] == '?') || (text[i + 1] == '!')))
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
        }





        #region PrintChar
        public void PrintChar(char[][] words)
        {
            foreach (var item in words)
            {
                Console.Write(item);
                Console.Write(" ");
            }
        }
        #endregion

        public void PrintChar1(char[] text)
        {
            for (int i = 0; i < text.GetLength(0); i++)
            {
                Console.Write(text[i]);
            }
        }

    }
}

