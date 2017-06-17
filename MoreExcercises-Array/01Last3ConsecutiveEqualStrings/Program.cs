using System;
using System.Linq;


namespace _01Last3ConsecutiveEqualStrings
{
    class Program
    {
        static void Main()
        {
            var array = Console.ReadLine().Split(' ').ToArray();

            string firstString = String.Empty;
            string secondString = String.Empty;
            string thirdString = String.Empty;

            thirdString = array[array.Length - 1];
            secondString = array[array.Length - 2];
            firstString = array[array.Length - 3];

            for (int i = array.Length; i >= 0; i--)
            {
                if (thirdString == secondString && secondString == firstString)
                {
                    Console.WriteLine($"{firstString} {secondString} {thirdString}");
                    return;
                }
                else
                {
                    
                    thirdString = array[i - 1];
                    secondString = array[i - 2];
                    firstString = array[i - 3];
                }
            }



        }
    }
}
