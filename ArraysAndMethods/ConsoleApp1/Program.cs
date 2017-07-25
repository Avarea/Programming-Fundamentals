using System;
using System.Linq;


namespace _05CountOfOddNumbersInArray
{
    class Program
    {
        static void Main()
        {
            double[] numbers = Console.ReadLine().Split(' ').Select(double.Parse).ToArray();

            int count = 0;

            for (int i = 0; i < numbers.Length; i++)
            {
                if (numbers[i] % 2 == 1 || numbers[i] % 2 == -1)
                {
                    count++;
                }
            }

            Console.WriteLine(count);
        }
    }
}