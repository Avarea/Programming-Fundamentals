using System;

namespace _04Transport
{
    class Program
    {
        static void Main()
        {
            int numberOfPersons = int.Parse(Console.ReadLine());
            double capacity = 24;

            Console.WriteLine(Math.Ceiling((numberOfPersons / capacity)));
        }
    }
}
