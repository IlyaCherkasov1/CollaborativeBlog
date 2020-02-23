using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DZ_oper__
{
    class Program
    {
        static void Main(string[] args)
        {
            Count co = new Count { Value = 0 };
            co.krantThree += krantThree;
            co.krantFive += krantFive;
            for (int i = 0; i < 10; i++)
                ++co.Value;
        }


        public static void krantThree(object sender, SetValue e)
        {
            Count sen = (Count)sender;
            Console.WriteLine($"{e.Value} кратно 3");

        }

        public static void krantFive(object sender, SetValue e)
        {
            Count sen = (Count)sender;
            Console.WriteLine($"{e.Value} кратно 5");
        }

    }
}
