using SimplyLazyExtensions_V01;
using System;

namespace DemoExtensionMethods
{
    public class StartUp
    {
        public static void Main(string[] args)
        {
            //Parse
            Console.WriteLine("Extension Methods");
            string input = "1 2 3 4 5 6";
            int[] inputLines = input.StringToIntArrayn(new char[] { ' ' });
            inputLines.WriteLineCollection();

            Console.WriteLine("Demo 2");
            input.StringToIntArrayn(new char[] { ' ' }).WriteLineCollection();

            //Console.WriteLine("Demo 3");
            //Console.ReadLine().StringToIntArrayn(new char[] { ' ' }).WriteLineCollection();

            Console.WriteLine("Demo 4");
            input.StringToIntArrayn(new char[] { ' ' }).WriteCollection("-");
        }
    }
}