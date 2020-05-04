using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using LibraryUP10;

namespace UP10
{
    delegate void Del(int n, List<int> ls);
    delegate void MyDelegate(ListEventArgs lsargs);

    class Program
    {
        static public event MyDelegate onMenu;
        static void Main(string[] args)
        {
            List<int> ls = new List<int> { 1, 2, 3, 4, 5, 6 };
            Console.WriteLine("исходный массив " + (string.Join(" ", ls)));
            Del allAction = AddElement;
            allAction += HalvElement;
            allAction += ChangePlace;
            onMenu += action;
            Console.WriteLine("1.Вызов всех методов");
            Console.WriteLine("2.Выбрать метод");
            Console.WriteLine("3.Добавление 1 к цифре после каждой четной цифры");
            var select = Console.ReadLine();
            bool b;
            bool b1;
            switch (select)
            {
                case "1":
                    Console.WriteLine("вызвать событие 1 - yes ? no");
                    var trueEvent = Console.ReadLine();
                    if (trueEvent == "yes")
                    {
                        b = true;
                    }
                    else
                    {
                        b = false;
                    }
                    ListEventArgs lsargs = new ListEventArgs(ls, b);
                    if (lsargs.Confirm)
                    onMenu?.Invoke(lsargs);
                    allAction(3, ls);
                    break;
                case "2":
                    Console.WriteLine("1. Add element");
                    Console.WriteLine("2. Halve element");
                    Console.WriteLine("3. Change place");
                    var sel = int.Parse(Console.ReadLine());
                    Console.WriteLine("вызвать событие 1 - yes ? no");
                    var trueEvent1 = Console.ReadLine();
                    if (trueEvent1 == "yes")
                    {
                        b1 = true;
                    }
                    else
                    {
                        b1 = false;
                    }
                    ListEventArgs lsargs2 = new ListEventArgs(ls, b1);
                    if(lsargs2.Confirm)
                    onMenu?.Invoke(lsargs2);
                    allAction.GetInvocationList()[sel-1].DynamicInvoke(3, ls);
                    break;

                case "3":
                    Console.WriteLine("введите коллекцию чисел");
                    string colect = Console.ReadLine();
                    List<string> list = colect.Split(new[] { ' ' }, StringSplitOptions.RemoveEmptyEntries).ToList();
                    List<int> list1 = list.Select(x => int.Parse(x)).ToList();
                    ThreadCollection tc = new ThreadCollection(list1);
                    Console.WriteLine(tc);
                    tc.AddAfterAllEvenDigit();
                    tc.AddRandomElement();
                    tc.Factorial();
                    Console.Read();
      
                    break;
            }
        }

        private static void action(ListEventArgs e)
        {
            if (e.Confirm)
                e.Ls = DoubleItems(e.Ls);
        }

        static List<int> DoubleItems(List<int> ls)
        {
            for (int i = 0; i < ls.Count; i++)
            {
                ls[i] = ls[i] * ls[i];
            }
            return ls;
        }

        static void AddElement(int n, List<int> ls)
        {
            for (int i = 0; i < ls.Count; i++)
            {
                if (ls[i] % 3 == 0)
                {
                    ls.Insert(i+1, 0);
                    i++;
                }
            }
            Console.WriteLine(string.Join(" ", ls)); 
       
        }

        static void HalvElement(int n, List<int> ls)
        {
            for (int i = 0; i < ls.Count; i++)
            {
                ls[i] /= 2;
            }
            Console.WriteLine(string.Join(" ", ls));

        }

        static void ChangePlace(int n, List<int> ls)
        {
            int buf = ls[ls.Count-1];
            ls[ls.Count-1] = ls[n];
            Console.WriteLine(string.Join(" ", ls));
        }
    }
}
