using System;

namespace Greetings
{
    class Program
    {
        static void Main()
        {
            string name = Console.ReadLine();
            Hello(name);
        }

        private static void Hello(string name)
        {
            Console.WriteLine($"Hello, {name}!");
        }
    }
}
