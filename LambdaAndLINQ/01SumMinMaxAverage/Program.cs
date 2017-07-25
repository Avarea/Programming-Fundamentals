using System;
using System.Linq;

namespace _01SumMinMaxAverage
{
    class Program
    {
        static void Main()
        {
            int input = int.Parse(Console.ReadLine());
            int[] nums = new int[input];

            for (int i = 0; i < input; i++)
            {
                nums[i] = int.Parse(Console.ReadLine());
            }
            Console.WriteLine("Sum = " + nums.Sum());
            Console.WriteLine("Min = " + nums.Min());
            Console.WriteLine("Max = " + nums.Max());
            Console.WriteLine("Average = " + nums.Average());
        }
    }
}
