using System;

namespace DateModifier
{
    public class StartUp
    {
        public static void Main()
        {
            string inputDateOne = Console.ReadLine();
            string inputDateTwo = Console.ReadLine();

            Date.DateModifier(inputDateOne, inputDateTwo);

        }
    }
}
