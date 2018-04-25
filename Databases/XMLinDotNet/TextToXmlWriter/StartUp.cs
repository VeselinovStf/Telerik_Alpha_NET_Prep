using System.Collections.Generic;
using System.IO;
using System.Xml;

namespace TextToXmlWriter
{
    public class StartUp
    {
        public static List<string> readedText = new List<string>();

        public static void Main()
        {
            using (StreamReader reader = new StreamReader("../../personInfo.txt"))
            {
                while (reader.Peek() >= 0)
                {
                    var line = reader.ReadLine();
                    readedText.Add(line);
                }
            }

            string filename = "personData.xml";
            WriteToXml(filename);
        }

        private static void WriteToXml(string filename)
        {
            using (XmlWriter writer = XmlWriter.Create(filename))
            {
                writer.WriteStartElement("persons");
                writer.WriteStartElement("person");

                writer.WriteElementString("name", readedText[0]);
                writer.WriteElementString("address", readedText[1]);
                writer.WriteElementString("phone", readedText[2]);

                writer.WriteEndElement();
            }
        }

        private static void GetTextFromFile()
        {
        }
    }
}