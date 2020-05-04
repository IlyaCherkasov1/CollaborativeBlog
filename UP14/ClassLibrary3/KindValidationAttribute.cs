using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClassLibraryUP14
{
    public class KindValidationAttribute : Attribute
    {
        public string[] KindOfAnimal { get; set; }
        public KindValidationAttribute(params string[] kindOfAnimal)
        {
            KindOfAnimal = kindOfAnimal;
        }
    }
}
