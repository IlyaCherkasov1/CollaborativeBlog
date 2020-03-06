using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClassLibraryUP8
{
    /// <summary>
    /// create class of house
    /// </summary>
    /// <typeparam name="T"></typeparam>
    class House<T> : ICreate<T> where T : Building, new()
    {
        /// <summary>
        /// buid constracter
        /// </summary>
        /// <returns></returns>
        public T Build()
        {
            T building = new T();
            building.Area = 100;
            building.Price = 50;
            building.Address = "50 years";
            return building;
        }
    }
}
