using System;
using System.Collections.Generic;

namespace Dict_Ref
{
    class Program
    {
        static void Main()
        {
            Dictionary<string, int> values = new Dictionary<string, int>();
            string[] tokens = Console.ReadLine()?.Split(new char[] {' ', '='}, StringSplitOptions.RemoveEmptyEntries);

            while (tokens[0] != "end")
            {
                string keyInput = tokens[0];
                string valueInput = tokens[1];

                int numberValue;
                if (int.TryParse(valueInput, out numberValue))
                {
                    values[keyInput] = numberValue;
                }
                else
                {
                    if (values.ContainsKey(valueInput))
                    {
                        values[keyInput] = values[valueInput];
                    }
                }

                tokens = Console.ReadLine()?.Split(new char[] { ' ', '=' }, StringSplitOptions.RemoveEmptyEntries);
            }

            foreach (KeyValuePair<string, int> item in values)
            {
                Console.WriteLine($"{item.Key} === {item.Value}");
            }
        }
    }
}
