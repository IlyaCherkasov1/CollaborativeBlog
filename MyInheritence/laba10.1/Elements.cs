using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace laba10._1
{
    class Elements
    {
        public virtual void PrintProperty()
        {
            Console.WriteLine("This is {0}, Element's property: {1}, his count = {2}", this.GetType(),"none", 0);
        }
    }

    class Reagent:Elements
    {
        int count;
        public Reagent(int count) { this.count = count; }
        public override void PrintProperty()
        {
            Console.WriteLine("Element's property: {0}, Element's property: {1}, his count = {2}", this.GetType(), "non", count);
        }

    }
    class Carbon : Elements
    {
        int count;
        public Carbon(int count) { this.count = count; }
        public override void PrintProperty()
        {
            Console.WriteLine("Element's property: {0}, Element's property: {1}, his count = {2}", this.GetType(), "crystal cell", count);
        }
    }
    class Iron:Elements
    {
        int count;
        public Iron(int count) { this.count = count; }
        public override void PrintProperty()
        {
            Console.WriteLine("Element's property: {0}, Element's property: {1}, his count = {2}", this.GetType(), "output frequency", count);
        }
    }

}

