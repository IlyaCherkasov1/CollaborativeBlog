using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Laba17DLL
{
    /// <summary>
    /// general class t
    /// </summary>
    /// <typeparam name="T"></typeparam>
   public class GeneralizedClass<T>
    {
    
        Dictionary<int, T> mydictionary;
    
        /// <summary>
        /// default constructor
        /// </summary>
        /// <param name="mas"></param>
        public GeneralizedClass(T[] mas)
        {
            this.mydictionary = new Dictionary<int, T>();
            for (int i = 0; i < mas.GetLength(0); i++)
            {
                this.mydictionary.Add(i, mas[i]);
            }
        }


     /// <summary>
     /// ind to return element
     /// </summary>
     /// <param name="index"></param>
     /// <returns></returns>
        public string this[int index]
        {
            get { return this.mydictionary[index].ToString(); }
        }
   
        /// <summary>
        /// << operator
        /// </summary>
        /// <param name="obj"></param>
        /// <param name="number"></param>
        /// <returns></returns>
        public static T operator <<(GeneralizedClass<T> obj, int number)
        {
                if (obj.GetType() == typeof(GeneralizedClass<int>))
                {
                   var d = obj.mydictionary.Where(x => (dynamic)x.Value % number == 0).Select(x=>(dynamic)x.Key).Min();
                   return d;
                                
                }
                if (obj.GetType() == typeof(GeneralizedClass<double>))
                {
                var d = obj.mydictionary.Where(x => (dynamic)x.Value % number == 0).Select(x => (dynamic)x.Key).Min();
                return d;
                }
 
            return (T)(dynamic)(number);
        }

        /// <summary>
        /// >> operator
        /// </summary>
        /// <param name="obj"></param>
        /// <param name="number"></param>
        /// <returns></returns>
        public static T operator >>(GeneralizedClass<T> obj, int number)
        {
            if (obj.GetType() == typeof(GeneralizedClass<int>))
            {
                var d = obj.mydictionary.Where(x=> IsSqr((int)x.Key)).Select(x => (dynamic)x).Max() - number;
                return d;
            }
            return (T)(dynamic)(number);
        }

        /// <summary>
        /// define sqr
        /// </summary>
        /// <param name="n"></param>
        /// <returns></returns>
        static bool IsSqr(int n)
        {
            return Math.Sqrt(n) - (int)Math.Sqrt(n) == 0;
        }

        /// <summary>
        /// public int Length
        /// </summary>
        /// <returns></returns>
        public int Length()
        {
            return mydictionary.Count();
        }

        /// <summary>
        /// output to string
        /// </summary>
        /// <returns></returns>
        public override string ToString()
        {
            string answer = "";
            foreach (KeyValuePair<int, T> keyValue in this.mydictionary)
            {
                answer += ( keyValue.Value + "\n");
            }
            return answer;
        }
    }
}
