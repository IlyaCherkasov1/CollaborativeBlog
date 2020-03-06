using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Xml;
using System.Threading.Tasks;
using System.Xml.Serialization;
using System.IO;

namespace Laba18_XML
{
    class Program
    {
        static void Main(string[] args)
        {
            Specialty sp = new Specialty("IT", 16);
            Specialty sp1 = new Specialty("Turism", 10);
            Specialty sp2 = new Specialty("Comers", 20);


            Specialty[] mas = new Specialty[] { sp, sp1, sp2 };

            XmlSerializer formatter = SaveToFile(mas);
            WriteToFile(formatter);

            XmlDocument xdock = FindElement("Name");
            DeleteElement(xdock, "IT");

        }

        private static void WriteToFile(XmlSerializer formatter)
        {
            using (StreamReader sr = new StreamReader("test.xml"))
            {
                Specialty[] newmas = (Specialty[])formatter.Deserialize(sr);
            }
        }

        private static XmlSerializer SaveToFile(Specialty[] mas)
        {
            XmlSerializer formatter = new XmlSerializer(typeof(Specialty[]));
            using (StreamWriter sw = new StreamWriter("test.xml"))
            {
                formatter.Serialize(sw, mas);
            }

            return formatter;
        }

        private static XmlDocument FindElement(string speciality)
        {
            XmlDocument xdock = new XmlDocument();
            xdock.Load("test.xml");
            foreach (XmlNode el in xdock.SelectNodes("//Specialty"))
            {
                string name = el.SelectSingleNode(speciality).InnerText;
                if (name == speciality)
                {
                    Console.WriteLine("Специальность  " + el.SelectSingleNode("Name").InnerText);
                    Console.WriteLine("Среднее время: {0} ", el.SelectSingleNode("time").InnerText);
                }
            }
            return xdock;
        }

        private static void DeleteElement(XmlDocument xdock, string spesiality)
        {
            xdock.Load("test.xml");
            foreach (XmlNode el in xdock.SelectNodes("//Specialty"))
            {
                string name = el.SelectSingleNode("Name").InnerText;
                if (name == spesiality)
                {
                    el.RemoveAll();
                    xdock.Save("test.xml");
                }
            }
        }
    }
}
