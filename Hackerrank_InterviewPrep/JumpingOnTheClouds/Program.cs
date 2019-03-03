using System;

namespace JumpingOnTheClouds
{
    public class Program
    {
        public static int jumpingOnClouds(int[] c)
        {
            var totalJumps = 0;
            var currentPosition = 0;
            for (int i = 0; i < c.Length; i++)
            {
                if (currentPosition + 2 == c.Length - 1)
                {
                    break;
                }

                var next = currentPosition + 2;
                if (c[next] == 0 || next > c.Length)
                {
                    currentPosition = next;
                    totalJumps++;
                }
                else
                {
                    currentPosition = next - 1;
                    totalJumps++;
                }
            }

            return totalJumps;
        }

        public static void Main(string[] args)
        {
            int n = Convert.ToInt32(Console.ReadLine());

            int[] c = Array.ConvertAll(Console.ReadLine().Split(' '), cTemp => Convert.ToInt32(cTemp))
            ;
            int result = jumpingOnClouds(c);

            Console.WriteLine(result);
        }
    }
}