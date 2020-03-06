using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Linq;


namespace Laba18_2
{
    class Store
    {
        public void OutputElement()
        {
            XDocument xdoc = XDocument.Load("phones.xml");
            foreach (XElement phoneElement in xdoc.Element("phones").Elements("phone"))
            {
                XAttribute nameAttribute = phoneElement.Attribute("name");
                XElement companyElement = phoneElement.Element("company");
                XElement numberElement = phoneElement.Element("number");

                if (nameAttribute != null && companyElement != null
                    && phoneElement != null)
                {
                    Console.WriteLine("Смартфон: " + nameAttribute.Value);
                    Console.WriteLine("Компания: " + companyElement.Value);
                    Console.WriteLine("Количество:" + numberElement.Value);
                    Console.WriteLine();
                }
            }
        }

        public void SupplyElement(string name, int number)
        {
            XDocument xdoc = XDocument.Load("phones.xml");
            XElement root = xdoc.Element("phones");
            foreach (XElement xe in root.Elements("phone").ToList())
            {
                if (xe.Attribute("name").Value == name)
                {
                    xe.Element("number").Value = (Convert.ToInt32(xe.Element("number").Value) + number).ToString();
                }

            }
            xdoc.Save("phones.xml");
        }

       public void PurchaseElement(string name, int number)
        {
            XDocument xdoc = XDocument.Load("phones.xml");
            XElement root = xdoc.Element("phones");
            foreach (XElement xe in root.Elements("phone").ToList())
            {
                if (xe.Attribute("name").Value == name)
                {
                    if (Convert.ToInt32(xe.Element("number").Value) - number <= 0)
                        xe.RemoveAll();
                      else 
                    xe.Element("number").Value = (Convert.ToInt32(xe.Element("number").Value) - number).ToString();
                }

            }
            xdoc.Save("phones.xml");
        }

        public void FindConsident(string company, string number)
        {
            XDocument xdoc = XDocument.Load("phones.xml");
            var items = from xe in xdoc.Element("phones").Elements("phone")
                       where xe.Element("company")?.Value  == company && xe.Element("number").Value == number

                        select new Phone
                       {
                           Name = xe.Attribute("name").Value,
                           Number = xe.Element("number").Value
                       };

            foreach(var item in items)
            {
                Console.WriteLine("name: {0}  Number: {1}", item.Name, item.Number);
            }
        }

    }
}




