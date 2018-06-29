using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BalancedParentheses
{
    public class StartUp
    {
        public static void Main()
        {
            Stack<char> parantheses = new Stack<char>();
            string inputParams = Console.ReadLine();

            string yesResult = "YES";
            string noResult = "NO";

            for (int i = 0; i < inputParams.Length; i++)
            {
                var currentSigh = inputParams[i];

                if (currentSigh == '{' ||
                    currentSigh == '[' ||
                    currentSigh == '(')
                {
                    switch (currentSigh)
                    {
                        case '{':
                            parantheses.Push('}');
                            break;

                        case '[':
                            parantheses.Push(']');
                            break;

                        case '(':
                            parantheses.Push(')');
                            break;

                        default:
                            break;
                    }
                }
                else
                {
                    if (parantheses.Count == 0)
                    {
                        Console.WriteLine(noResult);
                        return;
                    }
                    else
                    {
                        var next = parantheses.Pop();
                        if (currentSigh != next)
                        {
                            Console.WriteLine(noResult);
                            return;
                        }
                    }
                }
            }

            Console.WriteLine(yesResult);
        }
    }
}