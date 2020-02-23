using System;
using System.Linq;

namespace laba5_2
{
    internal class Program
    {
        private static void Main(string[] args)
        {
            Matrix m = new Matrix();
            m[4, 4] = -9;
            Console.WriteLine(m);
            Matrix withCant = m.MatrixWithCant(0);
            Console.WriteLine(withCant);
        }
    }

    internal class Matrix
    {
        private int[,] values;

        public Matrix()
        {
            values = new int[10, 10];
            for (int i = 0; i < values.GetLength(0); i++)
            {
                for (int j = 0; j < values.GetLength(1); j++)
                {
                    values[i, j] = i + j;
                }
            }
        }

        public Matrix(int n, int m)
        {
            values = new int[n, m];
            for (int i = 0; i < values.GetLength(0); i++)
            {
                for (int j = 0; j < values.GetLength(1); j++)
                {
                    values[i, j] = int.Parse(Console.ReadLine());
                }
            }
        }


        public Matrix(int[,] matrix)
        {
            this.values = matrix;
        }

        public int this[int i, int j]
        {
            get { return values[i, j]; }
            set { values[i, j] = value; }
        }

        public Matrix MatrixWithCant(int cantValue)
        {
            int[,] temp = (int[,])values.Clone();
            for (int i = 0; i < temp.GetLength(0); i++)
            {
                for (int j = 0; j < temp.GetLength(1); j++)
                {
                    if ((j == 0) ||
                              (j == 0) ||
                              (j == temp.GetLength(0) - 1) ||
                              (j == temp.GetLength(1) - 1))
                        temp[i, j] = cantValue;
                }
            }
            return new Matrix(temp);
        }

        public override string ToString()
        {
            var array = values.Cast<int>();
            var maxlength =
                array.Max().ToString().Length > array.Min().ToString().Length ?
                array.Max().ToString().Length :
                array.Min().ToString().Length;
            return string.Join("\n", array
            .Take(values.GetLength(0))
            .Select((x, i) => string.Join(", ", array
            .Skip(i * values.GetLength(1))
            .Take(values.GetLength(0))
            .Select(v => TakeSetForm(v, maxlength)))));
        }

        private string TakeSetForm(int values, int simbol = 4)
        {
            return values.ToString().PadLeft(simbol);
        }
    }
}