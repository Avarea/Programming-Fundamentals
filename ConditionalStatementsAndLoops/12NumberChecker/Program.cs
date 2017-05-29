using System;


namespace _12NumberChecker
{
    class Program
    {
        static void Main()
        {
            try
            {
                int n = int.Parse(Console.ReadLine());
                Console.WriteLine("It is a number.");
            }
            catch 
            {
                Console.WriteLine("Invalid input!");
                
            }
        }
    }
}
