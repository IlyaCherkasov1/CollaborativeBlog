using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp5
{
    class Program
    {
        static void Main(string[] args)
        
            {
                Forest f = new Forest("Congo","Desert");
            Forest f2 = new Forest("Rendlesham");
            //   f.Name = "Congo";
            f.Trees = 0;
                f.age = 0;
              //  f.Biome = "Tropical";
              //  Console.WriteLine(f.Biome);
                f.Area = -1;

                Console.WriteLine(f.Name);
                Console.WriteLine(f.Biome);
            }
        }
}
