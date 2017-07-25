using System;
using System.Linq;

namespace EqualSequenceOfElementsInArray
{
    class Program
    {
        static void Main()
        {
            int[] array = Console.ReadLine().Split(' ').Select(int.Parse).ToArray();

            for (int cntIndex = 0; cntIndex < array.Length - 1; cntIndex++)
            {
                if (array[cntIndex] == array[cntIndex + 1])
                {
                    continue;
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
