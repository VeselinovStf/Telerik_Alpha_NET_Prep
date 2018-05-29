using System;

namespace Shema
{
    public class StartUp
    {
        public static void Main()
        {
            string[] parameters = Console.ReadLine()
                .Split(new char[] { ' ', }
                , StringSplitOptions
                .RemoveEmptyEntries);

            int row = int.Parse(parameters[0]);
            int col = int.Parse(parameters[1]);
            char sighn = char.Parse(parameters[2]);

            if (row > col)
            {
                int temp = row;
                row = col;
                col = temp;
            }

            for (int i = 0; i < row; i++)
            {         
                Console.WriteLine(new string(sighn, col));
            }

        }
    }
}