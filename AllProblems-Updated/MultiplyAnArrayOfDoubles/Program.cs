using System;
using System.Linq;

namespace MultiplyAnArrayOfDoubles
{
    class Program
    {
        static void Main()
        {
            double[] numbers = Console.ReadLine().Split(' ').Select(double.Parse).ToArray();
            double multiplier = double.Parse(Console.ReadLine());

            for (int cntIndex = 0; cntIndex < numbers.Length; cntIndex++)
            {
                numbers[cntIndex] *= multiplier;
            }
            Console.WriteLine(string.Join(" ", numbers));
        }
    }
}
