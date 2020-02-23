using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace test
{
    class Program
    {
        static void Main(string[] args)
        {
            var jaggedArray = new string[5][];
            jaggedArray[0] = new[] { "a", "b", "s", "d" };
            jaggedArray[1] = new[] { "e", "f", "g" };
            jaggedArray[2] = new[] { "h", "i", "f", "k", "f" };
            jaggedArray[3] = new[] { "m", "n", "o", "p", "q", "r" };
            jaggedArray[4] = new[] { "s", "t" };

            // Общий набор символов из всех элементов ступенчатого массива.
            var flattened = jaggedArray.SelectMany(row => row);

            // Проведем трансформацию следующего вида:
            // элемент -> { элемент, ряд, количество вхождений в этом ряду }
            var onlyRepeating = jaggedArray.SelectMany(row => row.Select(
                value =>
                new
                {
                    Value = value,
                    RowIndex = jaggedArray.ToList().IndexOf(row),
                    CountInThisRow = row.Count(x => x == value),
                }))
                // Нужно взять 'distinct', поскольку иначе, например, для 'f' в третьей
                // строчке будут два вхождения, а нам нужно только одно.
                .Distinct()
                // Возьмем только те элементы, которые хоть где-то повторяются.
                .Where(entry => flattened.Count(x => x == entry.Value) > 1);

            // На этом этапе в 'grouped' будут совпадения вида
            // { повторившийся хоть раз элемент, все вхождения в отдельные строки }.
            // *** Это наш финальный результат. ***
            var grouped = onlyRepeating.GroupBy(entry => entry.Value);

            foreach (var grouping in grouped)
            {
                Console.WriteLine("Matches for '{0}':", grouping.Key);

                foreach (var groupingDetails in grouping)
                {
                    Console.WriteLine("\t Row {0} - {1} matched",
                        groupingDetails.RowIndex, groupingDetails.CountInThisRow);
                }
            }
      
        }
    }
}
