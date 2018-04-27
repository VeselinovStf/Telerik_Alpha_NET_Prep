using Newtonsoft.Json;
using Newtonsoft.Json.Linq;
using System;
using System.Collections.Generic;
using System.Linq;

using System.Xml.Linq;
using TelerikRSS.Common;
using TelerikRSS.Contracts;
using TelerikRSS.Settings;
using TelerikRSS.Utility;

namespace TelerikRSS
{
    public class StartUp
    {
        private static CLIRenderer cliRenderer = new CLIRenderer();

        public static void Main()
        {
            cliRenderer.ConsolePrint(ConstValues.START_MESSAGE);

            FileDownloader.DownloadWebFile(ConstValues.RSS_FEED_PATH, ConstValues.XML_RSS_FILE_PATH);

            var fileContent = FileReader.ReadFile(ConstValues.XML_RSS_FILE_PATH);

            var xml = XDocument.Parse(fileContent);
            var json = JsonConvert.SerializeXNode(xml);

            var allVideoTitles = SelectAllVideoTitles(json);
            PrintTitles(allVideoTitles);

            var pocoObject = CreatePocoObject(json);
            CreateHtmlPage(pocoObject);
        }

        private static IList<IListItem> CreatePocoObject(string json)
        {
            var jParse = JObject.Parse(json);

            var itemsTitle = jParse["feed"]["entry"];
            

            var pocoObject = new List<IListItem>();
            foreach (var item in itemsTitle)
            {
                var deserializedObject = JsonConvert.DeserializeObject<Item>(item.ToString());
                pocoObject.Add(deserializedObject);
                Console.WriteLine(deserializedObject);
            }


            var itemsUrl = jParse["feed"]["entry"].ToList().Select(x => x["media:group"]);
            var links = new List<IListItem>();
            foreach (var mediaGroup in itemsUrl)
            {
                var mediaContent = mediaGroup["media:content"];
                //Console.WriteLine(mediaContent);
                var deserializedObject = JsonConvert.DeserializeObject<Item>(mediaContent.ToString());
                links.Add(deserializedObject);
            }

            //TODO
            for (int i = 0; i < pocoObject.Count; i++)
            {
                pocoObject[0].URL = links[0].URL;
            }
            return pocoObject;
        }

        private static void PrintTitles(IEnumerable<object> allVideoTitles)
        {
            foreach (var item in allVideoTitles)
            {
                Console.WriteLine(item);
            }
        }

        private static IEnumerable<object> SelectAllVideoTitles(string json)
        {
            var jParse = JObject.Parse(json);
            var titles = jParse["feed"]["entry"].Select(x => x["title"]);

            return titles;
        }

        private static void CreateHtmlPage(IList<IListItem> pocoObjects)
        {
            var htmlGenerator = new HtmlPageGenerator();
            htmlGenerator.CreateHtmlPage(ConstValues.HTML_FILE_PATH, pocoObjects);

            Console.WriteLine("\n-> Html page was created successfully...\n");
        }

        //OLD MESS UP LOGIC
        //public static List<string> links = new List<string>();
        //public static void Main()
        //{
        //    //string rssFeed = @"https://www.youtube.com/feeds/videos.xml?channel_id=UCLC-vbm7OWvpbqzXaoAMGGw";
        //    //var client = new WebClient();
        //    //string fileName = "rss.xml";
        //    //client.DownloadFile(rssFeed, fileName);

        //    //var doc = new XmlDocument();
        //    //doc.Load(fileName);

        //    //var jsonConvert = JsonConvert.SerializeXmlNode(doc);
        //    //var obj = JObject.Parse(jsonConvert);

        //    //GetAllNeadedLinks(obj);

        //}

        //private static void GetAllNeadedLinks(JObject obj)
        //{
        //    var entryes = obj["feed"]["entry"].ToList().Select(x => x["media:group"]);
        //    foreach (JObject mediaGroup in entryes)
        //    {
        //        var mediaContent = mediaGroup["media:content"]["@url"];
        //        links.Add(mediaContent.ToString());
        //    }
        //}
    }
}