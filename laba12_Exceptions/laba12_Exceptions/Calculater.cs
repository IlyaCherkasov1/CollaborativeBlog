using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace laba12_Exceptions
{
    public class Calculater
    {
        private int number1, number2;
        public Calculater(int num1)
        {
            number1 = num1;
        }
        public static Calculater operator +(Calculater c1, Calculater c2)
        {
            c1.number1 +=  c2.number1;
            if (c1.number1 < -128 || c1.number1 > 127)
                throw new DischargeOverflowException();
            return new Calculater(c1.number1);
        }
        public static Calculater operator -(Calculater c1, Calculater c2)
        {
            c1.number1 -= c2.number1;
            if (c1.number1 < -128 || c1.number1 > 127)
                throw new DischargeOverflowException();
            return new Calculater(c1.number1);
        }
        public static Calculater operator *(Calculater c1, Calculater c2)
        {
            c1.number1 *= c2.number1;
            if (c1.number1 < -128 || c1.number1 > 127)
                throw new DischargeOverflowException();
            return new Calculater(c1.number1);
        }

        public static Calculater operator /(Calculater c1, Calculater c2)
        {
            c1.number1 /= c2.number1;
            if (c1.number1 < -128 || c1.number1 > 127)
                throw new DischargeOverflowException();
            return new Calculater(c1.number1);
        }


        public override string ToString() => $"{number1}";
    }

}
