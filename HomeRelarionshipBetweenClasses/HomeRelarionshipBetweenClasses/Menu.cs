using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HomeRelarionshipBetweenClasses
{
    class Menu
    {
        private static int i = 0;
        public static void showEmployees(Employee[] employees)
        {
            Console.WriteLine("Список сотрудников:");
            for (i = 0; i<employees.Length; i++)
            {
                if (employees[i] is Employee)
                {
                    Console.WriteLine(employees[i].Name + " - " + employees[i].getPosition());
                }
            }
        }
    }
}
