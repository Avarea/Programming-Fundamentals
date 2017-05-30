using System;

namespace _01ChooseADrink
{
    class Program
    {
        static void Main()
        {
            string proffession = Console.ReadLine();
            string output = string.Empty;

            if (proffession == "Athlete")
            {
                output = "Water";
            }
            else if (proffession == "Businessman" || proffession == "Businesswoman")
            {
                output = "Coffee";
            }
            else if (proffession == "SoftUni Student")
            {
                output = "Beer";
            }
            else
            {
                output = "Tea";
            }
            Console.WriteLine(output);
        }
    }
}
