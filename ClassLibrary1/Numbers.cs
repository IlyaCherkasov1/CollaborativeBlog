using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Collections;

 namespace ClassLibrary1
{
    public class numbers:IComparer<int>
    {
     
        public int Compare(int x, int y)
        {
            if (x % 3 > y % 3 )
            {
                return 1;
            }
            if (x % 3 < y % 3)
            {
                return -1;
            }
            if ((x  > y) || (x % 2 == 0) )
                return 1;
            if ((x < y) || (x % 2 == 0))
                return -1;
            else
            {
                return 0;
            }
        }
    }
}
