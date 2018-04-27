using System;
using TelerikRSS.Contracts;

namespace TelerikRSS.Common
{
    public class CLIRenderer : ICLIRenderer
    {
        public void ConsolePrint(string data)
        {
            Console.WriteLine(data);
        }
    }
}