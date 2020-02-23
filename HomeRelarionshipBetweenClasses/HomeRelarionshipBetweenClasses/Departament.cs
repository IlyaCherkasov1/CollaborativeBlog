using System;
using System.Collections.Generic;
using System.Collections;

namespace HomeRelarionshipBetweenClasses 
{
    public class Departament : IEnumerable
    {
        private HashSet<Employee> employees = new HashSet<Employee>();
        private static Departament instance;
        public static Departament getInstance(string name)
        {
            if (instance == null)
            {
                instance = new Departament(name);  
            }
            return instance;
        }

        public Departament(string n)
        {
            this.Name = n;
        }


        public string Name { get; set; }
        public void addEmployee(Employee newEmployee)
        {
            employees.Add(newEmployee);
          //  newEmployee.Name = "dsf";
        }

        public IEnumerator GetEnumerator()
        {
            foreach (Employee i in employees)
            {
                yield return i.Name;
            }
        }
        public void removeEmployee(Employee e)
        {
            employees.Remove(e);
        }
 
    }
}
