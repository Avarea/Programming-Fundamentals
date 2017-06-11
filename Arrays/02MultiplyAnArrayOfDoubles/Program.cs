using System;
using System.Linq;


namespace _02MultiplyAnArrayOfDoubles
{
    class Program
    {
        static void Main()
        {
            double[] numbers = Console.ReadLine().Split(' ').Select(double.Parse).ToArray();
            double p = double.Parse(Console.ReadLine());

            for (int i = 0; i < numbers.Length; i++)
            {

                Console.Write(numbers[i] * p + " ");
            }

        }
    }
}
