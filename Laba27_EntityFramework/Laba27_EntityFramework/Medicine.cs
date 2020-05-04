using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Laba27_EntityFramework
{
   public class Medicine
    {
        public int id { get; set; }
        public string Name { get; set; }
        public string Producer { get; set; }
        public string Substance { get; set; }

        public Medicine(int id, string name, string producer, string substance)
        {
            this.id = id;
            Name = name;
            Producer = producer;
            Substance = substance;
        }
        public Medicine()
        {

        }
    }
}
