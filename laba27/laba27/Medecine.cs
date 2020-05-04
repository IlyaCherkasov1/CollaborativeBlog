using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace laba27
{
   public class Medecine
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public string Producer { get; set; }
        public string Substance { get; set; }

        public Medecine(string name, string producer, string substance,int id)
        {
            Id = id;
            Name = name;
            Producer = producer;
            Substance = substance;
        }
    
    }
}
