using System;
using System.Collections.Concurrent;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace YP_11
{
    class Program
    {
        static ConcurrentQueue<int> cq;
        static CancellationTokenSource cts = new CancellationTokenSource();

        public CancellationTokenSource Cts { get => cts; set => cts = value; }

        static void firs()
        {
            int count = 3;
            for (int i = 2; i > 0; i++)
            {
                if (cts.IsCancellationRequested)
                    Thread.ResetAbort();

                if (isSimple(i))
                {
                    count++;
                    if (count > 2)
                    {
                        cq.Enqueue(i);
                        Thread.Sleep(300);
                        count = 0;
                    }
                }
            }
        }

        static void Second()
        {
            int count = 1;
            for (int i = 2; i > 0; i++)
            {
                if (cts.IsCancellationRequested)
                    Thread.ResetAbort();
                if (isSimple(i))
                {
                    count++;
                    if (count > 2)
                    {
                        cq.Enqueue(i);
                        Thread.Sleep(300);
                        count = 0;
                    }
                }
            }
        }

        static void SecondNext()
        {
            int count = 0;
            for (int i = 2; i > 0; i++)
            {
                if (cts.IsCancellationRequested)
                    Thread.ResetAbort();
                if (isSimple(i))
                {
                    count++;
                    if (count > 2)
                    {
                        cq.Enqueue(i);
                        Thread.Sleep(300);
                        count = 0;
                    }
                }
            }
        }

        static void Main()
        {
            cq = new ConcurrentQueue<int>();
            Task first = new Task(firs);
            Task second = new Task(Second);
            Task secondNext = new Task(SecondNext);

            Task.Run(() =>
            {
                if (Console.ReadKey().Key == ConsoleKey.Escape)
                {
                    cts.Cancel();
                    Thread.Sleep(200);
                    Console.WriteLine(String.Join(" ,", cq));
                }
            });

            Task.Run(() =>
            {
                int i = 0;
                while (!cts.IsCancellationRequested)
                {
                    Thread.Sleep(50);
                    if (cq.TryDequeue(out i))
                    {
                        Console.WriteLine(i);
                    }else
                        Console.WriteLine("empty queue");
                }
            });

            // Запустим задачи
            first.Start();
            second.Start();
            secondNext.Start();

            Console.WriteLine(String.Join(" ,", cq));
            Console.ReadLine();
        }

        public static bool isSimple(int N)
        {
            for (int i = 2; i <= (int)(N / 2); i++)
            {
                if (N % i == 0)
                    return false;
            }
            return true;
        }

    }
}
