using System;

namespace _09CountTheIntegers
{
    class Program
    {
        static void Main()
        {

            int count = 0;

            for (int i = 1; i <= 100; i++)
            {
                try
                {
                    int num = int.Parse(Console.ReadLine());
                    count++;
                }
                catch
                {
                    break;
                }
            }
            Console.WriteLine(count);
        }
    }
}
