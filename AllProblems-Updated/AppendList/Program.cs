using System;
using System.Collections.Generic;
using System.Linq;

namespace AppendList
{
    class Program
    {
        static void Main()
        {
            List<string> input = Console.ReadLine()?.Split(new char[] { '|' }, StringSplitOptions.RemoveEmptyEntries).ToList();
            string result = string.Empty;

            for (int cnt = input.Count - 1; cnt >= 0; cnt--)
            {
                string element = input[cnt];
                List<string> differentPats = element.Split(new char[] { ' ' }, StringSplitOptions.RemoveEmptyEntries).ToList();

                for (int i = 0; i < differentPats.Count; i++)
                {
                    result += differentPats[i] + " ";
                }
            }
            Console.WriteLine(string.Join(" ", result));
        }
    }
}
