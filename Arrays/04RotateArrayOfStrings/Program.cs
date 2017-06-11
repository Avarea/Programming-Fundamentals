using System;
using System.Linq;

namespace _04RotateArrayOfStrings
{
    class Program
    {
        static void Main()
        {
            var array = Console.ReadLine().Split(' ').ToArray();
            var rotated = new string[array.Length];

            for (int i = 0; i < array.Length - 1; i++)
            {
              
                rotated[i + 1] = array[i];
                var lastElement = array[rotated.Length - 1];
                rotated[0] = lastElement;

            }

            Console.WriteLine(string.Join(" ", rotated));
        }
    }
}
