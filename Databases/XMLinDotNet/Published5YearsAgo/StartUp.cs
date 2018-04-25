using System;
using System.Xml.XPath;

namespace Published5YearsAgo
{
    public class StartUp
    {
        public static void Main()
        {
            XPathDocument docNav = new XPathDocument("../../cataloque.xml");
            XPathNavigator nav = docNav.CreateNavigator();

            string xpath = "artists/album/year";
            XPathNodeIterator iterator = nav.Select(xpath);

            while (iterator.MoveNext())
            {
                int publishingDate = int.Parse(iterator.Current.Value);
                if (publishingDate >= DateTime.Now.Year - 5)
                {
                    Console.WriteLine(publishingDate);
                }
            }
        }
    }
}