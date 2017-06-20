using System;

namespace PassedOrFailed
{
    class Program
    {
        static void Main()
        {
            double grade = double.Parse(Console.ReadLine());

            Console.WriteLine(GetScore(grade));
        }

        private static string GetScore(double grade)
        {
            if (grade >= 3.00)
            {
                return "Passed!";
            }
            else
            {
                return "Failed!";
            }
        }
    }
}
