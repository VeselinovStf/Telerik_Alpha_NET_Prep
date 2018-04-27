namespace TelerikRSS.Settings
{
    public static class ConstValues
    {
        // Path to rss feed
        public const string RSS_FEED_PATH = @"https://www.youtube.com/feeds/videos.xml?channel_id=UCLC-vbm7OWvpbqzXaoAMGGw";

        // XML save file path
        public const string XML_RSS_FILE_PATH = "../../rss.txt";

        //HTML output file path
        public const string HTML_FILE_PATH = "../../index.html";

        // Messages to user
        public const string START_MESSAGE = "Starting....";

        public const string DOWNLOAD_SUCCES_RSS = "RSS download done!File saved!";
    }
}