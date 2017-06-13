using System;
using System.Linq;


namespace _14EqualSequenceOfElementsInArray
{
    class Program
    {
        static void Main()
        {
            int[] numbers = Console.ReadLine().Split(' ').Select(int.Parse).ToArray();
            int lastElement = numbers[0];
            bool areEqual = false;

            for (int i = 0; i < numbers.Length; i++)
            {
                if (numbers[i] == lastElement)
                {
                    areEqual = true;
                    lastElement = numbers[i];
                }
                else
                {
                    areEqual = false;
                    break;
                }
                
            }
            if (areEqual == true)
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
