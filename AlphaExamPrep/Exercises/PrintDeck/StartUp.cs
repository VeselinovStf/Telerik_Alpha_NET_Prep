using System;
using System.Collections.Generic;

namespace PrintDeck
{
    public class StartUp
    {
        public static void Main()
        {
            string sign =Console.ReadLine();

            string[] letterCards = { "J", "Q", "K", "A" };

            var format = "{0} of spades, {0} of clubs, {0} of hearts, {0} of diamonds";

            if (Char.IsDigit(sign[0]))
            {
                PrintNummericCards(int.Parse(sign), format);          
            }
            else
            {
                int count = Array.IndexOf(letterCards, sign);
                PrintNummericCards(10, format);
                PrintLetterCards(count, letterCards, format);
            }
            
          

        }

        private static void PrintLetterCards(int count, string[] letterCards, string format)
        {
            for (int i = 0; i <= count; i++)
            {
                Console.WriteLine(format, letterCards[i]);
            }
        }

        private static void PrintNummericCards(int n, string format)
        {
            for (int i = 2; i <= n; i++)
            {
                Console.WriteLine(format, i);
            }
        }
    }
}