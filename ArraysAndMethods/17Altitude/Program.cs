using System;
using System.Linq;
using System.Collections.Generic;


namespace _17Altitude
{
    class Program
    {
        static void Main()
        {
            var array = Console.ReadLine().Split(new char[] { ' ' },StringSplitOptions.RemoveEmptyEntries).ToList();
            var initialAltitude = double.Parse(array[0]);
            string result = string.Empty;
            bool isCrashed = false;

            for (int i = 1; i < array.Count; i+= 2)
            {
                var command = array[i];
                var number = double.Parse(array[i + 1]);

                switch (command)
                {
                    case "up":
                        initialAltitude += number;
                        break;
                    case "down":
                        initialAltitude -= number;
                        break;
                }

                if (initialAltitude <= 0)
                {
                    result = "crashed";
                    isCrashed = true;
                    break;
                }
                if (!isCrashed)
                {
                    result = $"got through safely. current altitude: {initialAltitude}m";
                }
            }
            Console.WriteLine(result);
        }
    }
}
