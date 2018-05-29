using System;

namespace MazeRunner
{
    public class StartUp
    {
        public static void Main()
        {
            int n = int.Parse(Console.ReadLine());

            for (int i = 0; i < n; i++)
            {
                string number = Console.ReadLine();

                int oddSum = 0;
                int eavenSum = 0;

                for (int j = 0; j < number.Length; j++)
                {
                    int num = (int)char.GetNumericValue(number[j]);

                    if (num % 2 == 0)
                    {
                        eavenSum += num;
                    }
                    else
                    {
                        oddSum += num;
                    }
                }

                if (eavenSum > oddSum)
                {
                    Console.WriteLine("left");
                }
                else if (oddSum > eavenSum)
                {
                    Console.WriteLine("right");
                }
                else
                {
                    Console.WriteLine("straight");
                }
            }
        }

    }
}