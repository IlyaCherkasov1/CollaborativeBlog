using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Laba17DLL;

namespace laba17_Generalization
{
    class Program
    {
        static void Main(string[] args)
        {

            Console.WriteLine(" 1.1:  Доступ к элементу по индексу  ");
            Console.WriteLine(" 1.2:  Добавление списка а в список b ");
            Console.WriteLine(" 1.3:  Добавляет элемент в начало списка  ");
            Console.WriteLine();
            Console.WriteLine(" 2.1:  Доступ к элементу по индексу  ");
            Console.WriteLine(" 2.2:  Добавление списка а в список b ");
            Console.WriteLine(" 2.3:  Добавляет элемент в начало списка   ");
            Console.WriteLine();
            Console.WriteLine(" 3.1:  минимальный элемент, который при делении на число дает в остатке 0.   ");
            Console.WriteLine(" 3.2:  число – максимальный элемент который при вычитании числа будет полным квадратом. ");

            string l;
            do
            {   
                l =Console.ReadLine();

                switch (l)
                {
                    case "1.1":

                        Console.WriteLine("Введите индекс для обращения: ");
                        int index1 = Convert.ToInt32(Console.ReadLine());
                        List<int> list = new List<int> { 1, 2, 3, 4 };
                        ListInt A = new ListInt(list);
                        Console.WriteLine(A);
                        Console.WriteLine("Элемент с индексом: " + index1 + " = " + A[index1]);
                        break;

                    case "1.2":

                        List<int> list1 = new List<int> { 1, 2, 3 };
                        ListInt A1 = new ListInt(list1);
                        Console.WriteLine(A1);
                        Console.WriteLine("исходный список: " +  +A1); 
                        break;

                    case "1.3":
                        Console.WriteLine("Введите константу для добавления: ");
                        int constant = Convert.ToInt32(Console.ReadLine());
                        List<int> list2 = new List<int> { 1, 3, 4 };
                        ListInt A2 = new ListInt(list2);
                        Console.WriteLine(A2);
                        Console.WriteLine();
                        Console.WriteLine(A2 + constant);
                        break;

                    case "2.1":

                        Console.WriteLine("Введите индекс для обращения: ");
                        int index2 = Convert.ToInt32(Console.ReadLine());
                        var queue = new Queue<string>();
                        queue.Enqueue("1");
                        queue.Enqueue("2");
                        queue.Enqueue("3");
                        queue.Enqueue("4");
                        queue.Enqueue("9");
                        QueueString Q = new QueueString(queue);
                        Console.WriteLine(Q);
                        Console.WriteLine("Элемент с индексом: " + index2 + " = " + Q[index2]);
                        break;

                    case "2.2":

                        var queue1 = new Queue<string>();
                        queue1.Enqueue("1");
                        queue1.Enqueue("2");
                        queue1.Enqueue("3");
                        queue1.Enqueue("4");
                        queue1.Enqueue("9");
                        QueueString Q1 = new QueueString(queue1);
                        Console.WriteLine(Q1);
                        Console.WriteLine (+Q1);
                        break;

                    case "2.3":
                        Console.WriteLine("Введите константу для добавления: ");
                        string constant1 = Console.ReadLine();
                        var queue2 = new Queue<string>();
                        queue2.Enqueue("1"); 
                        queue2.Enqueue("2"); 
                        queue2.Enqueue("3"); 
                        queue2.Enqueue("4"); 
                        queue2.Enqueue("9");
                        QueueString Q2 = new QueueString(queue2);
                        Console.WriteLine(Q2);
                        Console.WriteLine();
                        Console.WriteLine(Q2 + constant1);
                        break;

                    case "3.1":
                        Console.WriteLine("Введите число элементов для добавления: ");
                        int count = Convert.ToInt32(Console.ReadLine())+1;
                        int[] C1 = new int[] { 1, 2, 3, 4 };
                        GeneralizedClass<int> GS1 = new GeneralizedClass<int>(C1);
                        Console.WriteLine();
                        Console.WriteLine(GS1);
                        Console.WriteLine((GS1 >> count));
                        break;

                    case "3.2":

                        Console.WriteLine("Введите число элементов для добавления: ");
                        int count1 = Convert.ToInt32(Console.ReadLine());
                        int[] C = new int[] { 1, 2, 3, 4 };
                        GeneralizedClass<int> GS = new GeneralizedClass<int>(C);
                        Console.WriteLine();
                        Console.WriteLine(GS);
                        Console.WriteLine((GS << count1));
                        break;
                }
            }
            while (true);
            }
        }
    }