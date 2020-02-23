using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FileLaba15
{
    class Program
    {
        static void Main(string[] args)
        {
            Matrix mt = new Matrix("input1.txt");
            mt.AddToFile();
        }
    }
}
