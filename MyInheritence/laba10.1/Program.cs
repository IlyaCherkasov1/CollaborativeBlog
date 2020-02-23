using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace laba10._1
{
    class Program
    {
        static void Main(string[] args)
        {
            Elements[] el = new Elements[4];
            el[0] = new Elements();
            el[1] = new Reagent(5);
            el[2] = new Carbon(10);
            el[3] = new Iron(25);



            //foreach (var i in el)
            // {
            //   i.PrintProperty();
            //    Console.ReadKey();
            // }

            //Elem[] el1 = new Elem[4];
            //el1[0] = new Elem("none");
            //el1[1] = new Reagent1(5, "none");
            //el1[2] = new Carbon1(10, "crystal cell");
            //el1[3] = new Iron1(25, "output frequency");
            //foreach (var i in el1)
            //{
            //    i.PrintProperty();
            //    Console.ReadKey();
            //}

            NewEl[] el2 = new NewEl[4];
            el2[0] = new NewEl();
            el2[1] = new Reagent2(5, "none");
            el2[2] = new Carbon2(10, "crystal cell");
            el2[3] = new Iron2(25, "output frequency");
            foreach (var i in el2)
            {
                i.PrintProperty();
                Console.ReadKey();
            }
        }
    }
}
