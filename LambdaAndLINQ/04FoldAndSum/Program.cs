using System;
using System.Linq;

namespace _04FoldAndSum
{
    class Program
    {
        static void Main()
        {
            int[] initialNumbers = Console.ReadLine().Split(' ').Select(int.Parse).ToArray();

            int k = initialNumbers.Length / 4;

            int[] leftPart = initialNumbers.Take(k).Reverse().ToArray();
            int[] rightPart = initialNumbers.Reverse().Take(k).ToArray();
            int[] upperArr = leftPart.Concat(rightPart).ToArray();
            int[] downArr = initialNumbers.Skip(k).Take(2 * k).ToArray();

            for (int i = 0; i < downArr.Length; i++)
            {
                downArr[i] += upperArr[i];
            }

            Console.WriteLine(string.Join(" ", downArr));
        }
    }
}
