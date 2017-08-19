using System;
using System.Collections.Generic;
using System.Linq;

namespace FoldAndSum
{
    class Program
    {
        static void Main()
        {
            int[] initalNumbers = Console.ReadLine()?.Split(' ').Select(int.Parse).ToArray();
            int k = initalNumbers.Length / 4;

            List<int> leftPart = initalNumbers.Take(k).Reverse().ToList();
            List<int> rightPart = initalNumbers.Reverse().Take(k).ToList();

            int[] downArray = initalNumbers.Skip(k).Take(2 * k).ToArray();
            int[] upperArray = leftPart.Concat(rightPart).ToArray();

            for (int i = 0; i < downArray.Length; i++)
            {
                downArray[i] += upperArray[i];
            }
            Console.WriteLine(string.Join(" ", downArray));
        }
    }
}
