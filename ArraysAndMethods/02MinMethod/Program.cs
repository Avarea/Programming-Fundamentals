using System;

namespace _02MinMethod
{
    class Program
    {
        static void Main()
        {
            int num1 = int.Parse(Console.ReadLine());
            int num2 = int.Parse(Console.ReadLine());
            int num3 = int.Parse(Console.ReadLine());

            Console.WriteLine(GetMin(num1, GetMin(num2, num3)));


        }

        static int GetMin(int num1, int num2)
        {
            if (num1 > num2)
            {
                return num2;
            }
            else
            {
                return num1;
            }
            

        }
    }
}
