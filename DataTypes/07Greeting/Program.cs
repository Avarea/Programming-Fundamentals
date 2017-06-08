using System;

namespace _07Greeting
{
    class Program
    {
        static void Main()
        {
            string fName = Console.ReadLine();
            string lName = Console.ReadLine();
            int age = int.Parse(Console.ReadLine());

            Console.WriteLine($"Hello, {fName} {lName}. You are {age} years old.");
        }
    }
}
