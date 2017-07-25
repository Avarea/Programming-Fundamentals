using System;

namespace SumArrayElements
{
    class Program
    {
        static void Main()
        {
            int input = int.Parse(Console.ReadLine());
            int[] numbers = new int[input];
            int sum = 0;

            for (int cntIndex = 0; cntIndex < input; cntIndex++)
            {
                numbers[cntIndex] = int.Parse(Console.ReadLine());
                sum += numbers[cntIndex];
            }
            Console.WriteLine(sum);
        }
    }
}
