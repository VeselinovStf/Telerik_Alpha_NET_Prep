using System;
using System.Linq;

namespace TelescopicArray
{
    public class StartUp
    {
        static void Main(string[] args)
        {
            int[] inputArray = Console.ReadLine()
                .Split(new char[] { ' ' }, StringSplitOptions.RemoveEmptyEntries)
                .Select(int.Parse).ToArray();

            bool result = isTelescopic(inputArray);

            Console.WriteLine(result ? "telescopic" : "not telescopic");
        }

        public static bool isTelescopic(int[] arr)
        {
            //IF elements must be 1 2 2 1, aways eaven
           
            if (arr.Length % 2 == 1)
            {
                return false;
            }

            //If its outer elements are 1's,
            if (arr[0] != 1)
            {
                return false;
            }

           
            var current = 1;
            for (int i = 0; i < arr.Length / 2; i++)
            {
                if (arr[i] != arr[arr.Length - 1 - i] && arr[i] == current)
                {
                    return false;
                }

                // then the next inner elements are 2's and so on.
                current++;
            }

            return true;
        }
    }
}
