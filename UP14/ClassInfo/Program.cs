using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Reflection;

namespace ClassInfo
{
    class Program
    {
        static void Main(string[] args)
        {
            Assembly assembly = Assembly.Load("LibraryUP9");
            Console.WriteLine(assembly.FullName);
            Console.WriteLine();
            Type[] types = assembly.GetTypes();
            foreach (Type t in types)
            {
                Console.WriteLine(t.FullName);
                if (t.IsAbstract)
                {
                    Console.WriteLine("класс абстрактный");
                }
                if (t.IsClass)
                {
                    Console.WriteLine("класс обычный");
                }
                Console.WriteLine("базовый класс " + t.BaseType);
                MethodInfo[] mas = t.GetMethods();
                foreach (MethodInfo x in mas)
                    Console.WriteLine("Метод: " + x);
                PropertyInfo[] mas1 = t.GetProperties();
                foreach (PropertyInfo x in mas1)
                    Console.WriteLine("Свойство : " + x);
                Console.WriteLine();
            }
            Console.ReadLine();

            
        }
    }
}
