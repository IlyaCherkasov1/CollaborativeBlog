using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;
using ClassLibraryUP14;

namespace Аttributes
{
    class Program
    {
        static void Main(string[] args)
        {
            Animal animal = new Animal("Name", "pet", 15);
            Console.WriteLine("Проверка заглавной буквы имени" + ValidationName(animal));
            Console.WriteLine("Проверка положительного веса" + ValidationWeight(animal));
            Console.WriteLine("Проверка существующего вида"  + ValidationKids(animal));
        }

        static bool ValidationWeight(Animal animal)
        {
            Type t = typeof(Animal);
            object[] attrs = t.GetCustomAttributes(false);
            for (int i = 0; i < attrs.Length; i++)
            {
                if (attrs[i] is WeightValidationAttribute)
                {
                    if (animal.Weight >= (attrs[i] as WeightValidationAttribute).Weight) return true;
                       else return false;
                }
            }
            return true;
        }

        static bool ValidationKids(Animal animal)
        {

            Type t = typeof(Animal);
            object[] attrs = t.GetCustomAttributes(false);
            for (int i = 0; i < attrs.Length; i++)
            {
                if (attrs[i] is KindValidationAttribute)
                {
                        if ((attrs[i] as KindValidationAttribute).KindOfAnimal.Contains(animal.KindOfAnimal)) return true;
                        else return false;
                }
            }
            return true;
    
        }

        static bool ValidationName<T>(T obj)
        {
            return
                typeof(T).GetFields(BindingFlags.NonPublic | BindingFlags.Static).
                Where(fi => fi.GetCustomAttributes(typeof(NameValidationAttribute), false).Length > 0).
                Select(fi => fi.GetValue(null) as Predicate<T>).
                Where(predicate => predicate != null).
                Aggregate(true, (seed, predicate) => seed && predicate(obj));
        }
    }
}
