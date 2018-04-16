using System;

namespace MulticastDelegates
{
    internal delegate void Print(string str);

    internal delegate void MulticastGenericDelegate(string str);

    public class StartUp
    {
        public static void Main()
        {
            string text = "Multicast Delegates";

            Print pr = PrintText;
            pr += PrintFigureText;
            pr += PrintUpperText;

            pr += delegate (string str)
            {
                Console.WriteLine("Add Some more");
            };

            pr(text);

            MulticastGenericDelegate mgd = delegate (string str)
            {
                foreach (var item in str)
                {
                    Console.WriteLine(item + " ");
                }
            };

            mgd += delegate (string str)
            {
                Console.WriteLine(str);
            };

            mgd(text);
        }

        public static void PrintText(string text)
        {
            Console.WriteLine(text);
        }

        public static void PrintFigureText(string text)
        {
            Console.WriteLine("------------");
            Console.WriteLine("---" + text);
            Console.WriteLine("------------");
        }

        public static void PrintUpperText(string text)
        {
            Console.WriteLine(text.ToUpper());
        }
    }
}