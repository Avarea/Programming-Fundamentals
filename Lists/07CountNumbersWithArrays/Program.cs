using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;

namespace _07CountNumbersWithMethods
{
    class Program
    {
        static void Main(string[] args)
        {
            var array = Console.ReadLine().Split(' ').Select(int.Parse).ToArray();
            int max = array.Max();
            var counts = new int[max + 1];
            int count = 1;

            for (int i = 0; i < array.Length; i++)
            {
                
            }
        }
    }
}
