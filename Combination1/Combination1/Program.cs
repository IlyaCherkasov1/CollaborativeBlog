using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Combination1
{
    class Program
    {
        static void Main(string[] args)
        {
            List<string> numbers = new List<string>() { "1", "2", "3", "4", "5" };
            List<string> possibleCombination = GetCombination(numbers, new List<string>(), "");
            Console.Write(string.Join(", ", possibleCombination.Distinct().OrderBy(itm => itm)));
        }
		static List<string> GetCombination(List<string> list, List<string> combinations, string sumNum, bool addNumberToResult = false)
		{
			if (list.Count == 0)
			{
				return combinations;
			}

			string tmp;

			for (int i = 0; i <= list.Count - 1; i++)
			{
				tmp = string.Concat(sumNum, list[i]);
				if (addNumberToResult)
				{
					combinations.Add(tmp);
				}
				List<string> tmp_list = new List<string>(list);
				tmp_list.RemoveAt(i);
				GetCombination(tmp_list, combinations, tmp, true);
			}

			return combinations;
		}
	}
}

