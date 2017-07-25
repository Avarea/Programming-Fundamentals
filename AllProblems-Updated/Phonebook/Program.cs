using System;
using System.Linq;

namespace Phonebook
{
    class Program
    {
        static void Main()
        {
            string[] phoneNumbers = Console.ReadLine()?.Split(' ').ToArray();
            string[] names = Console.ReadLine()?.Split(' ').ToArray();

            string command = Console.ReadLine();
            while (command != "done")
            {
                for (int cntIndex = 0; cntIndex < names.Length; cntIndex++)
                {
                    if (command == names[cntIndex])
                    {
                        Console.WriteLine($"{names[cntIndex]} -> {phoneNumbers[cntIndex]}");
                    } 
                }
                command = Console.ReadLine();
            }
        }
    }
}
