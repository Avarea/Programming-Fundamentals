using System;
using System.Collections.Generic;
using System.Linq;

namespace _02BinarySearch
{
    class Program
    {
        static void Main()
        {
            List<int> input = Console.ReadLine().Split(' ').Select(int.Parse).ToList();
            int number = int.Parse(Console.ReadLine());

            Console.WriteLine(IsPresent(input, number));
            Console.WriteLine(GetLinearSearch(input, number));
            Console.WriteLine(GetBinarySearch(input, number));
        }

        private static string IsPresent(List<int> input, int number)
        {
            bool isPresent = false;
            for (int i = 0; i < input.Count; i++)
            {
                if (number == input[i])
                {
                    isPresent = true;
                    break;
                }
                else
                {
                    isPresent = false;
                    continue;
                }
            }
            if (isPresent)
            {
                return "Yes";
            }
            else
            {
                return "No";
            }
        }

        private static string GetLinearSearch(List<int> input, int number)
        {
            int interactions = 0;
            for (int i = 0; i < input.Count; i++)
            {
                interactions++;
                if (number == input[i])
                {
                    return $"Linear search made {interactions} iterations";
                }
            }
            return $"Linear search made {interactions} iterations";
        }

        private static string GetBinarySearch(List<int> input, int number)
        {
            int interactions = 0;
            input.Sort();
            if (number < input[(input.Count + 0) / 2])
            {
                for (int i = 0; i < input.Count / 2; i++)
                {
                    interactions++;
                    if (number == input[i])
                    {
                        return $"Binary search made {interactions} iterations";
                    }
                }
            }
            else if(number > input[input.Count / 2])
            {
                for (int i = input.Count / 2; i < input.Count; i++)
                {
                    interactions++;
                    if (number == input[i])
                    {
                        return $"Binary search made {interactions} iterations";
                    }
                }
            }
            else
            {
                return "Binary search made 1 iterations";
            }
            return $"Binary search made {interactions} iterations";
        }
    }
}
