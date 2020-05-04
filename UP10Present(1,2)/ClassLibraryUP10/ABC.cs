using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClassLibraryUP10
{
    public class ABC
    {
        public ABC(int a, int b, int c)
        {
            A = a;
            B = b;
            C = c;
        }

        public ABC()
        {
            A = 5;
            B = 10;
            C = 15;
        }

        public int A { get; set; }
        public int B { get; set; }
        public int C { get; set; }

        public override string ToString()
        {
            return $" A = {A} B = {B} C = {C}";
        }
    }
}
