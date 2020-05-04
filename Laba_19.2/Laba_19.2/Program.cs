using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace Laba_19._2
{
    class Program
    {
        static void Main(string[] args)
        {
            CancellationTokenSource cancelTokenSource = new CancellationTokenSource();
            CancellationToken token = cancelTokenSource.Token;
            Func<double, double, Test, double> F = Function;
            Test t = new Test();
            IAsyncResult result = F.BeginInvoke(0.7, 0.00001, t, AsyncCallback, t);

            Task.Run(() =>
            {
                  while (t.Progress <= 99)
                  {
                        
                      Console.Clear();
                      Console.WriteLine($"sum = {t.Sum} \nпрогресс {t.Progress}%");
                      Thread.Sleep(200);

                    if (token.IsCancellationRequested)
                    {
                        Console.WriteLine("Операция отменена");
                        return;
                    }
                }
            });

            if (Console.ReadKey().Key == ConsoleKey.Escape)
                cancelTokenSource.Cancel();

            double answer = F.EndInvoke(result);
           // Console.WriteLine("Answer = " + answer);
        }

        static void AsyncCallback(IAsyncResult result)
        {
            Test t = result.AsyncState as Test;
            Console.WriteLine($"Async Сумма {t.Sum} прогресс {t.Progress}%");
        }

 
         static double Function(double x,double delta, Test t)
         {
            double result = 0;
            double slog1 = 0;
            double slog2 = 5;
            int sign = 1;
            int i = 0;
            int k = 1;
            bool b = false;
            int allIteration = CountOperation(x, delta);
            int count = 0;
         
                while (Math.Abs((slog2) - (slog1)) >= delta)
                {
                    i++;
                    k++;
                    result += i * Math.Pow(x, i - 1) * sign;
                    slog1 = i * Math.Pow(x, i - 1) * sign;
                    if (b)
                    {
                        slog2 = k * Math.Pow(x, k - 1) * sign;
                    }
                     count++;
                     t.Progress = (count * 100) / allIteration;
                     t.Sum = result;

                     b = true;
                    sign *= -1;
                    Thread.Sleep(200);
                }

            return result;
        }


        static int CountOperation(double x, double delta)
        {

            double result = 0;
            double slog1 = 0;
            double slog2 = 5;
            int sign = 1;
            int i = 0;
            int k = 1;
            bool b = false;
            int count = 0;

            while (Math.Abs((slog2) - (slog1)) >= delta)
            {
                i++;
                k++;
                result += i * Math.Pow(x, i - 1) * sign;
                slog1 = i * Math.Pow(x, i - 1) * sign;
                if (b)
                {
                    slog2 = k * Math.Pow(x, k - 1) * sign;
                }
                b = true;
                sign *= -1;
                count++;
            }
            return count;
        }

   
    }
}
