using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _6__
{
    class Program
    {
        public static void Main(string[] args)
        {
            Console.WriteLine("1 - Значения по умолчанию (2)" );
            Console.WriteLine(" 2 - Ввод значений в ручную (2)");
            Console.WriteLine("3 - Значения по умолчанию (10)");
            Console.WriteLine("4 - Ввод значений в ручную(10)"); 
            int k = Convert.ToInt32(Console.ReadLine());
            Variant(k);
        }

        private static void Variant(int k)
        {
            int category = 0;
            int limitMax = 0;
            if (k == 1 || k == 2)
            {
                limitMax = 32767;
                //91235 16 1
            }
            if (k == 3 || k == 4)
            {
                limitMax = 999999;
            }
            Counter i = new Counter(1, limitMax);
            if (k >= 1 && k <= 4)
            {
                if (k == 1 || k == 2)
                {
                    category = 2;
                }
                if (k == 3 || k == 4)
                {
                    category = 10;
                }

                if (k == 2 || k == 4)
                {
                    Console.WriteLine("Введите первое значение: ");
                    int number1 = Convert.ToInt32(Console.ReadLine());
                    Counter cn = new Counter(number1, limitMax);
                    cn.ShowCount(category);
                    //cn.CountUp(); метод ++
                    cn = cn + i; //операция +
                    cn.ShowCount(category);
                    Console.WriteLine("Введите второе значение: ");
                    int number2 = Convert.ToInt32(Console.ReadLine());
                    cn = new Counter(number2, limitMax);
                    cn.ShowCount(category);
                    //cn.CountDown(); //метод —
                    cn = cn - i; //операция -
                    cn.ShowCount(category);
                    Console.ReadKey();
                }
                if (k == 1 || k == 3)
                {
                    Counter cn = new Counter(100, limitMax);
                    cn.ShowCount(category);
                    //cn.CountUp(); метод ++
                    cn = cn + i; //операция +
                    cn.ShowCount(category);
                    cn = new Counter(32767, limitMax);
                    cn.ShowCount(category);
                    //cn.CountDown(); //метод —
                    cn = cn - i; //операция -
                    cn.ShowCount(category);
                    Console.ReadKey();
                }
            }
            else
            {
                Console.WriteLine("Такого варианта нет");
                Console.ReadKey();
            }
        }
    }

}
           
        


