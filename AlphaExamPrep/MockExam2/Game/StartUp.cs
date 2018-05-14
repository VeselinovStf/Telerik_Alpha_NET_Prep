

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Game
{
    public class StartUp
    {
        public static void Main()
        {
            string inputNumber = Console.ReadLine();

            int firstNumber = (int)char.GetNumericValue(inputNumber[0]);
            int secondNumber = (int)char.GetNumericValue(inputNumber[1]);
            int thirdNumber = (int)char.GetNumericValue(inputNumber[2]);
          
            //Fast
            int exp1 = firstNumber + secondNumber + thirdNumber;
            int exp2 = firstNumber * secondNumber * thirdNumber;
            int exp3 = firstNumber * secondNumber + thirdNumber;
            int exp4 = firstNumber + secondNumber * thirdNumber;
            int[] expresions = { exp1, exp2, exp3, exp4 };

            Console.WriteLine(expresions.Max());

        }
    }
}
