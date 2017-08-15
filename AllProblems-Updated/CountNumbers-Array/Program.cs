using System;
using System.Collections.Generic;
using System.Linq;

namespace CountNumbers_Array
{
    class Program
    {
        static void Main()
        {
            string[] input = Console.ReadLine().Split();
            List<short> numbers = new List<short>();

            for (int i = 0; i < input.Length; i++)
            {
                numbers.Add(short.Parse(input[i]));
            }
            numbers.Sort();
            short current = numbers.ElementAt(0);
            short counter = 1;
            if (numbers.Count == 1)
            {
                Console.WriteLine("{0} -> 1", string.Join("", numbers), counter);
            }
            else
            {
                for (int i = 1; i < numbers.Count; i++)
                {
                    if (current == numbers.ElementAt(i))
                    {
                        counter++;
                        if (i == numbers.Count - 1)
                        {
                            Console.WriteLine("{0} -> {1}", current, counter);
                        }
                    }
                    else
                    {
                        Console.WriteLine("{0} -> {1}", current, counter);
                        current = numbers.ElementAt(i);
                        counter = 1;
                    }
                }
            }
            
        }
    }
}
