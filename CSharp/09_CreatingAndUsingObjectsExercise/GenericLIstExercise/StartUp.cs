using System;

namespace GenericLIstExercise
{
    class StartUp
    {
        static void Main()
        {
            GenericListT<int> list = new GenericListT<int>(5);

            list.Insert(0, 1);
            list.Insert(1, 2);
            list.Insert(2, 3);
            list.Insert(3, 4);
            list.Insert(4, 5);
            list.Insert(5, 6);
            list.Insert(6, 7);
            list.Insert(7, 8);

            Console.WriteLine(list);

            list.Remove(3);

            Console.WriteLine(list);

            list.Clear();

            Console.WriteLine(list);
        }

        //private static void PrintList(GenericListT<int> list)
        //{
        //    for (int i = 0; i < list.Count; i++)
        //    {
        //        Console.WriteLine(list[i]);
        //    }
        //}
    }
}
