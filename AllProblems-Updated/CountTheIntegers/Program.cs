using System;

namespace CountTheIntegers
{
    class Program
    {
        static void Main()
        {
            int counter = 0;
            try
            {
                for (int i = 0; i < 100; i++)
                {
                    int number = int.Parse(Console.ReadLine());
                    counter++;
                }
            }
            catch 
            {

            }
            Console.WriteLine(counter);
        }
    }
}
