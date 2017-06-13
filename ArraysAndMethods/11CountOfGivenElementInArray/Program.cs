using System;
using System.Linq;

namespace _11CountOfGivenElementInArray
{
    class Program
    {
        static void Main()
        {
            int[] numbers = Console.ReadLine().Split(' ').Select(int.Parse).ToArray();
            int element = int.Parse(Console.ReadLine());
            int count = 0;

            for (int i = 0; i < numbers.Length; i++)
            {
                if (numbers[i] == element)
                {
                    count++;
                }
            }
            Console.WriteLine(count);
        }
    }
}
