using System;
using System.Numerics;

namespace _02_CrookedStairs
{
    public class StartUp
    {
        public static void Main()
        {
            BigInteger firstNum = BigInteger.Parse(Console.ReadLine());
            BigInteger secondNum = BigInteger.Parse(Console.ReadLine());
            BigInteger thurdNum = BigInteger.Parse(Console.ReadLine());

<<<<<<< HEAD
            int rowsCount = int.Parse(Console.ReadLine());

=======
            BigInteger rowsCount = BigInteger.Parse(Console.ReadLine());
                        
>>>>>>> 64fbe466e16e0b7f8bf1be026aca7dfe5910ed20
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
                        BigInteger temp = firstNum;
                        firstNum = secondNum;
                        secondNum = thurdNum;
                        thurdNum = temp + firstNum + secondNum;
                    }
<<<<<<< HEAD
                }

=======
                }           
>>>>>>> 64fbe466e16e0b7f8bf1be026aca7dfe5910ed20
                Console.WriteLine();
            }
        }
    }
}