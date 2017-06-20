using System;
using System.Collections.Generic;
using System.Linq;


namespace _02AppendLists
{
    class Program
    {
        static void Main()
        {
            List<string> numbers = Console.ReadLine().Split(new char[] { '|' }).ToList();
            string result = string.Empty;

            for (int cnt = numbers.Count - 1; cnt >= 0 ; cnt--)
            {
                string element = numbers[cnt];
                var differentPats = element.Split(new char[] { ' ' },StringSplitOptions.RemoveEmptyEntries).ToList();

                for (int i = 0; i < differentPats.Count; i++)
                {
                    result += differentPats[i] + " ";
                }
            }
            Console.WriteLine(result);
        }
    }
}
