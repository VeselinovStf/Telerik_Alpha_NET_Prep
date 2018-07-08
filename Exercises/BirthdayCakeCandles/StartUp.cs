using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BirthdayCakeCandles
{
    // You are in-charge of the cake for your niece's birthday and have decided the 
    //cake will have one candle for each year of her total age. When she blows out
    //    the candles, she’ll only be able to blow out the tallest ones. Your task 
    //    is to find out how many candles she can successfully blow out.
    // For example, if your niece is turning years old, and the cake will have 
    //candles of height, , , , she will be able to blow out  candles successfully,
    //since the tallest candle is of height  and there are such candles.
    // Complete the function birthdayCakeCandles that takes your niece's age and
    //an integer array containing height of each candle as input, and return the number of candles she can successfully blow out.
    public class StartUp
    {
        public static int birthdayCakeCandles(int[] ar)
        {
            int result = 0;

            int max = ar.Max();
            for (int i = 0; i < ar.Length; i++)
            {
                if (ar[i] == max)
                {
                    result++;
                }
            }

            return result;

        }

        public static void Main()
        {
            TextWriter textWriter = new StreamWriter("test.txt");

            int arCount = Convert.ToInt32(Console.ReadLine());

            int[] ar = Array.ConvertAll(Console.ReadLine().Split(' '), arTemp => Convert.ToInt32(arTemp))
            ;
            int result = birthdayCakeCandles(ar);

            textWriter.WriteLine(result);
            Console.WriteLine(result);
            textWriter.Flush();
            textWriter.Close();
        }
    }
}
