using System;
using System.Linq;

namespace _02SmallestElementInArray
{
    class Program
    {
        static void Main()
        {
            var array = Console.ReadLine().Split(' ').Select(int.Parse).ToArray();

            var smallest = int.MaxValue;

            for (int i = 0; i < array.Length; i++)
            {
                if (smallest > array[i])
                {
                    smallest = array[i];
                }
            }
            Console.WriteLine(smallest);
        }
    }
}
