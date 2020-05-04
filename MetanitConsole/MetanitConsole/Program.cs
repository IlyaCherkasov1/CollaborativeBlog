using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Linq;

namespace MetanitConsole
{
    class Program
    {
        static void Main(string[] args)
        {
            XDocument xdoc = XDocument.Load("phones.xml");
            XElement root = xdoc.Element("phones");

            foreach (XElement xe in root.Elements("phone").ToList())
            {
                // изменяем название и цену
                if (xe.Attribute("name").Value == "Samsung Galaxy S5")
                {
                    xe.Attribute("name").Value = "Samsung Galaxy Note 4";
                    xe.Element("price").Value = "31000";
                }
                //если iphone - удаляем его
                else if (xe.Attribute("name").Value == "iPhone 6")
                {
                    xe.Remove();
                }
            }
            // добавляем новый элемент
            root.Add(new XElement("phone",
                        new XAttribute("name", "Nokia Lumia 930"),
                        new XElement("company", "Nokia"),
                        new XElement("price", "19500")));
            xdoc.Save("pnones1.xml");
            // выводим xml-документ на консоль
            Console.WriteLine(xdoc);

            Console.Read();
        }
    }
}

