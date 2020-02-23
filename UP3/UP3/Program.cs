using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using UP3_Library;

namespace UP3
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Initial data:");
            var sp = new SetPooints();
            sp.Add(new Point(1, 1));
            sp.Add(new Point(-15,16));
            sp.Add(new Point(13,-13));
            sp.Add(new Point(-1, -1));
            sp.Output();
            Console.WriteLine();

            Console.WriteLine("1.Points out of circle");
            Console.WriteLine("2.Check area of two triangles");
            Console.WriteLine("3.Find intersection points");
            Console.WriteLine();

            while (true)
            {
                int a =Convert.ToInt32(Console.ReadLine());
                switch (a) {
                    case 1:
                        Console.WriteLine(sp.CountPointOutOfCircle() + " point out of circle ");
                        break;
                    case 2:
                        Console.WriteLine(sp.IsTwoTrianglesWithEqualsErias());
                        break;
                    case 3:
                        Rectangle rg = new Rectangle();
                        List<double> Xcoordinates = new List<double>() { -5, -3, 2, 4 };
                        List<Point> result = rg.FindIntersectionPoints(Xcoordinates);
                        foreach (var i in result)
                        {
                            Console.WriteLine(i);
                        }
                        break;
                }

            }         
        }
    }
}
