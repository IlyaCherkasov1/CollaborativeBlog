using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml;
using System.Xml.Serialization;

namespace HW7
{
    class Program
    {
        static void Main(string[] args)
        {
            Car cr = new Car("Kia", 16);
            Car cr1 = new Car("Renault", 10);
            Car cr2 = new Car("Hyundai", 20);


            Car[] mas = new Car[] {cr,cr1,cr2 };
            XmlSerializer formatter = SaveToFile(mas);
            WriteToFile(formatter);

        }

        private static void WriteToFile(XmlSerializer formatter)
        {
            using (StreamReader sr = new StreamReader("test.xml"))
            {
                Car[] newmas = (Car[])formatter.Deserialize(sr);
            }
        }

        private static XmlSerializer SaveToFile(Car[] mas)
        {
            XmlSerializer formatter = new XmlSerializer(typeof(Car[]));
            using (StreamWriter sw = new StreamWriter("test.xml"))
            {
                formatter.Serialize(sw, mas);
            }

            return formatter;
        }

    }
}
