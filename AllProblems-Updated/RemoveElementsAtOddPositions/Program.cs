using System;
using System.Collections.Generic;
using System.Linq;

namespace RemoveElementsAtOddPositions
{
    class Program
    {
        static void Main()
        {
            List<string> input = Console.ReadLine().Split(' ').ToList();
            string result = String.Empty;

            for (int cnt = 1; cnt < input.Count; cnt++)
            {
                if (cnt % 2 == 1)
                {
                    result += input[cnt];
                }
            }
            Console.WriteLine(result);
        }
    }
}
