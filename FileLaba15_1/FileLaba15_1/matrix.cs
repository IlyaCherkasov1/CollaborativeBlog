using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;

namespace FileLaba15
{
    class Matrix
    {
        double[][] array;
        public Matrix(string path)
        {
           array =  File.ReadAllLines(path).Select(x => Convert(x)).ToArray();

        }

        private double[] Convert(string str)
        {
            return str.Split(new char[] { ' ', ',' }, StringSplitOptions.RemoveEmptyEntries)
                .Select(x => double.Parse(x)).
                ToArray();
        }

        public void AddToFile()
        {
            FileInfo fi = new FileInfo("output1.txt");
            fi.Create();
       //     StreamWriter sw = new StreamWriter("output1.txt");
        }

        public void Output()
        {
            for (int i = 0; i < array.Length; i++)
            {
                for (int j = 0; j < array[i].Length; j++)
                {
                    Console.Write("{0} ", array[i][j]);
                }
                Console.WriteLine();
            }

        }
    }
}