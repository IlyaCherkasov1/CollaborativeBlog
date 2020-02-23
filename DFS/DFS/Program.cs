using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DFS
{
    class Program
    {
        static void Main(string[] args)
        {
            var n01 = new Node("01");
            var n02 = new Node("02");
            var n03 = new Node("03");
            var n04 = new Node("04");
            var n05 = new Node("05");
            var n06 = new Node("06");
            var n07 = new Node("07");
            var n08 = new Node("08");
            var n09 = new Node("09");
            var n10 = new Node("10");
            var n11 = new Node("11");
            var n12 = new Node("12");
            var n13 = new Node("13");
            var n14 = new Node("14");
            var n15 = new Node("15");
            n01.AddChildren(n02).AddChildren(n03);
            n02.AddChildren(n05);
            n03.AddChildren(n04);
            n04.AddChildren(n05, false).AddChildren(n10, false).AddChildren(n11, false);
            n06.AddChildren(n01, false);
            n07.AddChildren(n03, false).AddChildren(n08);
            n09.AddChildren(n08).AddChildren(n10);
            n11.AddChildren(n12).AddChildren(n13);
            n12.AddChildren(n13);
            n14.AddChildren(n15);
            var search = new DepthFirstSearch();
            var path = search.DFS(n06, n10);
            PrintPath(path); // 06 -> 01 -> 03 -> 04 -> 10
            var path1 = search.DFS(n06, n14);
            PrintPath(path1); // You shall not pass!
        }
        private static void PrintPath(LinkedList<Node> path)
        {
            Console.WriteLine();
            if (path.Count == 0)
            {
                Console.WriteLine("You shall not pass!");
            }
            else
            {
                Console.WriteLine(string.Join(" -> ", path.Select(x => x.Name)));
            }
            Console.Read();
        }
    }
}
