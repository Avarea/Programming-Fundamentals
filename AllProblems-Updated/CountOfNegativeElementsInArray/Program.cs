using System;

namespace CountOfNegativeElementsInArray
{
    class Program
    {
        static void Main()
        {
            int n = int.Parse(Console.ReadLine());
            int[] array = new int[n];
            int negativeCount = 0;

            for (int cntIndex = 0; cntIndex < n; cntIndex++)
            {
                array[cntIndex] = int.Parse(Console.ReadLine());
                if (array[cntIndex] < 0)
                {
                    negativeCount++;
                }
            }
            Console.WriteLine(negativeCount);
        }
    }
}
