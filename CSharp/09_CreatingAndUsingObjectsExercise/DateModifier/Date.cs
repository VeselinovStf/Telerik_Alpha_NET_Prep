using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;

namespace DateModifier
{
    public class Date
    {
       public static void DateModifier(string dateOne, string dateTwo)
        {
            var date1StrArr = dateOne.Split(' ').Select(int.Parse).ToArray();
            var date2StrArr = dateTwo.Split(' ').Select(int.Parse).ToArray(); ;

            DateTime date1 = new DateTime(date1StrArr[0], date1StrArr[1], date1StrArr[2]);
            DateTime date2 = new DateTime(date2StrArr[0], date2StrArr[1], date2StrArr[2]);

            TimeSpan difference = date1.Subtract(date2);

            Console.WriteLine(Math.Abs(difference.TotalDays));
        }
    }
}
