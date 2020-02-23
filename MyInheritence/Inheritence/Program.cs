using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Inheritence
{
    class Program
    {
        static void Main(string[] args)
        {
            GeometricFigure[] figures = new GeometricFigure[3];
            figures[0] = new GeometricFigure();
            figures[1] = new Circle(5);
            figures[2] = new Square(10);
            foreach (var figure in figures)
            {
                figure.PrintSquare();
                Console.ReadKey();
            }
        }
    }
}
