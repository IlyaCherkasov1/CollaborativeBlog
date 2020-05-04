using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;
using System.Collections;
using ClassLibraryUP15;

namespace UP15
{
    class Program
    {
        static void Main(string[] args)
        {
           MenuUtils();
        }

        private static void MenuUtils()
        {
            string path = "digit.txt";
            Console.WriteLine("1.Stack");
            Console.WriteLine("2.Queue");
            Console.WriteLine("3. ArrayLIst");
            Console.WriteLine("4. Hash table");
            Console.WriteLine("5. Employee");
            int i = 1;
            while (true)
            {
                string a = Console.ReadLine();
                switch (a)
                {
                    case "1":
                        string s1 = "hello";
                        string s2 = "olleh";
                        Stack<char> lines = new Stack<char>();
                        if (isReverseString(s1, s2, lines))
                            Console.WriteLine("строка s2 обратна строке s1!");
                        break;
                    case "2":
                        Queue<int> queue = orderNumber(path, out queue);
                        foreach (int j in queue)
                            Console.WriteLine(j);
                        break;
                    case "3":
                        ArrayList reversLines = new ArrayList(new string[] { "hello", "olleh" });
                        if (reversLines[0].Equals(new string((reversLines[1] as string).Reverse().ToArray())))
                            Console.WriteLine("true");

                        ArrayList numbersResult = orderNumberArrayList(path);
                        foreach (var j in numbersResult)
                        {
                            Console.WriteLine(j);
                        }
                        break;

                    case "4":
                        Hashtable hashtable = new Hashtable();
                        HashMenu(hashtable);
                        break;
                    case "5":
                        ListEmployee listEmployee = new ListEmployee("input.txt");
                        listEmployee.OutputEmployee();
                        listEmployee.SalaryLowGiven(5555, "output.txt");
                        break;
                }
            }
          }

        private static void HashMenu(Hashtable hashtable)
        {
            Console.WriteLine("1.Добавить диск");
            Console.WriteLine("2.удалить диск");
            Console.WriteLine("3. Вывод дисков");
            Console.WriteLine("4.Выход");
            int i = 1;
            while (true)
            {
                string a = Console.ReadLine();
                switch (a)
                {
                    case "1":
                        Console.WriteLine("название диска");
                        string name = Console.ReadLine();
                        hashtable.Add(i, name);
                        i++;
                        Console.WriteLine("Успешно!");
                        break;
                    case "2":
                        Console.WriteLine("Введите номер диска для удаленя");
                        int key = Int32.Parse(Console.ReadLine());
                        hashtable.Remove(key);
                        Console.WriteLine("Успешно!");
                        break;
                    case "3":
                        ICollection keys = hashtable.Keys;
                        foreach (var s in keys)
                            Console.WriteLine(s + ": " + hashtable[s]);
                        break;
                    case "4":
                        MenuUtils();
                        break;
                }
            }
        }

        private static ArrayList orderNumberArrayList(string path)
        {

            ArrayList numbers = new ArrayList();
            string[] lines;
            int[] digits;
            using (StreamReader sr = new StreamReader(path))
            {
                lines = sr.ReadToEnd().Split(new[] { ' ' });
                digits = lines.Select(x => int.Parse(x)).ToArray();
            }
            for (int i = 0; i < digits.Length; i++)
            {
                if (digits[i] >= 0)
                {
                    numbers.Add(digits[i]);
                }
            }

            for (int i = 0; i < digits.Length; i++)
            {
                if (digits[i] < 0)
                {
                    numbers.Add(digits[i]);
                }
            }
            return numbers;
        }

        private static Queue<int> orderNumber(string path, out Queue<int> queue)
        {
            string[] lines;
            int[] digits;
            using (StreamReader sr = new StreamReader(path))
            {
                lines = sr.ReadToEnd().Split(new[] { ' ' });
                digits = lines.Select(x => int.Parse(x)).ToArray();
            }
            queue = new Queue<int>();
            for (int i = 0; i < digits.Length; i++)
            {
                if (digits[i] >= 0)
                {
                    queue.Enqueue(digits[i]);
                }

            }
            for (int i = 0; i < digits.Length; i++)
            {
                if (digits[i] < 0)
                {
                    queue.Enqueue(digits[i]);
                }

            }
            return queue;
        }

        private static bool isReverseString(string s1, string s2, Stack<char> lines)
        {
            int k = 0;
            if (s1.Length == s2.Length)
            {
                for (int i = 0; i < s1.Length; i++)
                {
                    lines.Push(s1[i]);
                }
                for (int j = 0; j < s2.Length; j++)
                {
                    if (s2[j] != lines.Pop())
                    {
                        k++;
                    }
                }

            }
            if (k == 0)
            {
                return true;
            }
            return false;
        }
    }
}
