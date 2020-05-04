using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LibraryUP9
{
  public  class Teacher : Person, IComparer<Teacher>,IDisplay
    {
        public Teacher(string name, int years) : base(name, years)
        {
        }

        public int Compare(Teacher t1, Teacher t2)
        {
            if (t1.Name.Length > t2.Name.Length)
                return 1;
            else if (t1.Name.Length < t2.Name.Length)
                return -1;
            else
                return 0;
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
            return obj is Teacher teacher &&
                   Name == teacher.Name &&
                   Years == teacher.Years;
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
