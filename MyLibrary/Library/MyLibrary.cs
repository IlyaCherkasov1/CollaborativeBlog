using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Library
{
    public static class MyLibrary
    {
        public static double Add( double FirstValue, double SecondValue)
        {
            return FirstValue + SecondValue;
        }
        public static double Sub(double FirstValue, double SecondValue)
        {
            return FirstValue - SecondValue;
        }
        public static double Mul(double FirstValue, double SecondValue)
        {
            return FirstValue * SecondValue;
        }
        public static double Dev(double FirstValue, double SecondValue)
        {
            if (SecondValue == 0)
                return 0;
            return FirstValue / SecondValue;
        }
        public static int  Minus(int FirstValue)
        {
            int a = FirstValue++;
            return a;        
        }
        public static int Plus(int FirstValue)
        {

            int a = FirstValue--;
            return a;
        }
    }
}
