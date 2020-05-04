using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Linq;
using System.Xml.Serialization;


namespace ClassLibraryUP13 
{
    /// <summary>
    /// xml utils
    /// </summary>
    public class XmlHelper
    {
       static XDocument xDoc = XDocument.Load("CarService.xml");
       XElement root = xDoc.Element("CarServices");
 
        /// <summary>
        /// add element to xml file
        /// </summary>
        /// <param name="carService"></param>
        public void AddElement(CarService carService)
        {
                root.Add(
                    new XElement("CarService",
                        new XAttribute("number", carService.Number),
                        new XElement("mark", carService.Mark),
                        new XElement("mileage", carService.Mileage),
                        new XElement("master", carService.Master),
                        new XElement("sum", carService.Sum)));
            xDoc.Save("CarService.xml");
        }
        /// <summary>
        /// add before self
        /// </summary>
        /// <param name="carService"></param>
        /// <param name="CarNumber"></param>
        public void AddBeforeSelf(CarService carService, string CarNumber)
        {
           root.Elements("CarService")
            .Where(e => ((string)e.Attribute("number")) == CarNumber)
            .Single<XElement>()
            .AddBeforeSelf(
                 new XElement("CarService",
                        new XAttribute("number", carService.Number),
                        new XElement("mark", carService.Mark),
                        new XElement("mileage", carService.Mileage),
                        new XElement("master", carService.Master),
                        new XElement("sum", carService.Sum)));

            xDoc.Save("CarService.xml");
        }

        /// <summary>
        /// add after self
        /// </summary>
        /// <param name="carService"></param>
        /// <param name="CarNumber"></param>
        public void AddAfterSelf(CarService carService, string CarNumber)
        {
                    root.Elements("CarService")
         .Where(e => ((string)e.Attribute("number")) == CarNumber)
         .Single<XElement>()
         .AddAfterSelf(
         new XElement("CarService",
             new XAttribute("number", carService.Number),
             new XElement("mark", carService.Mark),
             new XElement("mileage", carService.Mileage),
             new XElement("master", carService.Master),
             new XElement("sum", carService.Sum)));

            xDoc.Save("CarService.xml");
        }
        /// <summary>
        /// delete before self
        /// </summary>
        /// <param name="CarNumber"></param>
        public void DelteBeforeSelf(string CarNumber)
        {
         root.Elements("CarService")
         .Where(e => ((string)e.Attribute("number")) == CarNumber)
         .Single<XElement>().ElementsBeforeSelf().Last().Remove();
           xDoc.Save("CarService.xml");
        }

        /// <summary>
        /// delete after self
        /// </summary>
        /// <param name="CarNumber"></param>
        public void DelteAfterSelf( string CarNumber)
        {
            root.Elements("CarService")
            .Where(e => ((string)e.Attribute("number")) == CarNumber)
            .Single<XElement>().ElementsAfterSelf().First().Remove();
            xDoc.Save("CarService.xml");
        }

        /// <summary>
        /// Change group
        /// </summary>
        /// <param name="mark"></param>
        public void ChangeGroup(Mark mark) 
        {
            foreach (XElement xe in root.Elements("CarService").ToList())
            {          
                    xe.Element("mark").Value = mark.ToString();
            }
            xDoc.Save("CarService.xml");
        }

        /// <summary>
        /// Change xml
        /// </summary>
        /// <param name="numberOfCar"></param>
        /// <param name="name"></param>
        /// <param name="value"></param>
        public void Change(string numberOfCar, string name, string value)
        {
            foreach (XElement xe in root.Elements("CarService").ToList())
            {
                if (xe.Attribute("number").Value == numberOfCar)
                {
                    xe.Element(name).Value = value;
                }
        
            }
            xDoc.Save("CarService.xml");

        }

        /// <summary>
        /// remove node
        /// </summary>
        /// <param name="numberOfCar"></param>
        public void Remove(string numberOfCar)
        {
            foreach (XElement xe in root.Elements("CarService").ToList())
            {
                if (xe.Attribute("number").Value == numberOfCar)
                {
                    xe.Remove();
                }

            }
            xDoc.Save("CarService.xml");
        }


        /// <summary>
        /// menu utils
        /// </summary>
        public void XmlMenu()
        {
   
            Console.WriteLine("1. Добалвение");
            Console.WriteLine("2. изменение");
            Console.WriteLine("3. удаление");
            Console.WriteLine("4. вставить перед заданным");
            Console.WriteLine("5. вставить после заданного");
            Console.WriteLine("6. удаление перед заданным");
            Console.WriteLine("7. удаление после заданного");
            Console.WriteLine("8. изменение группы на указанное значение");
            Console.WriteLine("9. XML-серилизация");
            while (true)
            {
                string a = Console.ReadLine();
                switch (a)
                {
                    case "1":
                       AddElement(AddCarService());
                        Console.WriteLine("готово");
                        break;
                    case "2":
                        Change("6321", "master", "Григорий");
                        Console.WriteLine("готово");
                        break;
                    case "3":
                        Remove("6321");
                        Console.WriteLine("готово");
                        break;

                    case "4":
                        AddBeforeSelf(AddCarService(), "1234");
                        Console.WriteLine("готово");
                        break;

                    case "5":
                        AddAfterSelf(AddCarService(), "1234");
                        Console.WriteLine("готово");
                        break;
                    case "6":
                       DelteBeforeSelf("1234");
                        Console.WriteLine("готово");
                        break;

                    case "7":
                       DelteAfterSelf("1234");
                        Console.WriteLine("готово");
                        break;

                    case "8":
                       DelteBeforeSelf("1234");
                        Console.WriteLine("готово");
                        break;

                    case "9":
                        CarService carService = new CarService(1234, Mark.Acura, 30000, "Василий", 400);
                        CarService carService1 = new CarService(4321, Mark.AstonMartin, 40000, "Петр", 900);
                        CarService[] carServices = new CarService[] { carService, carService1 };
                        XmlSerializer formatter = new XmlSerializer(typeof(CarService[]));


                        using (FileStream fs = new FileStream("carService1.xml", FileMode.OpenOrCreate)) // сохранение xml
                        {
                            formatter.Serialize(fs, carServices);
                        }
                        break;
                }
            }
        }

        /// <summary>
        /// create class carservice
        /// </summary>
        /// <returns></returns>
        public CarService AddCarService()
        {
            Console.WriteLine("введите номер машины");
            int number = int.Parse(Console.ReadLine());

            Console.WriteLine("Выберите машину от 0 до 5");
            Mark mark = (Mark)int.Parse(Console.ReadLine());
            Console.WriteLine(mark + " хороший выбор!" );

            Console.WriteLine("введите пробег машины");
            int mileage = int.Parse(Console.ReadLine());

            Console.WriteLine("введите мастера");
            string master = Console.ReadLine();

            Console.WriteLine("введите сумму");
            int sum = int.Parse(Console.ReadLine());

            return new CarService(number, mark, mileage, master, sum);
        }

    }
}
