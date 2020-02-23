using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace laba10._1
{
    class Elem
    {
        public string Property { get; set; }
        public Elem(string property)
        {
            Property = property;
        }
        public virtual void PrintProperty()
        {
            Console.WriteLine("Element: {0}, Element's property: {1}, his count = {2}", this.GetType(),"none", 0);
        }
    }

    class Reagent1 : Elem
    {
        private int count;
        private string property;
        public Reagent1(int count, string property) : base(property)
        {
            this.count = count;
            this.property = property;
          
        }
        public override void PrintProperty() 
        {
            Console.WriteLine("Element: {0}, Element's property: {1}, his count = {2}", this.GetType(), property, count);
        }
    }
    class Carbon1 : Elem
    {
        int count;
        private string property;
        public Carbon1(int count, string property) : base(property)
        {
            this.count = count;
            this.property = property;

        }
        public override void PrintProperty()
        {
            Console.WriteLine("Element: {0}, Element's property: {1}, his count = {2}", this.GetType(), property, count);
        }
    }
    class Iron1 : Elem
    {
        int count;
        private string property;
        public Iron1(int count, string property) : base(property)
        {
            this.count = count;
            this.property = property;
        }
        public override void PrintProperty()
        {
            Console.WriteLine("Element: {0}, Element's property: {1}, his count = {2}", this.GetType(), property, count);
        }
    }
}
