using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace laba16_Chain
{
    /// <summary>
    /// create matrix
    /// </summary>
    class Matrix
    {
        int[][] numbers = new int[4][];
        /// <summary>
        /// default constructor
        /// </summary>
        public Matrix()
        {
            numbers[0] = new int[] { 3, 2 };
            numbers[1] = new int[] { 1, 2, 3 };
            numbers[2] = new int[] { 1, -2, -3, 4, 5 };
            numbers[3] = new int[] { 5, 1, -9, 4, 2, 8 }; 
        }
        /// <summary>
        /// substracy the smaller element
        /// </summary>
        /// <returns></returns>
        public Matrix SubstractTheSmallerElement()
        {
            numbers = numbers.Select(x => x.Select(y => y - x.Min()).ToArray()).ToArray();
            return this;
        }
        /// <summary>
        /// Sort lines
        /// </summary>
        /// <returns></returns>
        public Matrix SortLines()
        {
            numbers = numbers.OrderBy(x => x.Where(y => y % 3 == 0).Sum()).ToArray();
            return this;
        }
        /// <summary>
        /// insert Dublicate
        /// </summary>
        public Matrix InsertDublicate()
        {
            List<int[]> ls1 = new List<int[]>(numbers);
            ls1 = numbers.ToList();

            List<int[]> ls2 = new List<int[]>();
            ls2 = ls2.ToList();

            List<int> buf = new List<int>();

            for (int i = 0; i < ls1.Count; i++)
            {
                for (int j = 0; j < ls1[i].Count(); j++)
                {
                    buf.Add(ls1[i][j]);
                }
                ls2.Add(buf.ToArray());
                ls2.Add(buf.ToArray());
                buf.Clear();
            }

            foreach (var i in ls2)
            {
                Console.WriteLine(string.Join(" ", i));
            }
            return this;

        }
        

        public void Output()
        {
            foreach (var i in numbers)
            {
                Console.WriteLine(string.Join(" ", i));
            }
        }
    }
}
