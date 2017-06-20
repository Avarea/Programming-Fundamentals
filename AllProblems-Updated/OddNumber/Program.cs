using System;

namespace OddNumber
{
    class Program
    {
        static void Main()
        {
            int number = Math.Abs(int.Parse(Console.ReadLine()));

            while (number % 2 == 0)
            {
                Console.WriteLine("Please write an odd number.");
                number = Math.Abs(int.Parse(Console.ReadLine()));
            }
            Console.WriteLine($"The number is: {number}");
        }
    }
}
