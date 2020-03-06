using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Laba15_1
{
    class Program
    {
        static void Main(string[] args)
        {
            Matrix mt = new Matrix();
            mt.AddToFile();
            mt.SortSentences();
            mt.CreateFileInDirectory("Directory");
        }
    }
}
