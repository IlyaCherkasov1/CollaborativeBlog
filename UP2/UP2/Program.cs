using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ClassLibraryUP2;

namespace UP2
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("1.Task1");
            Console.WriteLine("2.Task2");
            Console.WriteLine("3.Task3");
            Console.WriteLine("4.Task4");
            Console.WriteLine("5.Task5");

            while (true)
            {
                int a = Convert.ToInt32(Console.ReadLine());
                switch (a) 
                {
                    case 1:
                        NumbersInSet ns = new NumbersInSet();
                        int[,] array1 = ns.WriteAllTheNumbersInTheSourceSet();
                        Console.WriteLine("source set");
                        ns.OutputArrayOfNumers();
                        Console.WriteLine("Transformed matrix:");
                        ns.OutputArray(array1);
                  
                        break;

                    case 2:
                        ClosestToAverage ca = new ClosestToAverage();
                        Console.WriteLine(ca.CalculateClosesToAverage());
                        ca.OutputArray();
                        break;
                    case 3:
                        OddNumbers on = new OddNumbers();
                        on.OutputArray();
                        on.IncreaceOddNumbers();
                        on.OutputArray();
                        break;

                    case 4:
                        MinPath mp = new MinPath();
                        mp.OutputArray();
                        mp.FindMinPath();
                        mp.OutputList();
                        break;

                    case 5:
                        break;

                    default:
                        break;
                }
                

            }

        }
    }
}
