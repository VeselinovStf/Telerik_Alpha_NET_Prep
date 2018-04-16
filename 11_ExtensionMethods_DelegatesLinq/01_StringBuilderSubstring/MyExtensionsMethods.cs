using System;
using System.Text;

namespace _01_StringBuilderSubstring
{
    public static class MyExtensionsMethods
    {
        public static StringBuilder Substring(this StringBuilder str, int index, int length)
        {
            StringBuilder result = new StringBuilder();

            int newStringLength = index + length;
            if (index < 0 || length < 0)
            {
                throw new ArgumentException("Index and length cant be negative");
            }

            if (newStringLength > str.Length)
            {
                throw new ArgumentException("Start String + Length are bigger than a string length");
            }
            else
            {
                for (int i = index; i < newStringLength; i++)
                {
                    result.Append(str[i] + "-");
                }
            }

            return result;
        }
    }
}