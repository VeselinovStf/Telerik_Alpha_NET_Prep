using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Day_26_NestedLogic
{
    public class StartUp
    {
        public static void Main()
        {
            int[] actualReturn = Console.ReadLine()
                .Split(' ')
                .Select(int.Parse)
                .ToArray();

            int[] expectedReturn = Console.ReadLine()
                .Split(' ')
                .Select(int.Parse)
                .ToArray();

            int actualDay = actualReturn[0];
            int actualMonth = actualReturn[1];
            int actualYear = actualReturn[2];
            int expectedDay = expectedReturn[0];
            int expectedMonth = expectedReturn[1];
            int expectedYear = expectedReturn[2];
            int monthsLate = actualMonth - expectedMonth;
            int daysLate = actualDay - expectedDay;
            int yearDiference = actualYear - expectedYear;
            Console.WriteLine((actualYear - expectedYear > 0) ? 10000
            : (actualMonth - expectedMonth > 0 && yearDiference == 0) ? monthsLate * 500
                    : (actualDay - expectedDay > 0 && yearDiference == 0) ? daysLate * 15
                            : 0);
        }
    }
}