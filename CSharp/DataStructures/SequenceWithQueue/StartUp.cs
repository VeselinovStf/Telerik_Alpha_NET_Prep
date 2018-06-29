using System;
using System.Collections.Generic;
using System.Linq;
using System.Numerics;
using System.Text;
using System.Threading.Tasks;

namespace SequenceWithQueue
{
    public class StartUp
    {
        public static void Main()
        {
            BigInteger s1 = BigInteger.Parse(Console.ReadLine());

            Queue<BigInteger> removeQueur = new Queue<BigInteger>();
            List<BigInteger> result = new List<BigInteger>();

            result.Add(s1);
            removeQueur.Enqueue(s1);

            var steps = 50 / 3;
            for (int i = 0; i <= steps; i++)
            {
                var prevS = removeQueur.Peek();
                //s2
                var s2 = prevS + 1;
                //s3
                var s3 = 2 * prevS + 1;
                //new s
                var nextS = prevS + 2;

                result.Add(s2);
                if (i < steps)
                {
                    result.Add(s3);
                    result.Add(nextS);
                }

                removeQueur.Enqueue(s2);
                removeQueur.Enqueue(s3);
                removeQueur.Enqueue(nextS);

                removeQueur.Dequeue();
            }

            Console.WriteLine(string.Join(" ", result));
        }
    }
}