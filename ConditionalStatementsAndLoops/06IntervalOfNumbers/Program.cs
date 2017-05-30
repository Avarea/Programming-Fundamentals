using System;

namespace _06IntervalOfNumbers
{
    class Program
    {
        static void Main()
        {
            int firstNum = int.Parse(Console.ReadLine());
            int secondNum = int.Parse(Console.ReadLine());
            int temp = 0;

            if (secondNum < firstNum)
            {
                temp = firstNum;
                firstNum = secondNum;
                secondNum = temp;
            }
            for (int i = firstNum; i <= secondNum; i++)
            {
                Console.WriteLine(i);
            }
        }
    }
}
