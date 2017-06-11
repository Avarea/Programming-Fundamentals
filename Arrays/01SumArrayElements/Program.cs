using System;
using System.Linq;

namespace _01SumArrayElements
{
    class Program
    {
        static void Main()
        {
            //int[] numbers = Console.ReadLine().Split(' ').Select(int.Parse).ToArray();

            int input = int.Parse(Console.ReadLine());
            var array = new int[input];


            int sum = 0;

            for (int i = 0; i < array.Length; i++)
            {
                array[i] = int.Parse(Console.ReadLine());
            }

            for (int i = 0; i < array.Length; i++)
            {
                sum += array[i];

            }
            Console.WriteLine(sum);
        }
    }
}
