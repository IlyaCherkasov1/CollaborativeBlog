using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BoxAnalaizer
{
    struct Box
    {
        public Box(int weight, InBox name)
        {
            this.Weight = weight;
            this.Name = name;
        }

        public int Weight { get; set; }
        public InBox Name { get; set; }
        public override string ToString()
        {
            return $"Имя: {Name} Вес:{Weight}";
        }
    }
}
