using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClassLibraryUP8
{
    /// <summary>
    /// interface for create buiding
    /// </summary>
    /// <typeparam name="T"></typeparam>
    interface ICreate<out T> where T:Building
    {
        T Build(); 
    }
    //ковариантвность и контрваринтность
}
