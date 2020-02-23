using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Home3
{
    class Program
    {
        public delegate void MyDelegate();
        public event MyDelegate Event;
        static void Main(string[] args)
        {
            #region delegate
            //MyDelegate myDelegate = Method1;
            //myDelegate += Method4;
            //Action action = Method1;    
            //action();
            //Predicate<int> predicate;
            #endregion
            Person person = new Person
            {
                Name = "Ivan"
            };
            person.GoToWork += Person_GoToWork;
            person.GoToSleep += Person_GoToSleep;
            person.TakeTime(DateTime.Parse("26.01.2019 21:13:22"));
            person.TakeTime(DateTime.Parse("26.01.2019 4:13:22"));

        }

        private static void Person_GoToWork(object sender, EventArgs e)
        {
            if (sender is Person)
            {
                Console.WriteLine($"{((Person)(sender)).Name}  Go to work");
            }
        }

        private static void Person_GoToSleep()
        {
            Console.WriteLine("go to sleep");
        }

        public static void Method1()
        {
            Console.WriteLine("Method1");
        }
        public static int Method2()
        {
            Console.WriteLine("Method2");
            return 0;
        }
        public static void Method3(int i)
        {
            Console.WriteLine("Method3" 
        }
        public static void Method4()
        {
            Console.WriteLine("Method4");
        }

    }
}
