using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;
using System.Text.RegularExpressions;

namespace ClassLibraryUP13
{
    /// <summary>
    /// text utils
    /// </summary>
    public class TextFile
    {
        string name;
        /// <summary>
        /// change all letter
        /// </summary>
        /// <param name="fileName"></param>
        /// <param name="firstLetter"></param>
        /// <param name="secondLetter"></param>
        /// <returns></returns>
        public string ChangeLetter(string fileName, string firstLetter, string secondLetter)
        {
            string InputText;
            CreateFile(fileName);
            using (StreamReader sr = new StreamReader(name))
            {
                InputText = sr.ReadToEnd();
            }
             return InputText.Replace(firstLetter, secondLetter);
        }

        /// <summary>
        /// sort my numbers
        /// </summary>
        /// <param name="fileName"></param>
        /// <returns></returns>
        public int[] SortNumbers(string fileName)
        {
            int[] array;
            string[] arrayBuf;
            CreateFile(fileName);

            using (StreamWriter sw = new StreamWriter(fileName + ".txt", false, System.Text.Encoding.Default))
            {
                sw.WriteLine("1 6 7 8 3");
            }

            using (StreamReader sr = new StreamReader(name))
            {
                arrayBuf = sr.ReadToEnd().Split(new[] { ' ' }, StringSplitOptions.RemoveEmptyEntries).ToArray();
                array = arrayBuf.Select(x => int.Parse(x)).ToArray();
            }

            return BubbleSort(array);
          
        }

        /// <summary>
        /// swap digits
        /// </summary>
        /// <param name="e1"></param>
        /// <param name="e2"></param>
        private void Swap(ref int e1, ref int e2)
        {
            var temp = e1;
            e1 = e2;
            e2 = temp;
        }

        /// <summary>
        /// bubble sortg
        /// </summary>
        /// <param name="array"></param>
        /// <returns></returns>
        private int[] BubbleSort(int[] array)
        {
            var len = array.Length;
            for (var i = 1; i < len; i++)
            {
                for (var j = 0; j < len - i; j++)
                {
                    if (array[j] > array[j + 1])
                    {
                        Swap(ref array[j], ref array[j + 1]);
                    }
                }
            }

            return array;
        }



        /// <summary>
        /// file component
        /// </summary>
        /// <param name="fileName"></param>
        /// <param name="componentNumber"></param>
        /// <returns></returns>
        public int FileComponent (string fileName, int componentNumber)
        {
            double formula;
            List<double> ls = new List<double>();
            using (StreamWriter sw = new StreamWriter(fileName + ".txt", false, Encoding.Default))
            {
                for (int i = 0; i < componentNumber; i++)
                {
                    formula = Math.Pow(i + 1, 2) * Math.Sin(i * Math.PI / 10);
                    sw.WriteLine(formula);
                    ls.Add(formula);
                    formula = 0;
                }
            }
           return ls.Where(x => x > 0).Count();
        
        }

        /// <summary>
        /// add my surname
        /// </summary>
        /// <param name="fileName"></param>
        public void AddMySurname(string fileName)
        {
            using (StreamWriter sw = new StreamWriter(fileName + ".txt", true, Encoding.Default))
            {
                sw.WriteLine("Chercasov");
            }
        }

        /// <summary>
        /// create file
        /// </summary>
        /// <param name="name"></param>
        private void CreateFile(string name)
        {
            this.name = name + ".txt";
            FileInfo fileInfo = new FileInfo(this.name);
            if (!fileInfo.Exists)
            {
                fileInfo.Create();
            }
          
        }
        /// <summary>
        /// create file from text
        /// </summary>
        /// <param name="fileName"></param>
        public void CreateFileFromText(string fileName)
        {
            CreateFile(fileName);
            string text;

            using (StreamReader sr = new StreamReader(fileName + ".txt"))
            {
                text = sr.ReadToEnd();
            }

            string path = @"C:\Users\HP\source\repos\UP13_FileStream\UP13_FileStream\bin\Debug";
            Regex regex = new Regex(@"A(\w+)");
            MatchCollection matches = regex.Matches(text);
            if (matches.Count > 0)
            {
                foreach (Match i in matches)
                {
                    path = path + "\\" + i.Groups[1].Value;
                    Directory.CreateDirectory(path);

                }
            }

            path += "\\";
            FileInfo fileInfo;
            Regex regex1 = new Regex(@"X(\d+)");
            MatchCollection matches1 = regex1.Matches(text);
            int x = 0;
            if (matches1.Count > 0)
            {
                foreach (Match i in matches1)
                {
                    x = int.Parse(i.Groups[1].Value);
                 
                }
            }

            for (int j = 0; j < x; j++)
            {
                fileInfo = new FileInfo(path + j.ToString() + ".txt");
                if (!fileInfo.Exists)
                fileInfo.Create();

            }
        }


    }
}
