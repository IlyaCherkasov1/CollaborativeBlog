using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Laba_4
{
    class Program
    {
        public static double plo(double a, double b, double c)
        {
            double PolPer = (a + b + c) / 2;
            return Math.Sqrt(PolPer * (PolPer - a) * (PolPer - b) * (PolPer - c));
        }
        public static void swap(ref double a, ref double b)
        {
            double c = a;
            a = b;
            b = c;
        }
        public static bool IsTriangleExist(double a, double b, double c)
        {
            if ((a + b > c) & (a + c > b) & (b + c > a))
            {
                return true;

            }
            else
                return false;
           
        }

        
        public static double sqrFun(double a)
        {
            return Math.Pow(a, 2);
        }

        static void Main(string[] args)
        {
            int i;
            do
            {
                Console.WriteLine("Введите пункт меню : ");
                Console.WriteLine("1 - Метод sqr(a,out sqt) для нахождения квадрата числа - ");
                Console.WriteLine("2 - Метод swap для вещественных чисел - ");
                Console.WriteLine("3 - Метод plo(x,y,z) для нахождения площади существующего треугольника - ");
                Console.WriteLine("4 - Метод plo(a,b,c,d) - ");
                Console.WriteLine("5 - Выход - ");
                i = Convert.ToInt32(Console.ReadLine());
                switch (i)
                {
                    case 1:
                        Console.WriteLine("Введите A : ");
                        double a = Convert.ToDouble(Console.ReadLine());
                        Console.WriteLine("Sqr = " + sqrFun(a));
                        Console.ReadKey();
                        break;
                    case 2:
                        Console.WriteLine("Введите A : ");
                        double a1 = Convert.ToDouble(Console.ReadLine());
                        Console.WriteLine("Введите B : ");
                        double b1 = Convert.ToDouble(Console.ReadLine());
                        Console.WriteLine("a={0} b={1}", a1, b1);
                        swap(ref a1, ref b1);
                        Console.WriteLine("a={0} b={1}", a1, b1);
                        Console.ReadKey();
                        break;
                    case 3:
                        Console.WriteLine("Введите X : ");
                        double x = Convert.ToDouble(Console.ReadLine());
                        Console.WriteLine("Введите Y : ");
                        double y = Convert.ToDouble(Console.ReadLine());
                        Console.WriteLine("Введите Z : ");
                        double z = Convert.ToDouble(Console.ReadLine());
                        if (IsTriangleExist(x,y,z))
                        {
                            Console.WriteLine("- Треугольник существует - ");
                            double result = plo(x, y, z);
                            Console.WriteLine("Площадь X,Y,Z равна = " + Math.Round(result, 3));
                            Console.ReadKey();
                        }
                        else
                        {
                            Console.WriteLine("- Треугольник не существует - ");
                        }
                        break;
                    case 4:
                        Console.WriteLine("Введите A : ");
                        double aa = Convert.ToDouble(Console.ReadLine());
                        Console.WriteLine("Введите B : ");
                        double bb = Convert.ToDouble(Console.ReadLine());
                        Console.WriteLine("Введите C : ");
                        double cc = Convert.ToDouble(Console.ReadLine());
                        Console.WriteLine("Введите D : ");
                        double dd = Convert.ToDouble(Console.ReadLine());

                        if (IsTriangleExist(aa, bb, cc))
                        {
                            Console.WriteLine("- Треугольник построить можно - ");
                            double result1 = plo(aa, bb, cc);
                            Console.WriteLine("Площадь A,B,C равна = " + Math.Round(result1, 3));
                        }
                        else
                        {
                            Console.WriteLine("- Треугольник построить нельзя - ");
                        }
                        if (IsTriangleExist(aa, bb, dd))
                        {
                            double result2 = plo(aa, bb, dd);
                            Console.WriteLine("Площадь A,B,D равна = " + Math.Round(result2, 3));
                        }
                        else
                        {
                            Console.WriteLine("- Треугольник построить нельзя - ");
                        }
                        if (IsTriangleExist(aa, cc, dd))
                        {
                            double result3 = plo(aa, cc, dd);
                            Console.WriteLine("Площадь A,C,D равна = " + Math.Round(result3, 3));
                        }
                        else
                        {
                            Console.WriteLine("- Треугольник построить нельзя - ");
                        }
                        if (IsTriangleExist(bb, cc, dd))
                        {
                            double result4 = plo(bb, cc, dd);
                            Console.WriteLine("Площадь B,C,D равна = " + Math.Round(result4, 3));
                        }
                        else
                        {
                            Console.WriteLine("- Треугольник построить нельзя - ");
                        }
                        break;
                }
            }
            while (i < 5);
        }
    }
}
