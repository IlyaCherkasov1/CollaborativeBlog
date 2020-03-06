using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _9_2
{
    public enum postEnum
    {
        programmer,
        designer,
        tester,
        Manager,
        Director
    }


    struct Employee
    {
        public string name;
        public string surname;
        public string middleName;
      
        public postEnum Post;
        public int year;
        public int salary;
        public Employee(string n, string s, string mN, postEnum post, int y, int sa)
        {
            name = n;
            surname = s;
            middleName = mN;
            this.Post = post;
            year = y;
            salary = sa;
        }
        public void DisplayInfo()
        {
            Console.WriteLine($"name={name} surname = {surname}  middleName = { middleName} " +
                $" Post= {Post}  year={year}  salary={ salary} ");
        }
    }
}
