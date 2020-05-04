// нажатия клавиш - вызывающих специализированные команды консоли
using System;
using System.Collections;
using System.Linq;
using System.Threading;
using System.Threading.Tasks;
using test;

namespace ConsoleApplication1
{
    class compare 
    {

        public static void Main()
        {
            FactorialAsync();   // вызов асинхронного метода

            Console.Read();
        }

        static void Factorial()
        {
            int result = 1;
            for (int i = 1; i <= 6; i++)
            {
                result *= i;
            }
            Thread.Sleep(2000);
            Console.WriteLine($"Факториал равен {result}");
        }
        // определение асинхронного метода
        static async void FactorialAsync()
        {
            Console.WriteLine("Начало метода FactorialAsync"); // выполняется синхронно
            await Task.Run(() => Factorial());                // выполняется асинхронно
            Console.WriteLine("Конец метода FactorialAsync");
        }
    }
}