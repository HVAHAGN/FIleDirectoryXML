using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml;
using System.Xml.Linq;


namespace LINQ_TO_XML
{
    class Program
    {
        static void Main(string[] args)
        {
            XDocument xdoc = new XDocument();
            XElement iphone6 = new XElement("phone");
            XAttribute iphoneNameAttr = new XAttribute("name", "iphone6");
            XElement iphoneCompanyElem = new XElement("company", "Apple");
            XElement iphonePriceElem = new XElement("price", "4000");
            // добавляем атрибут и элементы в первый элемент
            iphone6.Add(iphoneNameAttr);
            iphone6.Add(iphoneCompanyElem);
            iphone6.Add(iphonePriceElem);

            // создаем второй элемент
            XElement galaxy5 = new XElement("phone");
            XAttribute galaxyNameAttr = new XAttribute("name", "SamsungGalaxy");
            XElement galaxyCompanyElem = new XElement("company", "Samsung");
            XElement galaxyPriceElem = new XElement("price", "4500");
            galaxy5.Add(galaxyNameAttr);
            galaxy5.Add(galaxyCompanyElem);
            galaxy5.Add(galaxyPriceElem);
            // создаем корневой элемент
            XElement phones = new XElement("phones");
            phones.Add(iphone6);
            phones.Add(galaxy5);

            // добавляем корневой элемент в документ
            xdoc.Add(phones);
            xdoc.Save("phones.xml");

            ////****************************
            ///
            XDocument doc = new XDocument(
                new XElement("phone",
                new XAttribute("name", "iphone6"),
                new XElement("company", "Apple"),
                new XElement("price", "4000")),

                new XElement("phone",
                new XAttribute("name", "Samsung Galaxy5"),
                new XElement("company", "Samsung"),
                new XElement("price", "5000")));
            doc.Save("phones.xml");



            Console.ReadLine();
        }
    }
}
