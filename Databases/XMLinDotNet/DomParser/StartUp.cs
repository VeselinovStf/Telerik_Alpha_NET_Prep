using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml;

namespace DomParser
{
    public class StartUp
    {

        private static Dictionary<string, int> bandsAlbumCount = new Dictionary<string, int>();

        private static void Main()
        {
            var domParser = new XmlDocument();
            domParser.Load("../../cataloque.xml");

            var root = domParser.DocumentElement;

            CountAlbums(root);
            PrintAlbumsCount();
        }

        private static void PrintAlbumsCount()
        {
            foreach (var band in bandsAlbumCount)
            {
                Console.WriteLine($"{band.Key} got {band.Value} album.");
            }
        }

        private static void CountAlbums(XmlNode node)
        {
            foreach (XmlNode element in node.ChildNodes)
            {
                if (element.Name.ToString() == "artist")
                {
                    var band = element.LastChild.Value;
                    if (!bandsAlbumCount.ContainsKey(band))
                    {
                        bandsAlbumCount[band] = 1;
                    }
                    else
                    {
                        bandsAlbumCount[band]++;
                    }
                }

                CountAlbums(element);
            }
        }
    }
}
