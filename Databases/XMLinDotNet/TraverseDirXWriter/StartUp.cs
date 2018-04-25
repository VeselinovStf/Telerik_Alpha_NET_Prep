using System;
using System.Collections.Generic;
using System.IO;
using System.Xml;

namespace TraverseDirXWriter
{
    public class StartUp
    {
        public static void Main()
        {
            string dirPath = @"C:\Program Files (x86)";
            string exportXmlFile = "../../direcrotyEnum.xml";

            using (XmlWriter writer = XmlWriter.Create(exportXmlFile))
            {
                try
                {
                    List<string> dirs = new List<string>(Directory.EnumerateDirectories(dirPath));
                    List<string> files = new List<string>(Directory.EnumerateFiles(dirPath));

                    writer.WriteStartElement("dir-enumeration");
                    writer.WriteStartElement("directories");
                    foreach (var dir in dirs)
                    {
                        writer.WriteElementString("dir", dir.Substring(dir.LastIndexOf("\\") + 1));
                        //writer.WriteEndElement();
                    }
                    writer.WriteEndElement();

                    writer.WriteStartElement("files");
                    foreach (var file in files)
                    {
                        writer.WriteElementString("file", file.Substring(file.LastIndexOf("\\") + 1));
                        //writer.WriteEndElement();
                    }

                    writer.WriteEndElement();
                }
                catch (UnauthorizedAccessException UAEx)
                {
                    Console.WriteLine(UAEx.Message);
                }
                catch (PathTooLongException PathEx)
                {
                    Console.WriteLine(PathEx.Message);
                }
            }
        }
    }
}