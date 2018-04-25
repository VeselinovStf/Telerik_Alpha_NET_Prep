using System.Xml;

namespace XReaderXWriterAction
{
    public class StartUp
    {
        public static void Main()
        {
            using (XmlReader reader = XmlReader.Create("../../cataloque.xml"))
            {
                using (XmlWriter writer = XmlWriter.Create("../../album.xml"))
                {
                    writer.WriteStartElement("albums");

                    while (reader.Read())
                    {
                        if (reader.Name == "name")
                        {
                            writer.WriteStartElement("album");
                            reader.Read();
                            writer.WriteElementString("album-name", reader.Value);
                            reader.Read();
                        }

                        if (reader.Name == "artist")
                        {
                            reader.Read();
                            writer.WriteElementString("author-name", reader.Value);
                            reader.Read();
                            writer.WriteEndElement();
                        }
                    }

                    writer.WriteEndElement();
                }
            }
        }
    }
}