using System;
using System.Linq;

namespace _03ReverseArrayIn_place
{
    class Program
    {
        static void Main()
        {
            var array = Console.ReadLine().Split(' ').Select(int.Parse).ToArray();

            for (int i = 0; i < array.Length / 2; i++)
            {
                int temp = array[i];
                array[i] = array[array.Length - 1 - i];
                array[array.Length - 1 - i] = temp;
            }
            Console.WriteLine(string.Join(" ", array));
        }
    }
}
