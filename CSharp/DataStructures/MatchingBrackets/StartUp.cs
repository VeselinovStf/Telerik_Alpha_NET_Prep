using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MatchingBrackets
{
    public class StartUp
    {
        public static void Main()
        {
            string expresion = Console.ReadLine();
            Stack<int> indexStock = new Stack<int>();

            for (int i = 0; i < expresion.Length; i++)
            {
                char current = expresion[i];
                if (current == '(')
                {
                    indexStock.Push(i);
                }
                if (current == ')')
                {
                    var startIndex = indexStock.Pop();
                    var size = i - startIndex + 1;
                    Console.WriteLine(expresion.Substring(startIndex, size));
                }
            }
        }
    }
}