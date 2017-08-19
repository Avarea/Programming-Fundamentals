using System;
using System.Collections.Generic;

namespace MixedPhones
{
    class Program
    {
        static void Main()
        {
            SortedDictionary<string, long> phonebook = new SortedDictionary<string, long>();
            string[] tokens = Console.ReadLine()?.Split(new char[] {' ', ':'}, StringSplitOptions.RemoveEmptyEntries);

            while (tokens[0] != "Over")
            {
                string name;
                long phone;
                if (long.TryParse(tokens[0], out phone))
                {
                    name = tokens[1];
                    phone = Convert.ToInt64(tokens[0]);
                    phonebook[name] = phone;
                }
                else
                {
                    name = tokens[0];
                    phone = Convert.ToInt64(tokens[1]);
                    phonebook[name] = phone;
                }
                tokens = Console.ReadLine()?.Split(new char[] { ' ', ':' }, StringSplitOptions.RemoveEmptyEntries);
            }

            foreach (KeyValuePair<string, long> item in phonebook)
            {
                Console.WriteLine($"{item.Key} -> {item.Value}");
            }
        }
    }
}
