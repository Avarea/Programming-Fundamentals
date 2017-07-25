using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CountOfOddNumbersInArray
{
    class Program
    {
        static void Main()
        {
            int[] numbers = Console.ReadLine().Split(' ').Select(int.Parse).ToArray();
            int oddCount = 0;

            for (int cntIndex = 0; cntIndex < numbers.Length; cntIndex++)
            {
                if (numbers[cntIndex] % 2 == 1 || numbers[cntIndex] % 2 == -1)
                {
                    oddCount++;
                }
            }
            Console.WriteLine(oddCount);
        }
    }
}
