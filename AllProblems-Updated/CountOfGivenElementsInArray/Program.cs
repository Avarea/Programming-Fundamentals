using System;
using System.Linq;

namespace CountOfGivenElementsInArray
{
    class Program
    {
        static void Main()
        {
            int[] array = Console.ReadLine().Split(' ').Select(int.Parse).ToArray();
            int element = int.Parse(Console.ReadLine());
            int counter = 0;

            for (int cntIndex = 0; cntIndex < array.Length; cntIndex++)
            {
                if (array[cntIndex] == element)
                {
                    counter++;
                }    
            }
            Console.WriteLine(counter);
        }
    }
}
