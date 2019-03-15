using System;

namespace AppleAndOrange
{
    public class StartUp
    {
        public static void Main()
        {
            string[] st = Console.ReadLine().Split(' ');

            int s = Convert.ToInt32(st[0]);

            int t = Convert.ToInt32(st[1]);

            string[] ab = Console.ReadLine().Split(' ');

            int a = Convert.ToInt32(ab[0]);

            int b = Convert.ToInt32(ab[1]);

            string[] mn = Console.ReadLine().Split(' ');

            int m = Convert.ToInt32(mn[0]);

            int n = Convert.ToInt32(mn[1]);

            int[] apples = Array.ConvertAll(Console.ReadLine().Split(' '), applesTemp => Convert.ToInt32(applesTemp))
            ;

            int[] oranges = Array.ConvertAll(Console.ReadLine().Split(' '), orangesTemp => Convert.ToInt32(orangesTemp))
            ;
            countApplesAndOranges(s, t, a, b, apples, oranges);
        }

       public static Func<int, int, int> CalculateDistance =
               delegate (int power, int staticPoint)
               {
                   if (power < 0)
                   {
                       return staticPoint - Math.Abs(power);
                   }

                   return staticPoint + power;
               };

       public static Func<int, int, int, bool> IsInTarget =
            delegate (int hitPower, int start, int end)
            {
                if (hitPower >= start && hitPower <= end)
                {
                    return true;
                }

                return false;
            };

        public static void countApplesAndOranges(int s, int t, int a, int b, int[] apples, int[] oranges)
        {           
            var totalApples = CalculatePoints(apples, s,t,a);
            var totalOranges = CalculatePoints(oranges, s, t, b);

            Console.WriteLine(totalApples);
            Console.WriteLine(totalOranges);
        }

        private static int CalculatePoints(int[] arr, int s, int t, int a)
        {
            var result = 0;

            for (int i = 0; i < arr.Length; i++)
            {
                var dist = CalculateDistance(arr[i], a);

                if (IsInTarget(dist,s,t))
                {
                    result++;
                }
            }

            return result;
        }
    }
}
