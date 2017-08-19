using System;
using System.Collections.Generic;
using System.Linq;

namespace Key_KeyValue_Value
{
    class Program
    {
        static void Main()
        {
            var pairs = new Dictionary<string, List<string>>();
            string key = Console.ReadLine();
            string value = Console.ReadLine();
            int n = int.Parse(Console.ReadLine());

            for (int cnt = 0; cnt < n; cnt++)
            {
                string[] input = Console.ReadLine()?.Split(new string[] { " => " }, StringSplitOptions.RemoveEmptyEntries);
                string searchKey = input[0];
                string[] valuesArray = input[1].Split(';').ToArray();

                if (searchKey.Contains(key))
                {
                    if (!pairs.ContainsKey(searchKey))
                    {
                        pairs.Add(searchKey, new List<string>());
                    }
                    foreach (string searchValue in valuesArray)
                    {
                        if (searchValue.Contains(value))
                        {
                            pairs[searchKey].Add(searchValue);
                        }
                    }
                }
            }

            foreach (KeyValuePair<string, List<string>> item in pairs)
            {
                string currentKey = item.Key;
                List<string> list = item.Value;

                Console.WriteLine($"{currentKey}:");
                for (int cnt = 0; cnt < list.Count; cnt++)
                {
                    Console.WriteLine($"-{list[cnt]}");
                }
            }
        }
    }
}
