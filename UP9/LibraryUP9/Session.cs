using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LibraryUP9
{
    public class Session
    {
        Student[] students;
        public Session(Student[] students)
        {
            this.students = new Student[students.Length];
            Array.Copy(students, this.students, students.Length);
        }

        public List<double> AvverageMarkOfStudents()
        {
            List<double> marks = new List<double>();
            for (int i = 0; i < students.Length; i++)
            {
                marks.Add(
                    Math.Round(students[i].Marks.Select(x => x).Average() * 100) /100
                    );
            }
            return marks;
        }

        public double GeneralAvverageMark()
        {
            double marks = 0; ;
            for (int i = 0; i < students.Length; i++)
            {
                marks+= students[i].Marks.Select(x => x).Average();
            }
            return Math.Round(marks / students.Length * 100) / 100;
        }

    }
}
