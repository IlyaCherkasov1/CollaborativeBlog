using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;
using ClassLibraryUP8;

namespace UP8
{
    class Program
    {
        static void Main(string[] args)
        {

            Console.WriteLine("1.Task1");
            Console.WriteLine("2.Напечатать фамилии всех военнообязанных сотрудников");
            Console.WriteLine("3.Сравнить два момента времени");
            Console.WriteLine("4.Опирации усножения и деления");
            while (true)
            {
                string a = Console.ReadLine();
            switch (a)
               {
                  case "1":
                        Castle ct = new Castle(130, 50, "Мальдивы");
                        Console.WriteLine(ct);
                        ct.PayR();
                        ((IPay)ct).Pay();
                        ct.Pay();
                        break;
                    case "2":
                        var Empl = new Employee[5];
                        string[] data = File.ReadAllLines("dataEmployee.txt");
                        int k = 0;
                        for (int i = 0; i < Empl.Length; i++)
                        {
                            Empl[i] = new Employee(data[k], data[k + 1]);
                            k += 2;
                        }
                        foreach (var i in OutputNotServed(Empl))
                            Console.WriteLine(i);
                        break;
                    case "3":
                        var moment = new MomentOfTime[5];
                        int[][] day = File.ReadAllLines("dayInfo.txt")
                        .Select(x => x.Split(new char[] { ' ' }, StringSplitOptions.RemoveEmptyEntries).
                        Select(y => Int32.Parse(y)).ToArray()).ToArray();

                        int c = 0;
                        for (int i = 0; i < moment.Length; i++)
                        {
                            moment[i] = new MomentOfTime(day[i][0], day[i][1], day[i][2]);

                        }
                        Comparer<MomentOfTime> mt = Comparer<MomentOfTime>.Default;
                        int z = mt.Compare(moment[3], moment[4]);
                        if (z < -1)
                        Console.WriteLine("Первый меньше");
                        if (z < 1)
                            Console.WriteLine("Первый больше");
                        if (z == 0)
                            Console.WriteLine("Они равны");
                      //  MomentOfTime moment1 = (MomentOfTime)moment.Clone();
                        break;
                    case "4":
                        Numbers nb = new Numbers();
                        Console.WriteLine(nb.Division(12, 4));
                        Console.WriteLine(nb.Multiple(3, 4));
                        break;
                }
                

            }

        }

        private static List<string> OutputNotServed(Employee[] Empl)
        {
            List<string> ls = new List<string>();
            for (int i = 0; i < Empl.Length; i++)
            {
                if (Empl[i].Service == "не служил")
                {
                    ls.Add(Empl[i].Surname);
                }
            }
            return ls;
        }
    }
}
