using System;

namespace _06IncrementVariable
{
    class Program
    {
        static void Main()
        {
            int number = int.Parse(Console.ReadLine());

            int overflow = number / 256;
            int result = number % 256;

            Console.WriteLine(result);
            Console.WriteLine("Overflowed {0} times", overflow);

             

        }
    }
}
