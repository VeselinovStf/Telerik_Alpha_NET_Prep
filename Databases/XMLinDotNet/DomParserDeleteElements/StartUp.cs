using System;
using System.Xml;

namespace DomParserDeleteElements
{
    public class StartUp
    {
        private static void Main()
        {
            XmlDocument doc;
            doc = new XmlDocument();
            doc.Load("../../cataloque.xml");

            var root = doc.DocumentElement;

            DeleteNode(root);
            PrintXml(root);
        }

        private static void PrintXml(XmlNode root)
        {
            foreach (XmlNode element in root.ChildNodes)
            {
                if (element.Value != null && element.Name != null)
                {
                    Console.WriteLine($"{element.ParentNode.Name.ToUpper()} : {element.Value}");
                }

                PrintXml(element);
            }
        }

        private static void DeleteNode(XmlNode root)
        {
            foreach (XmlNode element in root.ChildNodes)
            {
                if (element.Name.ToString() == "price")
                {
                    var price = int.Parse(element.LastChild.Value);

                    if (price < 20)
                    {
                        root.RemoveAll();
                    }
                }

                DeleteNode(element);
            }
        }
    }
}