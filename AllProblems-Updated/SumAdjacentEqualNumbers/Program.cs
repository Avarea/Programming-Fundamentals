using System;
using System.Collections.Generic;
using System.Linq;

namespace SumAdjacentEqualNumbers
{
    class Program
    {
        static void Main()
        {
            List<decimal> input = Console.ReadLine().Split(' ').Select(decimal.Parse).ToList();
            input.Add(decimal.MaxValue);

            for (int cnt = 0; cnt < input.Count - 1; cnt++)
            {
                if (input[cnt] == input[cnt + 1])
                {
                    input[cnt + 1] = input[cnt] + input[cnt + 1];
                    input.RemoveAt(cnt);
                    cnt = -1;
                }
            }
            input.RemoveAt(input.Count - 1);
            Console.WriteLine(string.Join(" ", input));
        }
    }
}
