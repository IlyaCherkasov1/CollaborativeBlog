using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClassLibraryUP8
{       
    /// <summary>
    /// class for calculate numbers
    /// </summary>
    public class Numbers : ICalsulation
    {
        /// <summary>
        /// division two number
        /// </summary>
        /// <param name="x"></param>
        /// <param name="y"></param>
        /// <returns></returns>
        public int Division(int x, int y)
        {
            return x / y;
        }
        /// <summary>
        /// multiply two number
        /// </summary>
        /// <param name="x"></param>
        /// <param name="y"></param>
        /// <returns></returns>
        public int Multiple(int x, int y)
        {
            return x * y;
        }
    }
}
