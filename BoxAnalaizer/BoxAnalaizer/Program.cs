using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BoxAnalaizer
{
    class Program
    {
        static void Main(string[] args)
        {
            BoxAnalizer boxAnalizer = new BoxAnalizer();
            Console.WriteLine(boxAnalizer.GetAllWeigth());
            Console.WriteLine(boxAnalizer.PopularName());
            Console.WriteLine();
            boxAnalizer.PrintAllWeightFromName();
        }
    }
}
