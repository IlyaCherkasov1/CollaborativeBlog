using System;
using System.Collections.Generic;
using System.IO;
using System.Text.RegularExpressions;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RegexAndEnum
{
    class TextParser
    {
        string text;
        public TextParser()
        {
            text = File.ReadAllText("in.txt");
        }
        public TextParser(string path)
        {
            text = File.ReadAllText(path);
        }
        public string ReplaseName()
        {
            var tempText = text;
            for (Names i = 0; i < (Names)Enum.GetNames(typeof(Names)).Length; i++)
            {
                Regex reg = new Regex(
                new string(
                   i.ToString()
                   .Select((x, index) => index == 0 ? Char.ToLower(x) : x).ToArray()
                   ) + "[a-z]*");

                tempText = reg.Replace(tempText,
                    x => Char.ToUpper(x.Value[0]).ToString() + x.Value.Substring(1, x.Value.Length - 1));
            }
            return tempText;
        }
        public override string ToString()
        {
            return new string('-',25) + "\n" + text + "\n" + new string('-', 25);
        }
    }
}
