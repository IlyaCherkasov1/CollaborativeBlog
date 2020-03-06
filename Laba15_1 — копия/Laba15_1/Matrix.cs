using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;

namespace Laba15_1 
{
    class Matrix 
    {
        double[][] array;
        string[] array1;
        public Matrix() 
        {
        }

        private double[] Convert(string str)
        {
            return str.Split(new char[] { ' ', ',' }, StringSplitOptions.RemoveEmptyEntries)
                .Select(x => double.Parse(x)).
                ToArray();
        }

        public void AddToFile()
        {
            FileInfo f1 = new FileInfo("input1.txt");
            if (!f1.Exists)
                f1.Create();
            array = File.ReadAllLines("input1.txt").Select(x => Convert(x)).ToArray();
            FileInfo f2 = new FileInfo("output1.txt");
            if (!f2.Exists)
                f2.Create();
            StreamWriter sw = new StreamWriter("output1.txt",false);
            var mas = array.Select(x =>
                 x.Min()*x.Max());
                    sw.WriteLine(string.Join(" ", mas));
            sw.Close();
        }

        public void SortSentences()
        {
            FileInfo f1 = new FileInfo("input2.txt");
            if (!f1.Exists)
                f1.Create();
           
            array1 = File.ReadAllText("input2.txt").
            Split(new char[] { ' ' }, StringSplitOptions.RemoveEmptyEntries);
           

            FileInfo f2 = new FileInfo("output2.txt");
            if (!f2.Exists)
                f2.Create();

            array1 = array1.OrderBy(x => CountPersent(x)).ToArray();
            StreamWriter sw = new StreamWriter("output2.txt", false);
            foreach(string i in array1)
            {
                sw.Write(i + " ");
            }
            sw.Close();
        }

        private int CountPersent(string sentences)
        {
            int persent = 0;
            int count = 0;
            char[] vowels = { 'a', 'e', 'i', 'o', 'u' }; 
            for (int i = 0; i < sentences.Length; i++)
            {
                if (vowels.Contains(sentences[i]))
                    count++;
            }
            persent = (count * 100) / sentences.Length;
            return persent;
        }

    


        public void CreateFileInDirectory(string fileName)
        {          
            DirectoryInfo dr = new DirectoryInfo(fileName);
            for (int i = 0; i < 3; i++)
            {
                dr.CreateSubdirectory(i.ToString());
            }
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
