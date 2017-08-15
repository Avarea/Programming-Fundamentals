using System;
using System.Collections.Generic;
using System.Linq;

namespace UnunionLists
{
    class Program
    {
        static void Main()
        {
            List<int> primalList = Console.ReadLine()?.Split(' ').Select(int.Parse).ToList();
            int input = int.Parse(Console.ReadLine());

            for (int cnt = 0; cnt < input; cnt++)
            {
                List<int> sequence = Console.ReadLine()?.Split(' ').Select(int.Parse).ToList();
                for (int i = 0; i < sequence.Count; i++)
                {
                    if (primalList.Contains(sequence[i]))
                    {
                        primalList.RemoveAll(x => x == sequence[i]);
                    }
                    else
                    {
                        primalList.Add(sequence[i]);
                    }
                }
            }
            primalList.Sort();
            Console.WriteLine(string.Join(" ", primalList));
        }
    }
}
