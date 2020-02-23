using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EncapsulationExample
{
    class Point
    {
        double x;
        double y;

        public  Point CreatePoint(double x, double y)
        {
            var point = new Point();
            point.x = x;
            point.y = y;
            return point;
        }
       public double GetDistance(Point other)
        {
            double dx = this.x - other.x;
            double dy = this.y - other.y;
            return Math.Sqrt(dx * dx + dy * dy);
        }
    }
}
