using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml;

namespace UserXML_02
{
    class Program
    {
        static void Main(string[] args)
        {
            XmlDocument xDoc = new XmlDocument();
            xDoc.Load("users.xml");
            XmlElement xRoot = xDoc.DocumentElement;
            //// создаем новый элемент user
            XmlElement userElem = xDoc.CreateElement("user");
            //// создаем атрибут name
            XmlAttribute nameAttr = xDoc.CreateAttribute("name");
            // создаем элементы company и age
            XmlElement companyElem = xDoc.CreateElement("company");
            XmlElement ageElem = xDoc.CreateElement("age");

            // создаем текстовые значения для элементов и атрибута
            XmlText nameText = xDoc.CreateTextNode("Mark Zuckerberg");
            XmlText companyText = xDoc.CreateTextNode("Facebook");
            XmlText ageText = xDoc.CreateTextNode("31");

            //добавляем узлы
            nameAttr.AppendChild(nameText);
            companyElem.AppendChild(companyText);
            ageElem.AppendChild(ageText);

            userElem.Attributes.Append(nameAttr);
            userElem.AppendChild(companyElem);
            userElem.AppendChild(ageElem);
            xRoot.AppendChild(userElem);
            xDoc.Save("users.xml");

            XmlDocument xDoc2 = new XmlDocument();
            xDoc2.Load("users.xml");
            XmlElement xRoot2 = xDoc2.DocumentElement;
            XmlNode firstNode = xRoot2.FirstChild;
            xRoot2.RemoveChild(firstNode);
            xDoc2.Save("users.xml");
            Console.ReadLine();
        }
    }
}
