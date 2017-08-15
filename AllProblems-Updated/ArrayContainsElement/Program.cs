using System;
using System.Collections.Generic;
using System.Linq;

namespace ArrayContainsElement
{
    class Program
    {
        static void Main()
        {
            List<int> input = Console.ReadLine()?.Split(' ').Select(int.Parse).ToList();
            int elementToFind = int.Parse(Console.ReadLine());

            for (int cnt = 0; cnt < input.Count; cnt++)
            {
                if (input[cnt] == elementToFind)
                {
                    Console.WriteLine("yes");
                    return;
                }
            }
            Console.WriteLine("no");
        }
    }
}
