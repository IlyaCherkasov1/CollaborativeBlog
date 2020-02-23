using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Combination1
{
    class Class1
    {
          public List<int[]> GetAllCombinationsUsingBits(int[] array, int k)
    {
        var result = new List<int[]>();
        var len = array.Length;           
        var total = Math.Pow(2, len);

        for (int i = 1; i < total; i++)
        {
            // could also be checked by counting the ones in the binary, though this will require moving the binary up
            if (numberOfSetBits(i) == k) 
            {
                var element = new int[k];
                var binary = Convert.ToString(i, 2);
                var bLen = binary.Length;
                if ( bLen < len)
                    binary = PrependZero(binary, len - bLen);

                int counter = 0;
                for (int j = 0; j < len; j++)
                {
                    if (binary[j] == '1')
                    {
                        element[counter] = array[j];
                        counter++;
                    }
                }
                result.Add(element);
            }
        }

        return result;
    }

    private string PrependZero(string binary, int i)
    {            
        for (int j = 0; j < i; j++)
            binary = "0" + binary;

        return binary;
    }

    private int numberOfSetBits(int i)
    {
        i = i - ((i >> 1) & 0x55555555);
        i = (i & 0x33333333) + ((i >> 2) & 0x33333333);
        return (((i + (i >> 4)) & 0x0F0F0F0F) * 0x01010101) >> 24;
    }
    }
}
