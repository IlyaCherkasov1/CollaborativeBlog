using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace UP3_Library
{
    /// <summary>
    /// get class point x and y
    /// </summary>
    public class Point
    {
    
        /// <summary>
        /// default constructor
        /// </summary>
        /// <param name="x"></param>
        /// <param name="y"></param>
        public Point(double x, double y)
        {
            XCoordinate = x;
            YCoordinate= y;
        }
        /// <summary>
        /// gets x
        /// </summary>
        public double XCoordinate { get;}
        /// <summary>
        /// gets y
        /// </summary>
        public double YCoordinate { get;}
        /// <summary>
        /// output Point object
        /// </summary>
        /// <returns></returns>
        public override string ToString() => $"P:({XCoordinate.ToString()},{YCoordinate.ToString()}) ";
        /// <summary>
        /// compare two object
        /// </summary>
        /// <param name="obj"></param>
        /// <returns>bool type</returns>
        public override bool Equals(object obj)
        {
            if (obj == null)
                return false;
            Point p2 = obj as Point;
            return p2 != null &&
                    XCoordinate == p2.XCoordinate &&
                    YCoordinate == p2.YCoordinate;

        }
        /// <summary>
        /// compare two object
        /// </summary>
        /// <returns>hash code</returns>
        public override int GetHashCode()
        {
            return (int)(XCoordinate + YCoordinate);
        }
    }
}
