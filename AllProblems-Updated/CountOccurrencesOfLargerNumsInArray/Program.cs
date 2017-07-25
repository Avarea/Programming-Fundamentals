using System;
using System.Linq;

namespace CountOccurrencesOfLargerNumsInArray
{
    class Program
    {
        static void Main(string[] args)
        {
            double[] array = Console.ReadLine().Split(' ').Select(double.Parse).ToArray();
            double number = double.Parse(Console.ReadLine());
            int occurrences = 0;

            for (int cntIndex = 0; cntIndex < array.Length; cntIndex++)
            {
                if (array[cntIndex] > number)
                {
                    occurrences++;
                }
            }
            Console.WriteLine(occurrences);
        }
    }
}
