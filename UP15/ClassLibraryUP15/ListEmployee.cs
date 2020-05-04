using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;

namespace ClassLibraryUP15
{
    public class ListEmployee
    {
        List<Employee> employees = new List<Employee> { };
        string[] temp = new string[] { };
        public ListEmployee(string path)
        {
            using (StreamReader sr = new StreamReader(path))
            {
                while (!sr.EndOfStream)
                {
                    temp = sr.ReadLine().Split(new[] { ' ' }).ToArray();
                    employees.Add(new Employee(
                    temp[0],
                    Int32.Parse(temp[1]),
                    temp[2],
                    Int32.Parse(temp[3]),
                    Int32.Parse(temp[4])
                    ));
                }
            };
        }

        public void SalaryLowGiven(int salary, string path)
        {
            List<Employee> orderEmployees = employees.OrderBy(x => x.Experience).ToList();
            using (StreamWriter sw = new StreamWriter(path, true, Encoding.Default))
            {

            foreach (var employee in orderEmployees)
            {
                if (employee.Salary < salary)
                {
                   sw.WriteLine(employee);
                }
            }
                sw.WriteLine();
            }

        }



        public void OutputEmployee()
        {

            foreach (var employee in employees)
            {
                Console.WriteLine(employee);
            }
        }
    }
}
