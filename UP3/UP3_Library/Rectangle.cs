using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace UP3_Library
{
    /// <summary>
    /// rectanle on set of points
    /// </summary>
   public class Rectangle
    {
        /// <summary>
        /// get default parametr
        /// </summary>
        public Rectangle()
        {
            P1 = new Point(-4, 2);
            P2 = new Point(4, 2);
            P3 = new Point(4, -2);
            P4 = new Point(-4, -2);
        }
        /// <summary>
        /// main constructor
        /// </summary>
        /// <param name="p1"></param>
        /// <param name="p2"></param>
        /// <param name="p3"></param>
        /// <param name="p4"></param>
        public Rectangle(Point p1, Point p2, Point p3, Point p4)
        {
            P1 = p1;
            P2 = p2;
            P3 = p3;
            P4 = p4;
        }
        /// <summary>
        /// gets points
        /// </summary>
        private Point P1 { get; }
        private Point P2 { get; }
        private Point P3 { get; }
        private Point P4 { get; }
        /// <summary>
        /// check in length of Rectangle
        /// </summary>
        /// <param name="x"></param>
        /// <returns>bool type</returns>
        private bool IsInLengthofRectangle(double x)
        {
            if (x >= P1.XCoordinate && x <= P2.XCoordinate)
                return true;
            else
            return false;
        }
        /// <summary>
        /// Find Intersection points
        /// </summary>
        /// <param name="xCordinates"></param>
        /// <returns>List<Point> with intersect</returns>
        public List<Point> FindIntersectionPoints(List<double> xCordinates)
        {
            for (int i = 0; i < xCordinates.Count; i++)
            {
                if (IsInLengthofRectangle(xCordinates[i]))
                {
                    intersectionPoints.Add(new Point(xCordinates[i], P1.YCoordinate));
                    intersectionPoints.Add(new Point(xCordinates[i], P4.YCoordinate));
                }
            }
            return intersectionPoints;
        }
        /// <summary>
        /// output list of points
        /// </summary>
        public void Output()
        {
            foreach (var i in intersectionPoints)
            {
                Console.WriteLine(i);
            }
        }
        /// <summary>
        /// compare two object
        /// </summary>
        /// <param name="obj"></param>
        /// <returns>bool type</returns>
        public override bool Equals(object obj)
        {
            if (obj == null)
                return false;
            return base.Equals(obj);

        }
        /// <summary>
        /// compare two object
        /// </summary>
        /// <returns>hash code</returns>
        public override int GetHashCode()
        {
            return intersectionPoints.Count * 30 / 20;
        }

        private List<Point> intersectionPoints = new List<Point>();

    }
}
