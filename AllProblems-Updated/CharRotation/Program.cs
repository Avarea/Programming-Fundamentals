using System;
using System.Linq;

namespace CharRotation
{
    class Program
    {
        static void Main()
        {
            string stringArray = Console.ReadLine();
            int[] numbersArray = Console.ReadLine().Split(' ').Select(int.Parse).ToArray();
            char[] result = new char[numbersArray.Length];

            for (int cntIndex = 0; cntIndex < numbersArray.Length; cntIndex++)
            {
                if (numbersArray[cntIndex] % 2 == 0)
                {
                    result[cntIndex] += (char)(stringArray[cntIndex] - numbersArray[cntIndex]);
                }
                else
                {
                    result[cntIndex] += (char)(stringArray[cntIndex] + numbersArray[cntIndex]);
                }
            }
            Console.WriteLine(result);
        }
    }
}
