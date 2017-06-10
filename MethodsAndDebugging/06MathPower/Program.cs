using System;

namespace _06MathPower
{
    class Program
    {
        static void Main()
        {
            double number = double.Parse(Console.ReadLine());
            int power = int.Parse(Console.ReadLine());


            Console.WriteLine(GetPower(number, power));
       
            
        }

         static double GetPower(double number, int power)
         {
             return Math.Pow(number, power);
         }
    }
}
