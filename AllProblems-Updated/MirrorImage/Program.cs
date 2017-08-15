using System;
using System.Linq;

namespace MirrorImage
{
    class Program
    {
        static void Main()
        {
            string[] elements = Console.ReadLine().Split(' ').ToArray();

            while (true)
            {
                string position = Console.ReadLine();
                if (position == "Print")
                {
                    break;
                }

                int index = int.Parse(position);
                for (int cnt = 0; cnt < index / 2; cnt++)
                {
                    string temp = elements[cnt];
                    elements[cnt] = elements[index - cnt - 1];
                    elements[index - cnt - 1] = temp;
                }
                Array.Reverse(elements);
                for (int cnt = 0; cnt < (elements.Length - 1 - index) / 2; cnt++)
                {
                    string temp = elements[cnt];
                    elements[cnt] = elements[elements.Length - 2 - index - cnt];
                    elements[elements.Length - 2 - index - cnt] = temp;
                }
                Array.Reverse(elements);
            }
            Console.WriteLine(string.Join(" ", elements));
        }
    }
}
