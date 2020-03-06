using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClassLibraryUP8
{
    /// <summary>
    /// calculation interface
    /// </summary>
   public interface ICalsulation
    {
        /// <summary>
        /// main property
        /// </summary>
        /// <param name="x"></param>
        /// <param name="y"></param>
        /// <returns></returns>
        int Multiple(int x, int y);
        int Division(int x, int y);
    }
}
