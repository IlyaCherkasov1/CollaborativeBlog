using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LibraryUP9
{
   public class HeadOfDepartment : Person, IComparable<HeadOfDepartment>,IDisplay
    {
        public HeadOfDepartment(string name, int years) : base(name, years)
        {
        }

        public int CompareTo(HeadOfDepartment other)
        {
            return this.Name.CompareTo(other.Name);
        }

        public override void Display()
        {
            Console.WriteLine($"Name = {Name} Year = {Years}");
        }

        public override void Move()
        {
            base.Move();
        }


        public override bool Equals(object obj)
        {
            return obj is HeadOfDepartment headOfDepartment &&
                   Name == headOfDepartment.Name &&
                   Years == headOfDepartment.Years;
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
            return $"Name = {Name} Year = {Years}".ToString();
        }
    }
}
