using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Collections;


namespace ClassLibrary1
{/// <summary>
/// mass of Point
/// </summary>
  public  class PointArray :IEnumerable,ICloneable
    {
        public Point[] mas;
        private int m=0;
        /// <summary>
        /// default constructor
        /// </summary>
        public PointArray()
        {
            mas = new Point[6];
        }
        /// <summary>
        /// method add to array
        /// </summary>
        /// <param name="a"></param>
        public void Add(Point a)
        {
            mas[m] = a;
            m++;
        }
        /// <summary>
        /// output array
        /// </summary>
        /// <returns></returns>
        public IEnumerator GetEnumerator()
        {
            for (int i = 0; i < mas.Length; i++) yield return mas[i];
        }
        /// <summary>
        /// all clone
        /// </summary>
        /// <returns></returns>
        public object Clone()
        {
            return new PointArray();
        }
        /// <summary>
        /// shalow clone
        /// </summary>
        /// <returns></returns>
        public PointArray ShallowClone()               
        {
            return (PointArray)this.MemberwiseClone();
        }
        /// <summary>
        /// every third element
        /// </summary>
        /// <returns></returns>
        public IEnumerable MyWrite()                 
        {
            for (int i = 1; i < mas.Length; i++)
            {

                if (i % 3 == 0)
                {
                    yield return mas[i];
                }
               
            }

        }

    }
}
