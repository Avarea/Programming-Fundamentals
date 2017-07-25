using System;
using System.Linq;

namespace _01ArrayContainsElement
{
    class Program
    {
        static void Main()
        {
            var array = Console.ReadLine().Split(' ').Select(int.Parse).ToArray();
            int integer = int.Parse(Console.ReadLine());

            bool containElement = false;

            for (int i = 0; i < array.Length; i++)
            {
                if (array[i] == integer)
                {
                    containElement = true;
                    break;
                }
            }

            if (containElement == true)
            {
                Console.WriteLine("yes");
            }
            else
            {
                Console.WriteLine("no");
            }
        }
    }
}
