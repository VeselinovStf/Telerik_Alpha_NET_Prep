using System;
using System.Xml;

namespace XMLReaderDemo
{
    public class StartUp
    {
        public static void Main()
        {
            XmlReader reader = XmlReader.Create("../../cataloque.xml");

            while (reader.Read())
            {
                if (reader.Name.ToString() == "title")
                {
                    reader.Read();
                    Console.WriteLine(reader.Value);
                    reader.Read();
                }
            }
        }
    }
}