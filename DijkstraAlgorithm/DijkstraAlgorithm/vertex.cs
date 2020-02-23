using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DijkstraAlgorithm
{
   public class Vertex
    {

        public Vertex(int number)
        {
            Number = number;
        }

        public int Number { get; set; }
        public override string ToString()
        {
            return Number.ToString();
        }
    }
}
