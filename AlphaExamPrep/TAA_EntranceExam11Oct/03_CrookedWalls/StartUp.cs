using System;
using System.Linq;

namespace _03_CrookedWalls
{
    public class StartUp
    {
        public static void Main()
        {
            int[] inputNums = Console.ReadLine()
                .Split(' ')
                .Select(int.Parse)
                .ToArray();


            int sum = 0;
            int pointer = 1;
            while (pointer <= inputNums.Length -1)
            {
                var currentBuilding = inputNums[pointer];
                var previousBuilding = inputNums[pointer - 1];

                var absoluteDiff = (int)Math.Abs(currentBuilding - previousBuilding);

                if (absoluteDiff % 2 == 0)
                {
                    //two to right
                    sum += absoluteDiff;
                    pointer += 2;
                }
                else
                {
                    pointer += 1;
                }
            }

            Console.WriteLine(sum);
        }
    }
}