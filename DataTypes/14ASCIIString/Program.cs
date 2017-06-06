using System;

namespace _14ASCIIString
{
    class Program
    {
        static void Main()
        {
            int n = int.Parse(Console.ReadLine());
            string output = string.Empty;

            for (int i = 1; i <= n; i++)
            {
                int character = int.Parse(Console.ReadLine());
                output += (char)character;
            }
            Console.WriteLine(output);


        }
    }
}
