using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EncapsulationExample
{
    class Program
    {
        static void Main(string[] args)
        {
            var point = new Point();
            var p1 = point.CreatePoint(3, 4);
            var p2 = point.CreatePoint(1,2);
            var distance = p1.GetDistance(p2);
        }
    }
}
