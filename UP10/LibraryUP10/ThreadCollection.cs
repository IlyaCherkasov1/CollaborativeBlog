using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LibraryUP10
{
    public class ThreadCollection
    {
        List<int> ls;

        public ThreadCollection(List<int> ls)
        {
            this.ls = ls;
        }

        public override string ToString()
        {
            return string.Join(" ", ls).ToString();
        }

       public async  void AddAfterAllEvenDigit()
        {
            int i = 0;
            while (true)
            {
                if (i == ls.Count - 1)
                {
                    i = 0;
                }

                if (ls[i] % 2 == 0)
                {
                    ls[i + 1] = ls[i + 1] + 1;
                    await Task.Delay(2000);
                    Console.WriteLine(string.Join(" ", ls));
                }

                i++;
            }
        }

        public async void AddRandomElement()
        {
            Random rd = new Random();
            int i = 0;
            while (true)
            {
                ls.Add(rd.Next(0, 10));
                await Task.Delay(3000);
                i++;
            }
        }


        public  async  void Factorial()
        {
            int i = 0;
            int result = 1;
            while (true)
            {
                await Task.Delay(2000);
                for (int j = 1; j <= ls[i]; j++)
                {
                    result *= j;
                }
                Console.WriteLine($"Факториал {i + 1}-го числа равен {result}");
                result = 1;
                i++;

            }

        }
    }
}
