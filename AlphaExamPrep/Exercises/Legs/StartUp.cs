using System;

namespace Legs
{
    public class StartUp
    {
      
        public static void Main()
        {
            int sum = 0;
            int n = int.Parse(Console.ReadLine());

            for (int i = 0; i <= n; i += 7)
            {
                for (int j = i; j <= n; j += 5)
                {
                    if ((n - j) % 2 == 0)
                    {
                        sum++;
                    }
                }
            }
            Console.WriteLine(sum);
        }
    }
}