using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


namespace UP1
{
    public class Function
    {
        /// <summary>
        /// Constructor sets default values.
        /// </summary>
        public Function()
        {
            this.X = -4.5d;
            this.Y = 0.75 * Math.Pow(10, -4);
            this.Z = 0.845 * Math.Pow(10, 2);
        }
        /// <summary>
        /// gets established numbers
        /// </summary>
        public double X { get => x; set => x = value; }
        public double Y { get => y; set => y = value; }
        public double Z { get => z; set => z = value; }
        /// <summary>
        /// Calculate function
        /// </summary>
        /// <returns>double function </returns>
        public double CalsulateFunction()
        {
            double u = (Math.Pow(8 + Math.Pow(Math.Abs(X - Y), 2) + 1, 1 / 3d)) / (X * X + Y * Y + 2)
                - Math.Exp(Math.Abs(X - Y)) * (Math.Pow((Math.Pow(Math.Tan(Z), 2) + 1), X));
            return u;
        }
        private double x;
        private double y;
        private double z;
    }

    public class SumPositiveNuber
    {
        /// <summary>
        /// Constructor sets default values.
        /// </summary>
        public SumPositiveNuber()
        {
            this.Number = 3;
        }
        /// <summary>
        /// Constructor sets indicated values.
        /// </summary>
        /// <param name="number"> integer number></param>
        public SumPositiveNuber(int number)
        {
            this.Number = number;
        }
        /// <summary>
        /// gets the number
        /// </summary>
        private int Number { get => number; set => number = value; }
        /// <summary>
        /// Calculate sum of positive number
        /// </summary>
        /// <returns>double sum</returns>     
        public double CalculateSumPositiveNumber()
        {
            double sum = 0;
            for (int i = 1; i<Number + 1; i++)
            {
                sum += 1d / i;
            }
            return sum;
        }
private int number;

    }


    public class LargestNumber {
        /// <summary>
        /// Constructor sets default values.
        /// </summary>
        public LargestNumber()
        {
            this.Number = 28;
        }
        /// <summary>
        /// Constructor sets indicated values.
        /// </summary>
        /// <param name="number"> integer number></param>
        public LargestNumber(int number)
        {
            this.Number = number;
        }
        /// <summary>
        /// gets the number
        /// </summary>
        private int Number { get => number; set => number = value; }
        /// <summary>
        /// Find latgest number
        /// </summary>
        /// <returns>int power</returns>
        public int FindLargestNumber() // переменная или свойство
        {
            int k = 0;
            while (Math.Pow(3, k) < Number)
            {
                k++;
            }
            k--;
            return k;
        }

        private int number;
    }



    public class PerfectNumbers
    {
        /// <summary>
        /// Constructor sets default values.
        /// </summary>
        public PerfectNumbers()
        {
            this.A = 1;
            this.B = 8;
        }
        /// <summary>
        /// Constructor for setting the range for calculating perfect numbers.
        /// </summary>
        /// <param name="a">Integer value, from number.</param>
        /// <param name="b">Integer value, before number.</param>
        public PerfectNumbers(int a, int b)
        {
            this.A = a;
            this.B = b;
        }
        /// <summary>
        /// Read and Write Properties.
        /// </summary>
        public int A { get => a; set => a = value; }
        /// <summary>
        /// Read and Write Properties.
        /// </summary>
        public int B { get => b; set => b = value; }
        /// <summary>
        /// The function of checking numbers for perfection in the range.
        /// </summary>
        /// <returns>Integer array perfect numbers.</returns>
        public int[] PerfectNumbersAB()
        {
            int count = 0;
            int[] array = new int[B - A];
            for (int i = A; i <= B; i++)
            {
                if (IsPerfect(i) && i != 0)
                {
                    array[count] = i;
                    count++;
                }
            }
            int[] filanArray = array.Where(x => x != 0).ToArray();
            return filanArray;
        }
        /// <summary>
        /// The function checks if the number is perfect.
        /// </summary>
        /// <param name="n">Integer values of check.</param>
        /// <returns>Boolean tye</returns>
        public bool IsPerfect(int n)
        {
            int sum = 0;
            for (int i = 1; i < n; i++)
            {
                if (n % i == 0)
                {
                    sum += i;
                }
            }
            return sum == n;
        }

        private int a;
        private int b;
    }

    public class Combinatoric
    {
        /// <summary>
        /// Constructor sets default values.
        /// </summary>
        public Combinatoric()
        {
            output = new List<string>();
            this.str = "1234";
            this.startIndex = 0;
            this.endIndex = this.str.Length - 1;
        }
        /// <summary>
        /// Constructor for input an arbitrary number.
        /// </summary>
        /// <param name="number">string value, from number.</param>
        public Combinatoric(string number)
        {
            output = new List<string>();
            this.str = number;
            this.endIndex = this.str.Length - 1;
        }
        /// <summary>
        /// Gets the Number.
        /// </summary>
        /// <remarks>
        /// maximum numbeer must not exceed six digits
        /// </remarks>
        public string Str
        {
            get
            {
                return str;
            }
            set
            {
                if (str.Length > 6)
                    Console.WriteLine("too big numer");
                else
                    str = value;
            }
        }
        /// <summary>
        /// Gets the StartIndex.
        /// </summary>
        /// <remarks> 
        /// start index can't be a negative
        /// </remarks>
        public int StartIndex
        {
            get
            {
                return startIndex;
            }
            set
            {
                if (startIndex < 0)
                    Console.WriteLine("the numer can't be a negative");
                else
                    startIndex = value;
            }
        }
        /// <summary>
        /// Gets the EndIndex.
        /// </summary>
        /// <remarks> 
        /// the numer should be above zero
        /// </remarks>
        public int EndIndex
        {
            get
            {
                return endIndex;
            }
            set
            {
                if (endIndex < 1)
                    Console.WriteLine("the numer should be above zero");
                else
                    endIndex = value;
            }
        }
        /// <summary>
        /// Permutate function
        /// </summary>
        /// <param name="startIndex" index of first digit ></param>
        /// <returns> list of numers </returns>
        public List<string> Permute(int startIndex)
        {

            if (startIndex == endIndex)
            {
                this.output.Add(str);
            }
            else
            {
                for (int i = startIndex; i <= endIndex; i++)
                {
                    str = Swap(str, startIndex, i);
                    Permute(startIndex + 1);
                    str = Swap(str, startIndex, i);
                }

            }
            return this.output;

        }
        /// <summary>
        /// Swap Character at position
        /// </summary>
        /// <param name="a" string value></param>
        /// <param name="i" position 1></param>
        /// <param name="j" position 2></param>
        /// <returns> swapper string</returns>
        private string Swap(String a, int i, int j)
        {
            char temp;
            char[] charArray = a.ToCharArray();
            temp = charArray[i];
            charArray[i] = charArray[j];
            charArray[j] = temp;
            string s = new string(charArray);
            return s;
        }

        List<string> output;
        private string str;
        private int startIndex;
        private int endIndex;
    }
}

