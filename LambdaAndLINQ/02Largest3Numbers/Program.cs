using System;
using System.Collections.Generic;
using System.Linq;

namespace _02Largest3Numbers
{
    class Program
    {
        static void Main()
        {
            List<double> numbers = new List<double>();
            numbers = Console.ReadLine().Split(' ').Select(double.Parse).ToList();

            Console.WriteLine(string.Join(" ", numbers.OrderByDescending(x => x).Take(3)));
        }
    }
}
