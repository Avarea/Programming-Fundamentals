using System;
using System.Collections.Generic;
using System.Linq;

namespace ShellBound
{
    class Program
    {
        static void Main()
        {
            Dictionary<string, HashSet<int>> regionsData =new Dictionary<string, HashSet<int>>();

            string[] inputTokens = Console.ReadLine().Split(' ');

            while (inputTokens[0] != "Aggregate")
            {
                string regionName = inputTokens[0];
                int shell = int.Parse(inputTokens[1]);

                if (!regionsData.ContainsKey(regionName))
                {
                    regionsData.Add(regionName, new HashSet<int>());
                }
                regionsData[regionName].Add(shell);
                inputTokens = Console.ReadLine().Split(' ');
            }

            foreach (KeyValuePair<string, HashSet<int>> item in regionsData)
            {
                string regionName = item.Key;
                HashSet<int> shellsData = item.Value;

                int avg = (int)shellsData.Average();
                int sum = (int)shellsData.Sum();
                int giantShellSize = sum - avg;

                Console.WriteLine("{0} -> {1} ({2})",regionName,string.Join(", ", shellsData),giantShellSize);
            }
        }
    }
}
