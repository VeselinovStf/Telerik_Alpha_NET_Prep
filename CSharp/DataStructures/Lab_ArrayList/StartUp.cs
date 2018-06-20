using System;

namespace Lab_ArrayList
{
    public class StartUp
    {
        public static void Main()
        {
            ArrayList<int> myArray = new ArrayList<int>();
            myArray.Add(0);
            myArray.Add(1);
            myArray.Add(1);
            myArray.Add(2);
            myArray.Add(3);
            myArray.RemoveAt(0);
            myArray.Add(4);
            myArray.Add(5);
            myArray.RemoveAt(0);

            for (int i = 0; i < myArray.Count; i++)
            {
                Console.WriteLine(myArray[i]);
            }
        }
    }
}