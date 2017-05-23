using System;

namespace _02AddTwoNumberse
{
    class Program
    {
        static void Main()
        {
            double firstNumber = double.Parse(Console.ReadLine());
            double secondNumber = double.Parse(Console.ReadLine());

            Console.WriteLine("{0} + {1} = {2}",firstNumber, secondNumber,  firstNumber + secondNumber);
        }
    }
}
