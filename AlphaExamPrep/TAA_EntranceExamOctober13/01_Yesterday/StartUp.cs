/*
 * By a provided date (year, month, day), calculate the day before.
 * 
 */

using System;
using System.Globalization;

namespace _01_Yesterday
{
    public class StartUp
    {
        public static void Main()
        {

            string inputYear = Console.ReadLine();
            string inputMonth = Console.ReadLine();
            string inputDay = Console.ReadLine();

            string s = inputDay + "-" + inputMonth + "-" + inputYear;
            string format = "dd-M-yyyy";
            var provider = CultureInfo.InvariantCulture;

            DateTime currentInputDate = DateTime.ParseExact(s, format, provider);

            var newDate = currentInputDate.Subtract(TimeSpan.FromDays(1));

            Console.WriteLine(newDate.ToString("d-MMM-yyy"));
        }
    }
}