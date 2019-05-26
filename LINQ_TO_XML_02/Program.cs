using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml;
using System.Xml.Linq;

namespace LINQ_TO_XML_02
{
    class Program
    {
        static void Main(string[] args)
        {
            XDocument xdoc = XDocument.Load("phones.xml");

            foreach(XElement phoneElement in xdoc.Element("phones").Elements("phone"))
            {
                XAttribute nameAttribute = phoneElement.Attribute("name");
                XElement companyElement = phoneElement.Element("company");
                XElement priceElement = phoneElement.Element("price");
                if (nameAttribute != null && companyElement != null && priceElement != null)
                {
                    Console.WriteLine("Smartphone: {0}", nameAttribute.Value);
                    Console.WriteLine("Company: {0} ", companyElement.Value);
                    Console.WriteLine("Price: {0} ", priceElement.Value);
                }

            }
            Console.WriteLine(new string('*',50));

            XDocument doc = XDocument.Load("phones.xml");
            var items = from xe in doc.Element("phones").Elements("phone")
                        where xe.Element("company").Value == "Samsung"
                        select new Phone
                        {
                            Name = xe.Attribute("name").Value,
                            Price = xe.Element("price").Value

                        };

            foreach (var item in items)
            {
                Console.WriteLine("{0} - {1}", item.Name, item.Price);
            }



            Console.ReadLine();
        }
    }
}
