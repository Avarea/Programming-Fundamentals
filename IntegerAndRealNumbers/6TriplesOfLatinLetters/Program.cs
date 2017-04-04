using System;


namespace _6TriplesOfLatinLetters
{
    class Program
    {
        static void Main()
        {
            int num = int.Parse(Console.ReadLine());

            for (char i = 'a'; i < num + 'a'; i++)
            {
                for (char j = 'a'; j < num + 'a'; j++)
                {
                    for (char k = 'a'; k < num + 'a'; k++)
                    {
                        Console.WriteLine($"{i}{j}{k}");
                    }
                }
            }
        }
    }
}
