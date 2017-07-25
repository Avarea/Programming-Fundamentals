using System;
using System.Collections.Generic;

namespace _03MixedPhones
{
    class Program
    {
        static void Main()
        {
            SortedDictionary<string, long> dictionary = new SortedDictionary<string, long>();

            string[] input = Console.ReadLine().Split(new char[] { ':', ' ' }, StringSplitOptions.RemoveEmptyEntries);

            while (input[0] != "Over")
            {
                string name;
                long phone;
                if (long.TryParse(input[0], out phone))
                {
                    name = input[1];
                    phone = Convert.ToInt32(input[0]);
                    dictionary[name] = phone;
                }
                else
                {
                    name = input[0];
                    phone = Convert.ToInt64(input[1]);
                    dictionary[name] = phone;
                }
                input = Console.ReadLine().Split(new char[] { ':', ' ' }, StringSplitOptions.RemoveEmptyEntries);
            }

            foreach (KeyValuePair<string, long> item in dictionary)
            {
                Console.WriteLine($"{item.Key} -> {item.Value}");
            }
        }
    }
}
