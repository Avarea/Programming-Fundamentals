using System;
using System.Linq;

namespace CountOfCapitalLettersInArray
{
    class Program
    {
        static void Main()
        {
            string[] array = Console.ReadLine().Split(' ').ToArray();
            int counter = 0;

            for (int cntIndex = 0; cntIndex < array.Length; cntIndex++)
            {
                if (array[cntIndex].Length == 1 && array[cntIndex].Any(c => char.IsUpper(c)))
                {
                    counter++;
                }
            }
            Console.WriteLine(counter);
        }
    }
}
