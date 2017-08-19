using System;
using System.Collections.Generic;
using System.Linq;

namespace CountRealNumbers
{
    class Program
    {
        static void Main()
        {
            SortedDictionary<double, int> numbersCount = new SortedDictionary<double, int>();

            double[] numbersInput = Console.ReadLine()?.Split(' ').Select(double.Parse).ToArray();
            for (int i = 0; i < numbersInput.Length; i++)
            {
                if (!numbersCount.ContainsKey(numbersInput[i]))
                {
                    numbersCount.Add(numbersInput[i], 0);
                }
                numbersCount[numbersInput[i]]++;
            }

            foreach (double item in numbersCount.Keys)
            {
                Console.WriteLine($"{item} -> {numbersCount[item]}");
            }
        }
    }
}
