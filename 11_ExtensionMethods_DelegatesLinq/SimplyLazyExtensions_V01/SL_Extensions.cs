using System;
using System.Collections.Generic;
using System.Linq;

namespace SimplyLazyExtensions_V01
{
    public static class SL_Extensions
    {
        public static int[] StringToIntArrayn(this string line, char[] splitItems)
        {
            var result = line
                .Split(splitItems, StringSplitOptions.RemoveEmptyEntries)
                .Select(int.Parse)
                .ToArray();

            return result;
        }

        public static void WriteLineCollection<T>(this IEnumerable<T> collection)
        {
            foreach (var item in collection)
            {
                Console.WriteLine(item);
            }
        }

        public static void WriteCollection<T>(this IEnumerable<T> collection, string separator)
        {
            Console.WriteLine(string.Join(separator, collection));
        }
    }
}