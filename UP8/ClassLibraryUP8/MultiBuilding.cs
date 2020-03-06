using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClassLibraryUP8
{
    /// <summary>
    /// My class from house
    /// </summary>
    /// <typeparam name="T"></typeparam>
    class MultiBuilding<T> : ICreate<T> where T : Building, new()
    {
        /// <summary>
        /// create Multibuiding
        /// </summary>
        /// <returns></returns>
        public T Build()
        {
            T building = new T();
            building.Area = 1000;
            building.Price = 500000;
            building.Address = "near by";
            return building;
        }
    }
}
