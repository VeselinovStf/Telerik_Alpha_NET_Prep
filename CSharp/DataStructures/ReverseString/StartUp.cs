using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ReverseString
{
    public class StartUp
    {
        public static void Main()
        {
            string inputWord = Console.ReadLine();

            Stack<char> letters = new Stack<char>();

            for (int i = 0; i < inputWord.Length; i++)
            {
                letters.Push(inputWord[i]);
            }

            string reversed = string.Empty;
            for (int i = 0; i < inputWord.Length; i++)
            {
                reversed += letters.Pop();
            }

            Console.WriteLine(reversed);
        }
    }
}
