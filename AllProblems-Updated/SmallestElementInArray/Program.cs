using System;
using System.Linq;

namespace SmallestElementInArray
{
    class Program
    {
        static void Main()
        {
            int[] array = Console.ReadLine()?.Split(' ').Select(int.Parse).ToArray();
            int smallest = Int32.MaxValue;

            for (int cntIndex = 0; cntIndex < array.Length; cntIndex++)
            {
                if (array[cntIndex] < smallest)
                {
                    smallest = array[cntIndex];
                }
            }
            Console.WriteLine(smallest);
        }
    }
}
