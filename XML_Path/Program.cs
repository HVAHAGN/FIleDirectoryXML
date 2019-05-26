
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml;

namespace XML_Path
{
    class Program
    {
        static void Main(string[] args)
        {
            XmlDocument xDoc = new XmlDocument();
            xDoc.Load("users.xml");
            XmlElement xRoot = xDoc.DocumentElement;
            XmlNodeList childNodes = xRoot.SelectNodes("*");
            foreach(XmlNode n in childNodes)
            {
                Console.WriteLine(n.OuterXml);
            }

            //Выберем все узлы <user>:
            XmlNodeList childNodes2 = xRoot.SelectNodes("user");

            //Выведем на консоль значения атрибутов name у элементов user:
            XmlNodeList childnodes3 = xRoot.SelectNodes("user");
            foreach(XmlNode n in childnodes3)
            {
                Console.WriteLine(n.SelectSingleNode("@name").Value);
            }
            //Выберем узел, у которого атрибут name имеет значение "Bill Gates":
            XmlNode childnode4 = xRoot.SelectSingleNode("user[@name='Bill Gates']");
            if (childnode4 != null)
            {
                Console.WriteLine(childnode4.OuterXml);
            }
            //Выберем узел, у которого вложенный элемент "company" имеет значение "Microsoft":
            XmlNode childnode5 = xRoot.SelectSingleNode("user[company='Microsoft']");
            if (childnode5 != null)
            {
                Console.WriteLine(childnode5.OuterXml);
            }

            //Допустим, нам надо получить только компании. Для этого надо осуществить выборку вниз по иерархии элементов:
            XmlNodeList childnodes = xRoot.SelectNodes("//user/company");
            foreach(XmlNode n in childnodes)
            {
                Console.WriteLine(n.InnerText);
            }



            Console.ReadLine();
        }
    }
}
