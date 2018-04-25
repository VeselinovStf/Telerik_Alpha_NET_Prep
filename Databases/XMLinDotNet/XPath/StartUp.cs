using System;
using System.Collections.Generic;
using System.Xml;
using System.Xml.XPath;

namespace XPath
{
    public class StartUp
    {
        private static Dictionary<string, int> bandsAlbumCount = new Dictionary<string, int>();

        static void Main()
        {
            XPathNavigator nav;
            XPathDocument docNav;
            XPathNodeIterator nodeIterator;
            String expresion;

            //Open XML
            docNav = new XPathDocument("../../cataloque.xml");
            //Navigator to query XPath
            nav = docNav.CreateNavigator();
            //XPath expresion
            expresion = "artists/album/artist";

            nodeIterator = nav.Select(expresion);
            while (nodeIterator.MoveNext())
            {
                var artist = nodeIterator.Current.Value;

                if (!bandsAlbumCount.ContainsKey(artist))
                {
                    bandsAlbumCount[artist] = 1;
                }
                else
                {
                    bandsAlbumCount[artist]++;
                }
            }

            PrintAlbumsCount();
        }

        private static void PrintAlbumsCount()
        {
            foreach (var band in bandsAlbumCount)
            {
                Console.WriteLine($"{band.Key} got {band.Value} album.");
            }
        }
    }
}
