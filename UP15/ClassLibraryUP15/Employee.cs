using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClassLibraryUP15
{
    public struct Employee : IComparable<Employee>
    {
        public Employee(string name, int year, string post, int salary, int experience)
        {
            Name = name;
            Year = year;
            Post = post;
            Salary = salary;
            Experience = experience;
        }

        public string Name { get; set; }
        public int Year { get; set; }
        public string Post { get; set; }
        public int Salary { get; set; }
        public int Experience { get; set; }

        public int CompareTo(Employee obj)
        {
            return this.Experience.CompareTo(obj.Experience);
        }

        public override string ToString()
        {
            return $"Name = {Name}, Year = {Year}, Post = {Post}, Salary = {Salary}, Experience = {Experience}".ToString();
        }
    }
}
