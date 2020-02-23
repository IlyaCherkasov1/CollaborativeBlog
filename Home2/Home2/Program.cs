using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Home2
{
    class Program
    {
        static void Main(string[] args)
        {
            var CleaningDevice = new List<ISwitchetable>();
            CleaningDevice.Add(new VacuumCleaner());
            CleaningDevice.Add(new Iron());

            Console.WriteLine("1.On vcuum cleaner");
            Console.WriteLine("2.Off vacum cleaner");
            Console.WriteLine("3.On iron");
            Console.WriteLine("4.Off iron");
            while (true)
            {
                int result = 0;
                var input = Console.ReadLine();
                if (int.TryParse(input, out result))
                {
                }
                else
                {
                    Console.WriteLine("incorrecdt input");
                }
                switch (result) {
                    case 1:
                        if (CleaningDevice[0].IsOn()) throw new IsOnException();
                        Console.WriteLine("vacuum cleaner is " + CleaningDevice[0].On1());
                        break;
                    case 2:
                        if (CleaningDevice[0].IsOn() == false) throw new IsOffException();
                        Console.WriteLine("vacuum cleaner is " + CleaningDevice[0].Off1());
                        break;
                    case 3:
                        if (CleaningDevice[0].IsOn()) throw new IsOnException();
                        Console.WriteLine("Iron is " + CleaningDevice[1].On1());
                        break;
                    case 4:
                        if (CleaningDevice[0].IsOn() == false) throw new IsOffException();
                        Console.WriteLine("Iron is " + CleaningDevice[1].Off1());
                        break;
                }

            }
   
        }
    }
}
