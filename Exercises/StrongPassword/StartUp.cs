using System;
using System.IO;

namespace StrongPassword
{
    public class StartUp
    {
        public static void FakeInput()
        {
            string input = @"4
4700";

            Console.SetIn(new StringReader(input));
        }

        public static int minimumNumber(int n, string password)
        {
            var numbers = "0123456789";
            var lower_case = "abcdefghijklmnopqrstuvwxyz";
            var upper_case = "ABCDEFGHIJKLMNOPQRSTUVWXYZ";
            var special_characters = "!@#$%^&*()-+";
            var result = 0;

            bool gotNumber = FindElement(password, numbers);
            bool gotLower = FindElement(password, lower_case);
            bool gotUpper = FindElement(password, upper_case);
            bool gotSpecial = FindElement(password, special_characters);

            if (!gotNumber)
            {
                result++;
            }
            if (!gotLower)
            {
                result++;
            }
            if (!gotUpper)
            {
                result++;
            }
            if (!gotSpecial)
            {
                result++;
            }

            return Math.Max(result, 6 - n);
        }

        private static bool FindElement(string password, string element)
        {
            bool result = false;
            for (int i = 0; i < element.Length; i++)
            {
                var current = element[i];
                if (password.IndexOf(current) != -1)
                {
                    result = true;
                }
            }
            return result;
        }

        public static void Main()
        {
            TextWriter textWriter = new StreamWriter("result.txt");

            FakeInput();
            int n = Convert.ToInt32(Console.ReadLine());

            string password = Console.ReadLine();

            int answer = minimumNumber(n, password);

            textWriter.WriteLine(answer);
            Console.WriteLine(answer);

            textWriter.Flush();
            textWriter.Close();
        }
    }
}