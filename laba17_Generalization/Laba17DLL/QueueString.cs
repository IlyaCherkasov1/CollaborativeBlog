using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Laba17DLL
{
    /// <summary>
    /// queue string
    /// </summary>
    public class QueueString
    {
      
        public List<string> MyQueuelist = new List<string>();
        /// <summary>
        ///default constructor
        /// </summary>
        /// <param name="Queuelist"></param>
        public QueueString(Queue<string> Queuelist)
        {
            this.MyQueuelist = Queuelist.ToList();
        }


        /// <summary>
        /// defaut equals
        /// </summary>
        /// <param name="obj"></param>
        /// <returns></returns>
        public override bool Equals(object obj)
        {
            QueueString list = obj as QueueString;
            if (list == null)
                return false;

            bool same = this.MyQueuelist.SequenceEqual(list.MyQueuelist);
            return same;
        }
        /// <summary>
        /// ooperator +
        /// </summary>
        /// <param name="obj"></param>
        /// <returns></returns>
        public static QueueString operator +(QueueString obj)
        {
            obj.MyQueuelist.AddRange(obj.MyQueuelist);
            return obj;
        }
    /// <summary>
    /// operator +
    /// </summary>
    /// <param name="obj"></param>
    /// <param name="nconst"></param>
    /// <returns></returns>
        public static QueueString operator +(QueueString obj, string nconst)
        {
            obj.MyQueuelist.Insert(0, nconst);
            return obj;
        }

        /// <summary>
        /// string indexer
        /// </summary>
        /// <param name="index"></param>
        /// <returns></returns>
        public string this[int index]
        {
            get
            {
                return MyQueuelist[index];
            }
        }
        /// <summary>
        /// ovveride toString
        /// </summary>
        /// <returns></returns>
        public override string ToString()
        {
            string answer = "";
            for (int x = 0; x < MyQueuelist.Count(); ++x)
            { answer += " " + MyQueuelist[x]; }
            return answer;
        }
    }
}
