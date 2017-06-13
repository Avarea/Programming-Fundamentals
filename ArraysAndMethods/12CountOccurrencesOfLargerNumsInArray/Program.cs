using System;
using System.Linq;


namespace _12CountOccurrencesOfLargerNumsInArray
{
    class Program
    {
        static void Main()
        {
            double[] numbers = Console.ReadLine().Split(' ').Select(double.Parse).ToArray();
            double element = double.Parse(Console.ReadLine());
            int count = 0;

            for (int i = 0; i < numbers.Length; i++)
            {
                if (numbers[i] > element)
                {
                    count++;
                }
            }
            Console.WriteLine(count);
        }
    }
}
