using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _03Phonebook
{
    class Program
    {
        static void Main()
        {
            var phones = Console.ReadLine().Split(' ').ToArray();
            var names = Console.ReadLine().Split(' ').ToArray();
            string command = Console.ReadLine();

            while (command != "done")
            {
                for (int j = 0; j < phones.Length; j++)
                {
                    if (command == names[j])
                    {
                        Console.WriteLine($"{names[j]} -> {phones[j]}");
                    }
                }
                command = Console.ReadLine();

            }




        }
    }
}
