using System;
using System.Collections.Generic;
using System.Linq;


namespace _03SumAdjacentEqualNumbers
{
    class Program
    {
        static void Main()
        {
            List<decimal> numbers = Console.ReadLine().Split(' ').Select(decimal.Parse).ToList();
            numbers.Add(decimal.MaxValue);

            for (int i = 0; i < numbers.Count - 1; i++)
            {
                if (numbers[i] == numbers[i + 1])
                {
                    numbers[i + 1] = numbers[i] + numbers[i + 1];
                    numbers.RemoveAt(i);
                    i = -1;
                }
            }
            numbers.RemoveAt(numbers.Count - 1);
            Console.WriteLine(string.Join(" ", numbers));
        }
    }
}
