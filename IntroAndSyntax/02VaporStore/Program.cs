using System;

namespace _02VaporStore
{
    class Program
    {
        static void Main()
        {
            double currentBalance = double.Parse(Console.ReadLine());
            double Balance = currentBalance;

            double outFall = 39.99;
            double cs = 15.99;
            double zplinter = 19.99;
            double honored = 59.99;
            double roverWatch = 29.99;
            double roverwatchOE = 39.99;

            for (int i = 1; i < 100; i++)
            {
                string command = Console.ReadLine();
                if (currentBalance == 0)
                {
                    Console.WriteLine("Out of money!");
                    break;
                }
                switch (command)
                {
                    case "OutFall 4"://Fallout 4
                        if (currentBalance >= outFall)
                        {
                            Console.WriteLine("Bought OutFall 4");
                            currentBalance -= outFall;
                        }
                        else if (currentBalance < outFall)
                        {
                            Console.WriteLine("Too Expensive");
                            continue;
                        }
                        break;

                    case "CS: OG"://CS:GO
                        if (currentBalance >= cs)
                        {
                            Console.WriteLine("Bought CS: OG");
                            currentBalance -= cs;
                        }
                        else if (currentBalance < cs)
                        {
                            Console.WriteLine("Too Expensive");
                            continue;
                        }
                        break;

                    case "Zplinter Zell"://Splinter Cell
                        if (currentBalance >= zplinter)
                        {
                            Console.WriteLine("Bought Zplinter Zell");
                            currentBalance -= zplinter;
                        }
                        else if (currentBalance < zplinter)
                        {
                            Console.WriteLine("Too Expensive");
                            continue;
                        }
                        break;

                    case "Honored 2"://Dishonored 2
                        if (currentBalance >= honored)
                        {
                            Console.WriteLine("Bought Honored 2");
                            currentBalance -= honored;
                        }
                        else if (currentBalance < honored)
                        {
                            Console.WriteLine("Too Expensive");
                            continue;
                        }
                        break;

                    case "RoverWatch"://Overwatch
                        if (currentBalance >= roverWatch)
                        {
                            Console.WriteLine("Bought RoverWatch");
                            currentBalance -= roverWatch;
                        }
                        else if (currentBalance < roverWatch)
                        {
                            Console.WriteLine("Too Expensive");
                            continue;
                        }
                        break;

                    case "RoverWatch Origins Edition"://Overwatch OE
                        if (currentBalance >= roverwatchOE)
                        {
                            Console.WriteLine("Bought RoverWatch Origins Edition");
                            currentBalance -= roverwatchOE;
                        }
                        else if (currentBalance < roverwatchOE)
                        {
                            Console.WriteLine("Too Expensive");
                            continue;
                        }
                        break;

                    case "Game Time":
                        Console.WriteLine("Total spent: ${0:f2}. Remaining: ${1:f2}", Balance - currentBalance, currentBalance);
                        return;

                    default:
                        Console.WriteLine("Not Found");
                        continue;
                        
                }
            }
        }
    }
}
