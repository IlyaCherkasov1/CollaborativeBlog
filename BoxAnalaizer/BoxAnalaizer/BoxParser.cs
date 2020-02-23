using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;

namespace BoxAnalaizer
{
    class BoxParser
    {
        string text;
        public BoxParser()
        {
            text = File.ReadAllText("in.txt");
        }
        public Box[] GetBox()
        {
            Regex reg = new Regex(@"box\s(?<weigth>\d+)\s(?<name>\w+)");
            return reg.Matches(text)
                    .Cast<Match>()
                    .Select(x => new Box(
                                    int.Parse(x.Groups["weigth"].Value),
                                   (InBox) Enum.Parse(typeof(InBox), x.Groups["name"].Value)))
                    .ToArray();
        }
    }
}
