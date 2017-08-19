using System;
using System.Collections.Generic;
using System.Linq;

namespace Largest3Numbers
{
    class Program
    {
        static void Main()
        {
            List<int> numbers = Console.ReadLine()?.Split(' ').Select(int.Parse).OrderByDescending(x => x).Take(3).ToList();

            Console.WriteLine(string.Join(" ", numbers));
        }
    }
}
