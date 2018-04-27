using System.IO;
using System.Text;

namespace TelerikRSS.Utility
{
    public static class FileReader
    {
        public static string ReadFile(string path)
        {
            if (!File.Exists(path))
            {
                throw new FileNotFoundException("File not found: " + path);
            }

            StringBuilder content = new StringBuilder();

            using (StreamReader reader = new StreamReader(path))
            {
                content = content.Append(reader.ReadToEnd());
            }

            return content.ToString();
        }
    }
}