using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ClassLibraryUP10;

namespace UP10
{
    delegate void Del(int n, ABC aBC);
    delegate void Mydelegate(ABCEventArgs abcargs);
    class Program
    {
        static public event Mydelegate onMenu;
        static void Main(string[] args)
        {
            Del allAction = AddN;   
            allAction += SwapNCount;
            onMenu += action;
            Console.WriteLine("1- all 2 - select?");
            var select = Console.ReadLine();
            ABC abc = new ABC();
            switch (select) {
                case "1":
                    ABCEventArgs aBCEventArgs1 = new ABCEventArgs(abc, true); // true or false спрашивать у пользователя
                    onMenu?.Invoke(aBCEventArgs1);
                    allAction(5, aBCEventArgs1.Abc);
                    break;
                case "2":
                    Console.WriteLine("1 - add, 2 - swap?");
                    var sel = int.Parse(Console.ReadLine());
                    ABCEventArgs aBCEventArgs2 = new ABCEventArgs(abc, false);
                    onMenu?.Invoke(aBCEventArgs2);
                    allAction.GetInvocationList()[sel].DynamicInvoke(5, abc);
                    break;
            }
        }

        private static void action(ABCEventArgs e)
        {
            if (e.Confirm)
                e.Abc = Swap(e.Abc);
        }

        static void AddN(int n, ABC aBC)
        {
            aBC.A += n;
            aBC.B += n;
            aBC.C += n;
            Console.WriteLine(aBC);
        }

       static void SwapNCount(int n, ABC aBC)
        {
            for (int i = 0; i < n; i++)
            {
                aBC = Swap(aBC);
            }
            Console.WriteLine(aBC);
        }

        static private ABC Swap(ABC aBC) => new ABC(aBC.B, aBC.C, aBC.A);
    }
}
