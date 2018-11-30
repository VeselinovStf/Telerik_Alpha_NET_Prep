using System;
using System.Numerics;

namespace LeftRotation
{

    class Program
    {
        static void Main(string[] args)
        {
            BigInteger
            string[] nd = Console.ReadLine().Split(' ');

            int n = Convert.ToInt32(nd[0]);

            int d = Convert.ToInt32(nd[1]);

            int[] a = Array.ConvertAll(Console.ReadLine().Split(' '), aTemp => Convert.ToInt32(aTemp));

            for (int i = 0; i < d; i++)
            {
                int temp = a[n -1];
                a[n - 1] = a[0];

                for (int j = n- 1; j > 0; j--)
                {
                    var temp2 = a[j-1];
                    a[j-1] = temp;
                    temp = temp2;
                }
            }

            if (nd[0].Contains())
            {

            }
            Console.WriteLine(string.Join(" ", a));
        }
    }
}
