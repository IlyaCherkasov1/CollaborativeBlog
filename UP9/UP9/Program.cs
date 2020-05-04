using LibraryUP9;
using System.Collections.Generic;
using System;

namespace UP9
{
    class Program
    {
        static void Main(string[] args)
        {
            Student st = new Student("Vasya",17,new[] { 1, 2, 3, 4 });
            Student st1 = new Student("Ivan", 23, new[] { 9,6,5,7 });
            Student[] students = new Student[] { st, st1 };
            Session session = new Session(students);
            Console.WriteLine(string.Join("\n", session.AvverageMarkOfStudents()));
            Console.WriteLine(session.GeneralAvverageMark());
            Console.WriteLine();
            Teacher tc = new Teacher("1", 16);
            HeadOfDepartment hod = new HeadOfDepartment("name", 44);
            Person[] ps = new Person[] { st, tc, hod };
            for (int i = 0; i < ps.Length; i++)
            {
                ps[i].Display();
            }
            List<IDisplay> displays = new List<IDisplay>();
            displays.Add(st);
            displays.Add(tc);
            displays.Add(hod);
            displays.ForEach(x => x.Display());

            int number1 = 3000;
            int number2 = 0;
            try
            {
                Console.WriteLine(number1 / number2);
            }
            catch (DivideByZeroException)
            {
                Console.WriteLine("Division of {0} by zero.", number1);
            }
        }
    }
}
