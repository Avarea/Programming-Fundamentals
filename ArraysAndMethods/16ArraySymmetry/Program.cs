using System;
using System.Linq;

namespace _16ArraySymmetry
{
    class Program
    {
        static void Main()
        {
            var array = Console.ReadLine().Split(' ').ToArray();
            var firstElement = array[0];
            bool isEqual = false;
            if (array[array.Length -1] == firstElement)
            {
                isEqual = true;
            }
            else
            {
                Console.WriteLine("No");
                return;
            }
            if (isEqual = true)
            {
                Console.WriteLine("Yes");
            }
            else
            {
                Console.WriteLine("No");
            }
        }
    }
}
