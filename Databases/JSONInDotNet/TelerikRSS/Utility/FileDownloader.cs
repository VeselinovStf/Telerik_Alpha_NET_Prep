using System;
using System.Net;

namespace TelerikRSS.Utility
{
    public static class FileDownloader
    {
        public static void DownloadWebFile(string path, string fileName)
        {
            using (WebClient webClien = new WebClient())
            {
                try
                {
                    webClien.DownloadFile(path, fileName);
                }
                catch (ArgumentNullException e)
                {
                    throw new ArgumentNullException(e.Message);
                }
                catch (WebException e)
                {
                    throw new WebException(e.Message);
                }
                catch (NotSupportedException e)
                {
                    throw new NotSupportedException(e.Message);
                }
            }
        }
    }
}