
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace combinatorics
{
    class Program
    {
        static void Main(string[] args)
        {
            List<string> Select3WithDuplicates = new List<string>();
            List<string> result = new List<string>();
            List<string> item = new List<string>() { "1", "2", "3", "4", "5" };
            for (int i = 0; i < item.Count; i++)
            {
                for (int j = i+1; j < item.Count; j++)
                {
                    for (int k = j+1; k < item.Count; k++)
                    {
                        result.Add(item[i] + item[j] + item[k]);
                    }
                }
            }
            foreach(var i in result)
            {
                Console.Write(i + " ");
            }
        }
  
    }
}
