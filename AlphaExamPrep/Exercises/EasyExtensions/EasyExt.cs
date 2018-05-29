using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EasyExtensions
{
    /// <summary>
    /// Extension methods to simplify work process
    /// </summary>
    public static class EasyExt
    {
        public static int[] SplitInputToIntArray(this string input)
        {
            return input
                .Split(new char[] { ' ', '-', ',' }
                , StringSplitOptions
                .RemoveEmptyEntries)
                .Select(int.Parse)
                .ToArray();
        }
    }
}
