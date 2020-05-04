using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MoreLinq;

namespace Laba17DLL
{
    /// <summary>
    /// class list int
    /// </summary>
    public class ListInt
    {
        public List<int> Mylist = new List<int>();

        public ListInt(List<int> newlist)
        {
            this.Mylist = newlist;
        }
        /// <summary>
        /// operator +
        /// </summary>
        /// <param name="obj"></param>
        /// <returns></returns>
        public static ListInt operator +(ListInt obj)
        {
            obj.Mylist.AddRange(obj.Mylist);
            return obj;
        }
         /// <summary>
         /// operator +
         /// </summary>
         /// <param name="obj"></param>
         /// <param name="nconst"></param>
         /// <returns></returns>
        public static ListInt operator +(ListInt obj, int nconst)
        {
            obj.Mylist.Insert(0, nconst);
            return obj;
        }

        /// <summary>
        /// int indexer
        /// </summary>
        /// <param name="index"></param>
        /// <returns></returns>
        public int this[int index]
        {
            get
            {
                return Mylist[index];
            }
        }
        /// <summary>
        /// output toString
        /// </summary>
        /// <returns></returns>
        public override string ToString()
        {
            string answer = "";
            for (int x = 0; x < Mylist.Count(); ++x)
            { answer += " " + Mylist[x]; }
            return answer;
        }
        /// <summary>
        /// Equals sequence
        /// </summary>
        /// <param name="obj"></param>
        /// <returns></returns>
        public override bool Equals(object obj)
        {
            ListInt list = obj as ListInt;
            if (list == null)
                return false;

            bool same = this.Mylist.SequenceEqual(list.Mylist);
            return same;
        }
    }
}
