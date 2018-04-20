using System;

namespace _02_IEnumerableExtensions
{
    public class StartUp
    {
        public static void Main()
        {
            int[] numbers = { 1, 2, 3, 4, 10 };
            var sum = numbers.MySum();
            Console.WriteLine(sum);

            var sum2 = numbers.AuthorSum();
            Console.WriteLine(sum2);

            var product = numbers.Product();
            Console.WriteLine(product);

            var minNum = numbers.Min();
            Console.WriteLine(minNum);

            var minNum2 = numbers.AuthorMin();
            Console.WriteLine(minNum2);

            var max = numbers.Max();
            Console.WriteLine(max);

            var avarage = numbers.Avarage();
            Console.WriteLine(avarage);
        }
    }
}