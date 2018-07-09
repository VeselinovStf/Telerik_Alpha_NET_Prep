using System;

namespace Day_17_MoreExceptions
{
    public class Calculator
    {
        public int power(int n, int p)
        {
            if (n < 0 || p < 0)
            {
                throw new ArgumentException("n and p should be non-negative");
            }

            int pow = (int)Math.Pow(n, p);
            return pow;
        }
    }
}