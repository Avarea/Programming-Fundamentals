using System;
using System.Linq;


namespace _13IncreasingSequenceOfElements
{
    class Program
    {
        static void Main()
        {
            int[] numbers = Console.ReadLine().Split(' ').Select(int.Parse).ToArray();
            bool isIncreasing = false;
            int lastElement = 0;

            for (int i = 0; i < numbers.Length; i++)
            {

                if (i == 0)
                {
                    lastElement = numbers[i];
                }
                else 
                {
                    if (numbers[i] > lastElement)
                    {
                        isIncreasing = true;
                        lastElement = numbers[i];
                    }
                    else
                    {
                        isIncreasing = false;
                        break;
                    }
                }
            }
            if (isIncreasing == true)
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
