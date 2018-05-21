using System;
using System.Collections.Generic;
using System.Text;

namespace SignalFromSpace
{
    public class StartUp
    {
        public static void Main()
        {
            string message = Console.ReadLine();

            StringBuilder result = new StringBuilder();

            char testLetter = message[0];
            for (int i = 1; i < message.Length; i++)
            {
                char nextLetter = message[i];
                if (testLetter != nextLetter)
                {
                    result.Append(testLetter);
                    testLetter = nextLetter;
                }

                if (i == message.Length - 1)
                {

                }
            }

            Console.WriteLine(result.ToString());
        }
    }
}