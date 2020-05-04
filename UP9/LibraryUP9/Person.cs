using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LibraryUP9
{
    public abstract class Person:IDisplay
    {
        public string Name { get; set; }
        public int Years { get; set; }

        public Person(string name, int years)
        {
            Name = name;
            Years = years;
        }

        public virtual void Display()
        {
            Console.WriteLine($"name = {Name}");
        }

        public virtual void Move()
        {
            Console.WriteLine("двигаюсь");
        }

        public override bool Equals(object obj)
        {
            return obj is Person person &&
                   Name == person.Name &&
                   Years == person.Years;
        }

        public override int GetHashCode()
        {
            var hashCode = 327340627;
            hashCode = hashCode * -1521134295 + EqualityComparer<string>.Default.GetHashCode(Name);
            hashCode = hashCode * -1521134295 + Years.GetHashCode();
            return hashCode;
        }

        public override string ToString()
        {
            return $"name = {Name}".ToString();
        }
    }
}
