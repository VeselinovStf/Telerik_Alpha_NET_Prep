using System;
using System.IO;
using System.Text;

namespace CaesarCipher
{
    class Program
    {
        static string caesarCipher(string s, int k)
        {
            StringBuilder result = new StringBuilder();

            foreach (var sign in s)
            {
                if (char.IsUpper(sign))
                {
                    char newLetter = GetNewLetter(sign, 65, k);
                    result.Append(newLetter);
                }
                else if (char.IsLower(sign))
                {
                    char newLetter = GetNewLetter(sign, 97, k);
                    result.Append(newLetter);
                }
                else
                {
                    result.Append(sign);
                }
            }
            return result.ToString();


        }

      
        private static char GetNewLetter(char sign, int v, int k)
        {
            var result = k + ((sign - v) +v) % 26;          
            char newChar = Convert.ToChar(result);

            return newChar;
        }

        static void Main(string[] args)
        {
            TextWriter textWriter = new StreamWriter("result.txt");

            int n = Convert.ToInt32(Console.ReadLine());

            string s = Console.ReadLine();

            int k = Convert.ToInt32(Console.ReadLine());

            string result = caesarCipher(s, k);

            textWriter.WriteLine(result);
            Console.WriteLine(result);

            textWriter.Flush();
            textWriter.Close();
        }
    }
}
