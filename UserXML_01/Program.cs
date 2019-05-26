using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml;

namespace UserXML_01
{
    class Program
    {
        static void Main(string[] args)
        {
            List<User> users = new List<User>();
            XmlDocument xDoc = new XmlDocument();
          

            xDoc.Load("users.xml");

            // // получим корневой элемент
            XmlElement xRoot = xDoc.DocumentElement;
            //// обход всех узлов в корневом элементе
            foreach (XmlNode xNode in xRoot)
            {
                User user = new User();
                // // получаем атрибут name
               
                    XmlNode attr = xNode.Attributes.GetNamedItem("name");
                    if (attr != null)
                    {
                        user.Name = attr.Value;
                        //Console.WriteLine(attr.Value);
                    }
                
                // обходим все дочерние узлы элемента user
                foreach (XmlNode childNode in xNode.ChildNodes)
                {
                    if (childNode.Name == "company")
                    {
                        user.Company = childNode.Name;
                        Console.WriteLine("Company: {0} ", childNode.InnerText);

                    }
                    if (childNode.Name == "age")
                    {
                        user.Age = Int32.Parse(childNode.InnerText);
                        Console.WriteLine("Age is {0}", childNode.InnerText);
                    }
                   
                }
                Console.WriteLine();

            }

            
            Console.ReadLine();
        }
    }
}
