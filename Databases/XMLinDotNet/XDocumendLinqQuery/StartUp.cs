using System;
using System.Xml;
using System.Xml.Linq;
using System.Linq;

namespace XDocumendLinqQuery
{
    public class StartUp
    {
        public static void Main()
        {
            XDocument doc = XDocument.Load("../../cataloque.xml");

            var songs = from song in doc.Descendants("title")              
                        select song;

            foreach (var title in songs)
            {
                Console.WriteLine(title.Value);
            }
           
        }
    }
}
