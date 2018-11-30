using System;
using System.Linq;
using System.Text;

namespace SpellCaster
{
    public class StartUp
    {
        public static void Main()
        {
            string[] words = Console.ReadLine()
                .Split(' ');

            StringBuilder extractedChars = GetNewWord(words);

            int pointer = 0;
            while (pointer < extractedChars.Length)
            {
                char currentLetterToMove = extractedChars[pointer];
                int currentLetterMoveIndex = ((Char.ToLower(extractedChars[pointer]) - 96) + pointer) % extractedChars.Length;
             
                char temp = extractedChars[pointer];
                extractedChars.Remove(pointer, 1);
                extractedChars.Insert(currentLetterMoveIndex, temp);
                
                pointer++;
            }

            Console.WriteLine(extractedChars.ToString());
        }

        private static StringBuilder GetNewWord(string[] words)
        {
            StringBuilder result = new StringBuilder();

            while (true)
            {

                if (words.Any(x => x.Length > 0))
                {
                    for (int i = 0; i < words.Length; i++)
                    {
                        if (words[i].Length > 0)
                        {
                            result.Append(words[i].Substring(words[i].Length - 1, 1));
                            words[i] = words[i].Remove(words[i].Length - 1, 1);
                        }

                    }
                }
                else
                {
                    break;
                }
            }

            return result;
        }
    }

   

}



