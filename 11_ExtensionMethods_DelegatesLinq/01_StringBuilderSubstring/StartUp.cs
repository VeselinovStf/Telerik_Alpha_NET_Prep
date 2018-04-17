using System;
using System.Text;

namespace _01_StringBuilderSubstring
{
    public class StartUp
    {
        public static void Main()
        {
            string testLine = "123456789";
            StringBuilder text = new StringBuilder();
            text.Append(testLine);

            Console.WriteLine(testLine.Substring(2, 4));
            Console.WriteLine(text.Substring(2, 4).ToString());
        }
    }
}