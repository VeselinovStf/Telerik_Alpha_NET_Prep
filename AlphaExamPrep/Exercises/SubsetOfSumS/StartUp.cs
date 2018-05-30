using System;
using System.Linq;

namespace SubsetOfSumS
{
    public  class StartUp
    {
        public static void Main()
        {
            int searchSum = int.Parse(Console.ReadLine());

            int[] arr = Console.ReadLine()
                .Split(' ')
                .Select(int.Parse)
                .ToArray();

            bool isSum = false;
            int currentSum = 0;
            for (int i = 0; i < arr.Length; i++)
            {
                currentSum = arr[i];
                for (int j = i+1; j < arr.Length; j++)
                {
                    if (currentSum == searchSum)
                    {
                        break;
                    }

                    if (currentSum + arr[j] <= searchSum)
                    {
                        currentSum += arr[j];
                    }
                    
                }

                if (currentSum == searchSum)
                {
                    isSum = true;
                    break;
                }
            }

            if (isSum)
            {
                Console.WriteLine("yes");
            }
            else
            {
                Console.WriteLine("no");
            }
        }
    }
}