using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Linq;
using System.Xml;

namespace LINQ_TO_XML_03
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
                if (xe.Attribute("name").Value == "SamsungGalaxy")
                {
                    xe.Attribute("name").Value = "Samsung Galaxy Note 4";
                    xe.Element("price").Value = "450005";
                }
                else if (xe.Attribute("name").Value == "iphone6")
                {
                    xe.Remove();
                }
            }
            // добавляем новый элемент
            root.Add(new XElement("phone",
                new XAttribute("name", "Nokia Luna"),
                new XElement("company", "Nokia"),
                new XElement("price", "8800")));

            xdoc.Save("phones.xml");
            Console.WriteLine(xdoc);



            Console.ReadLine();
        }
    }
}
