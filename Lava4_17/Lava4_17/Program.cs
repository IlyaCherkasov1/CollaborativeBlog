using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lava4_17
{
    class Program
    {
        public static double AreaCircle(double r)
        {
            return (Math.PI * Math.Pow(r, 2));
        }

        public static void SpecialSum(params int[] chislo)
        {
            int sum = 0;
            int sum1 = 0;
             int SumResult = 0;
            for (int i=0; i<chislo.Length; i++ )
            {
                if (chislo[i] % 3 == 0)
                    sum += chislo[i];
                if (chislo[i] % 2 == 0)
                    sum1 += chislo[i];
                SumResult = sum - sum1;
            }
            Console.WriteLine(SumResult);
 
        }

        public static void Stepen()
        {
            byte i;
            for (int j = 1; j < 10; j++)
            {
                i = 0;
                int result1 = 1;
                Console.WriteLine(" ");
                while (i < 10)

            {
                i++;
                result1 *= j;
                Console.WriteLine("{0}^{1}={2} ", j, i, result1);
            }
        }
        } 
        static void Main(string[] args)
        {

         Console.WriteLine("1.Вычислить площадь круга");
         Console.WriteLine("2.Нахождения суммы чисел делящихся на 3 минус сумму чисел делящихся на 2");//params
         Console.WriteLine("3.Вывести таблицу степеней числа от 2х до 9");//Не используя функцию pow и не используя двух переменных для вычисления степени





            string s;
            double r;
            int a;
           while (true)
            {
                s = Console.ReadLine();
                switch (s)
                {
                    case "1":
                        {
                            Console.Write("r=");
                            r = Convert.ToDouble(Console.ReadLine());
                            Console.WriteLine("Area=" + AreaCircle(r));

                            break;
                        }  
                  case "2":
                        {
                            Console.Write("Special sum=");
                           SpecialSum(3,4,5,9,2);
                            break;
                        }
                    case "3":
                        {
                           
                            Stepen();
                            break;
                        }
                        
                  


                }
            }
        }
    }
}
