using System;
using System.Collections.Generic;
using System.Linq;

namespace FlipListSides
{
    class Program
    {
        static void Main()
        {
            List<string> input = Console.ReadLine()?.Split(' ').ToList();
            string firstElement = input[0];
            string lastElement = input[input.Count - 1];

            input.Reverse();
            input[0] = firstElement;
            input[input.Count - 1] = lastElement;

            Console.WriteLine(string.Join(" ", input));
        }
    }
}
