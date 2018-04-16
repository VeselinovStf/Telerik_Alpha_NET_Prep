using SimplyLazyExtensions_V01;
using System;
using System.Collections.Generic;

namespace DelegatesEx
{
    internal delegate void Calculate(int[] collection, int value);

    public delegate bool Predicate<T>(T value);

    public class StartUp
    {
        public static void AddNumber(int[] numbers, int addNumber)
        {
            for (int i = 0; i < numbers.Length; i++)
            {
                numbers[i] += addNumber;
            }
        }

        public static void Main()
        {
            //Delegates use
            int[] numbers = { 1, 2, 3, 4, 5, 6, 7 };

            Calculate cal = AddNumber;
            cal(numbers, 2);
            numbers.WriteCollection(" ");

            //Predicate
            Filter(numbers, IsGreatherThan5).WriteCollection("=");
            Filter(numbers, IsEaven).WriteCollection("--");

            Filter(numbers, delegate (int value)
            {
                return value < 5;
            }).WriteCollection(" ");

            //Func Delegate
            Func<int, bool> isOdd = x => x % 2 == 1;
            Action<int> isPrintingAction = x => Console.WriteLine(x);

            for (int i = 0; i < numbers.Length; i++)
            {
                if (isOdd(numbers[i]))
                {
                    isPrintingAction(numbers[i]);
                }
            }
        }

        public static IEnumerable<T> Filter<T>(IEnumerable<T> numbers, Predicate<T> predicate)
        {
            IList<T> list = new List<T>();

            foreach (var item in numbers)
            {
                if (predicate(item))
                {
                    list.Add(item);
                }
            }

            return list;
        }

        public static bool IsGreatherThan5(int value)
        {
            return value > 5;
        }

        public static bool IsEaven(int value)
        {
            return value % 2 == 0;
        }
    }
}