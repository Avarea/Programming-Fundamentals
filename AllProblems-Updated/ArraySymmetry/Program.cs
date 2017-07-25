using System;
using System.Linq;

namespace ArraySymmetry
{
    class Program
    {
        static void Main()
        {
            string[] array = Console.ReadLine().Split(' ').ToArray();
            string[] reversed = array;
            reversed.Reverse();
            int reversedCount = Convert.ToInt32(reversed.Length) -1;

            for (int cntIndex = 0; cntIndex < array.Length; cntIndex++)
            {
                if (array[cntIndex] == reversed[reversedCount])
                {
                    reversedCount--;
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
