using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ClassLibraryUP13;
using System.Xml.Serialization;
using System.IO;

namespace UP13_FileStream
{
    class Program
    {
        static void Main(string[] args)
        {

            Console.WriteLine("1.Откорректировать текст, расположенный в текстовом файле, заменив в нем все вхождения одной буквы на другую.");
            Console.WriteLine("2.	Произвести сортировку файла целых чисел методом пузырька.");
            Console.WriteLine("3.	Сформировать файл, компонентами которого являются действительные значения, вычисляемые по формуле ai = (i + 1)2sin(iπ / 10) ");
            Console.WriteLine("4.	В произвольный текстовый файл добавить в конец свою фамилию.");
            Console.WriteLine("5. создание файла по шаблону");
            Console.WriteLine("6. XML меню");
            TextFile textFile = new TextFile();
            while (true)
            {
                string a = Console.ReadLine();
                switch (a)
                {
                    case "1":
                        Console.WriteLine(textFile.ChangeLetter("task1", "т", "б"));
                        break;
                    case "2":
                        Console.WriteLine(string.Join(" ", textFile.SortNumbers("sortTask2")));
                        break;
                    case "3":
                        Console.WriteLine(textFile.FileComponent("fileComponentTask3", 8));
                        break;
                    case "4":
                        textFile.AddMySurname("MySurname");
                        break;
                    case "5":
                        textFile.CreateFileFromText("CreteFileFromText");
                        break;
                    case "6":
                        XmlHelper xmlHelper = new XmlHelper();
                        xmlHelper.XmlMenu();
                        break;
                }
            }
       
        }
    }
}
