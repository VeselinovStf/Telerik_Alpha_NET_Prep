using System;

namespace _02_CrookedStairs
{
    public class StartUp
    {
        public static void Main()
        {
            int firstNum = int.Parse(Console.ReadLine());
            int secondNum = int.Parse(Console.ReadLine());
            int thurdNum = int.Parse(Console.ReadLine());

            int rowsCount = int.Parse(Console.ReadLine());

            for (int row = 0; row < rowsCount; row++)
            {
                if (row == 0)
                {
                    Console.Write(firstNum);
                }
                else if (row == 1)
                {
                    Console.Write(secondNum + " " + thurdNum);
                }
                else
                {
                    for (int i = 0; i <= row; i++)
                    {
                        Console.Write(firstNum + secondNum + thurdNum + " ");
                        var temp = firstNum;
                        firstNum = secondNum;
                        secondNum = thurdNum;
                        thurdNum = temp + firstNum + secondNum;
                    }
                }

                Console.WriteLine();
            }
        }
    }
}