using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DecimalToBinary
{
    public class StartUp
    {
        public static void Main()
        {
            int decimalNumber = int.Parse(Console.ReadLine());

            Stack<int> binary = new Stack<int>();

            if (decimalNumber == 0)
            {
                Console.WriteLine(decimalNumber);
            }

            while (decimalNumber > 0)
            {
                var binaryRep = decimalNumber % 2;
                decimalNumber = decimalNumber / 2;
                binary.Push(binaryRep);
            }

            foreach (var item in binary)
            {
                Console.Write(item);
            }

            Console.WriteLine();
        }
    }
}