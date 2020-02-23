using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace laba10._1
{
    class NewEl
    {
        public string Property { get; set; }
        public virtual void PrintProperty()
        {
            Console.WriteLine("Element: {0}, Element's property: {1}, his count = {2}", this.GetType(), "none", 0);
        }
    }

    class Reagent2 : NewEl
    {
        private int count;
        private string property;
        public Reagent2(int count, string property) 
        {
            this.count = count;
            this.property = property;

        }
        public new void PrintProperty()
        {
            Console.WriteLine("Element: {0}, Element's property: {1}, his count = {2}", this.GetType(), property, count);
        }
    }
    class Carbon2 : NewEl
    {
        int count;
        private string property;
        public Carbon2(int count, string property) 
        {
            this.count = count;
            this.property = property;

        }
        public new void PrintProperty()
        {
            Console.WriteLine("Element: {0}, Element's property: {1}, his count = {2}", this.GetType(), property, count);
        }
    }
    class Iron2 : NewEl
    {
        int count;
        private string property;
        public Iron2(int count, string property) 
        {
            this.count = count;
            this.property = property;
        }
        public new void PrintProperty()
        {
            Console.WriteLine("Element: {0}, Element's property: {1}, his count = {2}", this.GetType(), property, count);
        }
    }
}
