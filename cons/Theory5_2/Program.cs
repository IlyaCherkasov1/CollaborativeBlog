using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Theory5_2
{
    class Program
    {
        static void Main(string[] args)
        //1. в каждой нечетной строке ступенчатой матрице найти произведение элементов
        //2. выбрать отрицательные и посчитать их количество. 
        //Если отрицательных нет вывести -1

        {
            int[][] numbers = new int[4][];
            numbers[0] = new int[] { 3, 2 };
            numbers[1] = new int[] { 1, 2, 3 };
            numbers[2] = new int[] { 1, -2, -3, 4, 5 };
            numbers[3] = new int[] { 5, -1, -9, 4, 2,8 };

       int[] result = (numbers.Select(x => Array.IndexOf(numbers, x) % 2 != 0 ? x.Aggregate((first, item) => first * item) : -1))
            .Where(x => x != -1).ToArray();

      int answer = numbers.Sum(x => x.Count(y => y > 0)) == numbers.Sum(x => x.Count()) ? -1 :
                     numbers.Sum(x => x.Count(y => y < 0));

            Console.WriteLine(String.Join(", ", result));
     Console.WriteLine(answer);
            int[] result1 = (numbers.Select(x => Array.IndexOf(numbers, x) % 2 == 0 ? x.Aggregate((a, b) => a + b) : 0))
                     .Where(x => x != 0).ToArray();
   
 
        }
        public static void PrintArray(int[][] numbers)
        {
            foreach (int[] row in numbers)
            {
                foreach (int number in row)
                {
                    Console.Write($"{number} \t");
                }
                Console.WriteLine();
            }
        }
  
    }
}
