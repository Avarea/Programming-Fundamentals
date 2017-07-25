using System;
using System.Linq;

namespace RotateArrayOfStrings
{
    class Program
    {
        static void Main()
        {
            string[] array = Console.ReadLine().Split(' ').ToArray();
            string[] rotated = new string[array.Length];

            for (int cntIndex = 0; cntIndex < array.Length; cntIndex++)
            {
                rotated[(cntIndex + 1) % array.Length] = array[cntIndex];
            }
            Console.WriteLine(string.Join(" ", rotated));
        }
    }
}
