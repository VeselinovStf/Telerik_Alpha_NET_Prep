using System;

namespace GoodNumbers
{
    public class StartUp
    {
        public static void Main()
        {
            string[] numbers = Console.ReadLine()
                .Split(' ');

            int numA = int.Parse(numbers[0]);
            int numB = int.Parse(numbers[1]);

            int goodNumbersCount = 0;
            for (int currentNumber = numA; currentNumber <= numB; currentNumber++)
            {
                string num = currentNumber.ToString();

                bool isDiv = true;
                for (int i = 0; i < num.Length; i++)
                {
                    int div = (int)Char.GetNumericValue(num[i]);
                    

                    if (div != 0 && currentNumber % div != 0)
                    {
                        isDiv = false;
                        break;
                    }
                   
                }

                if (isDiv)
                {
                    goodNumbersCount++;
                }
            }

            Console.WriteLine(goodNumbersCount);

        }
    }
}