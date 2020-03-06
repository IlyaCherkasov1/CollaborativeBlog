using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Laba18_XML
{
    [Serializable]
    public class Specialty
    {
        public string Name { get; set; }
        public uint time { get; set; }
        public Specialty()
        {

        }

        public Specialty(string name, uint time)
        {
            this.Name = name;
            this.time = time;
        }
    }
}
