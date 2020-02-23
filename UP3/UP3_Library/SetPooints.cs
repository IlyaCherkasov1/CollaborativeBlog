using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace UP3_Library
{
    /// <summary>
    /// create set of points on plane
    /// </summary>
    public class SetPooints
    {
        private List<Point> points = new List<Point>();
        /// <summary>
        /// add to points list
        /// </summary>
        /// <param name="pt"></param>
        public void Add(Point pt)
        {
            points.Add(pt);
        }
        /// <summary>
        /// count point out of circle
        /// </summary>
        /// <returns>int count</returns>
        public int CountPointOutOfCircle()
        {
            int count = 0;
            double radius = 2;
            double XRadius = points.Last().XCoordinate;
            double YRadius = points.Last().YCoordinate;
            foreach (var i in points)
            {
                if (!(Math.Pow((i.XCoordinate - XRadius), 2) + Math.Pow((i.YCoordinate - YRadius), 2) <= Math.Pow(radius, 2)))
                {
                    count++;
                }
            }
            return count;
        }
        /// <summary>
        /// Two triangles with  equals erias
        /// </summary>
        /// <returns>bool type</returns>
        public bool IsTwoTrianglesWithEqualsErias()
        {
            List<double> SetOfSquares = ListSquaresAllTriangels();
            for (int i = 0; i < SetOfSquares.Count - 1; i++)
            {
                for (int j = i + 1; j < SetOfSquares.Count; j++)
                {
                    if (SetOfSquares[i] == SetOfSquares[j])
                        return true;
                }
            }
            return false;
        }
        /// <summary>
        /// squares all triangels
        /// </summary>
        /// <returns>list<double></double></returns>
        private List<double> ListSquaresAllTriangels()
        {
            List<double> SetOfSquares = new List<double>();
            for (int i = 0; i < points.Count; i++)
            {
                for (int j = i + 1; j < points.Count; j++)
                {
                    for (int k = j + 1; k < points.Count; k++)
                    {
                        double s = CountArea(points, i, j, k);
                        SetOfSquares.Add(s);
                    }
                }
            }
            return SetOfSquares;
        }
        //public double CountArea(int i, int j, int k)
        //{
        //    return 1 / 2d * Math.Abs((points[i].XCoordinate - points[k].XCoordinate) * (points[j].YCoordinate - points[k].YCoordinate) -
        //                    (points[i].YCoordinate - points[k].YCoordinate) * (points[j].XCoordinate - points[k].XCoordinate));
        //}

        public double CountArea(List<Point> points, int i, int j, int k)
        {
            return 1 / 2d * Math.Abs((points[i].XCoordinate - points[k].XCoordinate) * (points[j].YCoordinate - points[k].YCoordinate) -
                  (points[i].YCoordinate - points[k].YCoordinate) * (points[j].XCoordinate - points[k].XCoordinate));
        }

        public void Output()
        {
            foreach (var i in points)
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
            return points.Count + points.Count;
        }

    }
}
