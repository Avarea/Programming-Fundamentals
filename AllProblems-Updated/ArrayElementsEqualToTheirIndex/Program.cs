using System;
using System.Linq;

namespace ArrayElementsEqualToTheirIndex
{
    class Program
    {
        static void Main()
        {
            int[] array = Console.ReadLine()?.Split(' ').Select(int.Parse).ToArray();

            for (int cntIndex = 0; cntIndex < array.Length; cntIndex++)
            {
                if (cntIndex == array[cntIndex])
                {
                    Console.Write(array[cntIndex] + " ");
                }
            }
            Console.WriteLine();
        }
    }
}
