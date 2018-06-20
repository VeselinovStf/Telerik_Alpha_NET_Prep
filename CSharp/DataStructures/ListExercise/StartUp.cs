using List;
using System;
using System.Diagnostics;

namespace ListExercise
{
    public class StartUp
    {
        public static void TimeStamping(Action act)
        {
            var watch = new Stopwatch();
            watch.Start();
            act();
            watch.Stop();

            Console.WriteLine(watch.Elapsed);

        }

        public static void Main()
        {
            var list = new List<int>();
            var runLimit = 100000000;

            TimeStamping(() =>
            {
                for (int i = 0; i < runLimit; i++)
                {
                    list.Add(i);
                }
            });

            System.Collections.Generic.List<int> buildIn = new System.Collections.Generic.List<int>();

            TimeStamping(() =>
            {
                for (int i = 0; i < runLimit; i++)
                {
                    buildIn.Add(i);
                }
            });
        }
    }
}