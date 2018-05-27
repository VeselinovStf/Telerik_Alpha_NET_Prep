using System;
using System.Text;

namespace SecretMessage
{
    public class StartUp
    {
        public static void Main()
        {
            string message = Console.ReadLine();

            StringBuilder resultMessage = new StringBuilder();
            for (int i = message.Length - 1; i >= 0; i--)
            {
                char currentSighn = message[i];

                if (char.IsLetter(currentSighn))
                {
                    resultMessage.Append(currentSighn);
                }
            }

            Console.WriteLine(resultMessage.ToString());
        }
    }
}