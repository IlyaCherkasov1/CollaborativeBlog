using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Serialization;

namespace Home5
{
    class Program
    {
        static void Main(string[] args)
        {
            Laptop lp = new Laptop("i7", "NVIDiA", "PAVILION");
            XmlSerializer formatter = new XmlSerializer(typeof(Laptop));
            using (FileStream fs = new FileStream("laptop.xml", FileMode.OpenOrCreate))
            {
                formatter.Serialize(fs, lp);
                Console.WriteLine("Объект сериализован");
            }
        }
    }
}
