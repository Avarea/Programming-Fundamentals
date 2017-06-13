using System;

namespace _01HelloName
{
    class Program
    {
        static void Main()
        {
            string name = Console.ReadLine();

            GetName(name);
        }

         static void GetName(string name)
        {
            Console.WriteLine($"Hello, {name}!");
        }
    }
}
