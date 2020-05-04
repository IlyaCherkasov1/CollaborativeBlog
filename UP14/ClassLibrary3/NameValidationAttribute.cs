using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClassLibraryUP14
{
    [AttributeUsage(AttributeTargets.Field)]
     public class NameValidationAttribute:Attribute
    {
        public NameValidationAttribute()
        {

        }


    }
}
