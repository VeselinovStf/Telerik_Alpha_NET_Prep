using System;

namespace BubleSort
{
	public class StartUp
	{
        //With delegates fun
        public static Action<int[], int, int> Sqapper =
            delegate (int[] a, int bigger, int smaller)
            {
                int temp = a[bigger];
                a[bigger] = a[smaller];
                a[smaller] = temp;
            };

        public static Action<string, int> Printer =
            delegate (string text, int value)
            {
                Console.WriteLine(text, value);
            };

        public static Func<int[]> ParseStringToArray =
            delegate ()
            {
                return Array
                .ConvertAll(Console.ReadLine().Split(' '), aTemp => Convert.ToInt32(aTemp));
            };

        public static Func<int> ParseStringToInt =
            delegate ()
            {
                return Convert.ToInt32(Console.ReadLine());
            };

		public static void Main()
		{
            int n = ParseStringToInt();

            int[] a = ParseStringToArray();
			
			countSwaps(a);
		}

        public static Func<int[],int, bool, Action<int[], int, int>, int> LoopSwap
             = delegate (int[] a,int i, bool swapped, Action<int[], int, int> Swapper)
             {
                 var totalSwapps = 0;

                 for (var j = i + 1; j <= a.Length - 1; j++)
                 {
                     if (a[i] > a[j])
                     {
                         Sqapper(a, i, j);
                         totalSwapps++;
                         swapped = true;
                     }
                 }

                 return totalSwapps;
             };

		public static void countSwaps(int[] a) 
		{			
			int totalSwapps = 0;
			int len = a.Length;

                bool swapped;
                do
                {
                    swapped = false;

                    for (var i = 0; i < len; i++)
                    {
                        totalSwapps += LoopSwap(a, i, swapped, Sqapper);                      
                    }

                } while (swapped);

            Printer("Array is sorted in {0} swaps.", totalSwapps);
            Printer("First Element: {0}", a[0]);
            Printer("Last Element: {0}", a[a.Length - 1]);         
		}	
		
		

	}
}
	
