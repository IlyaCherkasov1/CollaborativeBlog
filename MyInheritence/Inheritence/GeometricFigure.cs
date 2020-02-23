using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Inheritence
{
    class GeometricFigure
    {
        public virtual void PrintSquare()
        {
            Console.WriteLine("This is {0}, his square = {1}", this.GetType(),0);
        }
    }

    class Circle:GeometricFigure
    {
        int r;
        public Circle(int r) { this.r = r; }
        public override void PrintSquare()
        {
            Console.WriteLine("This is {0}, his square = {1:0.00}", this.GetType(),Math.PI*r*r);
        }
    }

    class Square:GeometricFigure
    {
        int Side;
        public Square(int Side) { this.Side = Side; }
        public override void PrintSquare()
        {
            Console.WriteLine("This is {0}, his square = {1:N2}", this.GetType(),Side * Side);
       
        }
    }
}
