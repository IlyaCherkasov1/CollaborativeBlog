using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LibraryUP9
{
    public class Student : Person, ICloneable,IDisplay
    {
        private int[] marks;
        public Student(string name, int years, int[] marks) : base(name, years)
        {
             this.Marks = new int[marks.Length];
             Array.Copy(marks,this.Marks, marks.Length);
        }

        public object Clone()
        {
            return this.MemberwiseClone();
        }

        public override void Display()
        {
            Console.WriteLine($"Name = {Name} Year = {Years}\n" +
                $"marks : {string.Join(" ",this.Marks)}"); 
        }

        public override void Move()
        {
            base.Move();
        }

        public override bool Equals(object obj)
        {
            return obj is Student student &&
                   base.Equals(obj) &&
                   EqualityComparer<int[]>.Default.Equals(marks, student.marks);
        }

        public override int GetHashCode()
        {
            var hashCode = -22541633;
            hashCode = hashCode * -1521134295 + base.GetHashCode();
            hashCode = hashCode * -1521134295 + EqualityComparer<int[]>.Default.GetHashCode(marks);
            return hashCode;
        }

        public override string ToString()
        {
            return $"Name = {Name} Year = {Years}\n" +
                $"marks : {string.Join(" ", this.Marks)}".ToString();
        }

        public int[] Marks { get => marks; set => marks = value; }
    }
}
