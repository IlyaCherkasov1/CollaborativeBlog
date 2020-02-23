using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClassLibrary1
{
    /// <summary>
    /// get class point x and y
    /// </summary>
    public class Point : IComparable
    {
        public double x;
        public double y;
        public double zero = 0d;
        /// <summary>
        /// default constructor
        /// </summary>
        /// <param name="x"></param>
        /// <param name="y"></param>
        public Point(double x, double y)
        {
            this.x = x;
            this.y = y;
        }
        /// <summary>
        /// gets x
        /// </summary>
        public double XCoordinate => x;
        /// <summary>
        /// gets y
        /// </summary>
        public double YCoordinate => y;
        /// <summary>
        /// compare to start to coordinate
        /// </summary>
        /// <param name="obj"></param>
        /// <returns></returns>
        public int CompareTo(object obj)
        {
            if ((this.zero < this.x) && (this.zero < this.y))
                return 1;
            if ((this.zero > this.x) && (this.zero > this.y))
                return -1;
            else
                return 0;
        }
        /// <summary>
        /// output Point object
        /// </summary>
        /// <returns></returns>
        public override string ToString() => $"x:{x.ToString()} y:{y.ToString()} ";

    }
}
