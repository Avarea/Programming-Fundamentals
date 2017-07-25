using System;
using System.Linq;

namespace OddNumbersAtOddPositions
{
    class Program
    {
        static void Main()
        {
            int[] numbers = Console.ReadLine().Split(' ').Select(int.Parse).ToArray();

            for (int cntIndex = 0; cntIndex < numbers.Length; cntIndex++)
            {
                if (cntIndex % 2 == 1)
                {
                    if (numbers[cntIndex] % 2 == 1 || numbers[cntIndex] % 2 == -1)
                    {
                        Console.WriteLine($"Index {cntIndex} -> {numbers[cntIndex]}");
                    }
                }
            }
        }
    }
}
