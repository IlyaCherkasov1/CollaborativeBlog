using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClassLibraryUP14
{
    public class WeightValidationAttribute : Attribute
    {
        public int Weight { get; set; }
        public WeightValidationAttribute()
        {

        }

        public WeightValidationAttribute(int weight)
        {
            Weight = weight;
        }
    }
}
