using System;
using System.Linq;

namespace Last3ConsecutiveEqualStrings
{
    class Program
    {
        static void Main()
        {
            string[] array = Console.ReadLine().Split(' ').ToArray();

            for (int cntIndex = array.Length - 1; cntIndex > 1; cntIndex--)
            {
                if (array[cntIndex] == array[cntIndex -1])
                {
                    if (array[cntIndex - 1] == array[cntIndex - 2])
                    {
                        Console.WriteLine($"{array[cntIndex]} {array[cntIndex]} {array[cntIndex]}");
                        break;
                    }
                }
            }
        }
    }
}
