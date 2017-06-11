using System;
using System.Linq;


namespace _06OddNumbersAtOddPositions
{
    class Program
    {
        static void Main()
        {
            double[] numbers = Console.ReadLine().Split(' ').Select(double.Parse).ToArray();


            for (int i = 0; i < numbers.Length; i++)
            {
                if (i % 2 == 1)
                {
                    if (numbers[i] % 2 == 1 || numbers[i] % 2 == -1)
                    {
                        Console.WriteLine("Index {0} -> {1}", i, numbers[i]);
                    }
                }

            }

        }
    }
}
