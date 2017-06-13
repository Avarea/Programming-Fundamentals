using System;
using System.Linq;

namespace _15CountOfCapitalLettersInArray
{
    class Program
    {
        static void Main()
        {
            var text = Console.ReadLine().Split(new char[] { ' ' },StringSplitOptions.RemoveEmptyEntries).ToArray();
            int count = 0;

            var singleLeters = text.Where(s => s.Length == 1).ToArray();



            foreach (var letter in singleLeters)
            {
                var chars = char.Parse(letter);

                if (chars >= 65 && chars <= 90)
                {
                    count++;
                }
            }

            Console.WriteLine(count);
        }
    }
}
