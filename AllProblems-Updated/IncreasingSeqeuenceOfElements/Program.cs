using System;
using System.Linq;

namespace IncreasingSeqeuenceOfElements
{
    class Program
    {
        static void Main()
        {
            int[] array = Console.ReadLine().Split(' ').Select(int.Parse).ToArray();
            bool isIncreasing = false;

            for (int cntIndex = 0; cntIndex < array.Length - 1; cntIndex++)
            {
                if (array[cntIndex] < array[cntIndex + 1])
                {
                    isIncreasing = true;
                }
                else
                {
                    Console.WriteLine("No");
                    return;
                }
            }
            Console.WriteLine("Yes");
        }
    }
}
