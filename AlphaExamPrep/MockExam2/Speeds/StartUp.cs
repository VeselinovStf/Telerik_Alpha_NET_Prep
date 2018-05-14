/* You are given a sequence of the speeds of cars in a single-lane street.
 * A car can catch up to the car B, only if B is in front of A and the 
 * speed of A is greater than the speed of B, and then the speed of A is 
 * lowered to the speed of B. Each gathering of cars is called a group.
 * Your task is to find the sum of the initial speeds of the longest group 
 * of cars (the group with most cars in it). If more than one group with 
 * equal length exists, then find the biggest sum of the initial speeds of 
 * these groups.
 */

using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Speeds
{
    public class StartUp
    {
        public static void FakeInput()
        {
            string input = @"4
1
1
1
1";

            Console.SetIn(new StringReader(input));
        }
        public static void Main()
        {
           // FakeInput();

            int n = int.Parse(Console.ReadLine());
            bool isFirst = true;
            int lastSpeed = -1;
            int speed = 0;

            int bestSum = 0;
            int bestLen = 0;

            int currentSum = 0;
            int currentLen = 0;

            bool isUpdated = false;

            for (int i = 0; i < n; i++)
            {
                speed = int.Parse(Console.ReadLine());
                isUpdated = false;
                if (isFirst)
                {
                    isFirst = false;
                    lastSpeed = speed;
                    currentLen = 1;
                    currentSum = speed;
                }
                else if (lastSpeed >= speed)
                {
                    lastSpeed = speed;
                    isUpdated = true;
                    if (currentLen > bestLen)
                    {
                        bestSum = currentSum;
                        bestLen = currentLen;
                    }
                    else if (currentLen == bestLen)
                    {
                        bestSum = (bestSum > currentSum) ? bestSum : currentSum;
                    }
                    currentSum = speed;
                    currentLen = 1;
                }
                else
                {
                    ++currentLen;
                    currentSum += speed;
                }
            }

            if (!isUpdated)
            {
                if (currentLen > bestLen)
                {
                    bestSum = currentSum;
                    bestLen = currentLen;
                }
                else if (currentLen == bestLen)
                {
                    bestSum = (bestSum > currentSum) ? bestSum : currentSum;
                }
            }

            Console.WriteLine(bestSum);
        }
    }
}
