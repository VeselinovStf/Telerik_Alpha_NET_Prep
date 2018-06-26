using System;
using System.Collections.Generic;
using System.IO;

namespace BalancedBrackets
{
    //    A bracket is considered to be any one of the following characters: (, ), {, }, [, or].

    //Two brackets are considered to be a matched pair if the an opening bracket(i.e.,
    //(, [, or {) occurs to the left of a closing bracket(i.e., ), ], or }) of the exact same type.
    //There are three types of matched pairs of brackets: [], {}, and().
    //A matching pair of brackets is not balanced if the set of brackets it encloses are not matched.
    //For example, {[(])} is not balanced because the contents in between { and } are not balanced.
    //The pair of square brackets encloses a single, unbalanced opening bracket, (, and the pair of parentheses encloses a single, unbalanced closing square bracket, ].

    //By this logic, we say a sequence of brackets is balanced if the following conditions are met:

    //It contains no unmatched brackets.
    //The subset of brackets enclosed within the confines of a matched pair of brackets is also a matched pair of brackets.
    //Given strings of brackets, determine whether each sequence of brackets is balanced.If a string is balanced, return YES.Otherwise, return NO.
    public class StartUp
    {
        private static string isBalanced(string s)
        {
            string yesResult = "YES";
            string noResult = "NO";

            Stack<char> elements = new Stack<char>();

            if (s.Length % 2 != 0)
            {
                return noResult;
            }

            if (s.Length < 0)
            {
                return noResult;
            }

            for (int i = 0; i < s.Length; i++)
            {
                var element = s[i];
                if (element == '{' || element == '(' || element == '[')
                {
                    switch (element)
                    {
                        case '{':
                            elements.Push('}');
                            break;

                        case '(':
                            elements.Push(')');
                            break;

                        case '[':
                            elements.Push(']');
                            break;

                        default:
                            break;
                    }
                }
                else
                {
                    if (elements.Count == 0)
                    {
                        return noResult;
                    }
                    var sign = elements.Peek();

                    if (element != sign)
                    {
                        return noResult;
                    }
                    elements.Pop();
                }
            }

            if (elements.Count > 0)
            {
                return noResult;
            }

            return yesResult;
        }

        public static void Main()
        {
            TextWriter textWriter = new StreamWriter("test.txt");

            int t = Convert.ToInt32(Console.ReadLine());

            for (int tItr = 0; tItr < t; tItr++)
            {
                string s = Console.ReadLine();

                string result = isBalanced(s);

                textWriter.WriteLine(result);
            }

            textWriter.Flush();
            textWriter.Close();
        }
    }
}