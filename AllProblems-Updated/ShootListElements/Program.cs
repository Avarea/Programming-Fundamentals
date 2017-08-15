using System;
using System.Collections.Generic;
using System.Linq;

namespace ShootListElements
{
    class Program
    {
        static void Main()
        {
            List<int> numbers = new List<int>();

            string input = Console.ReadLine();
            int lastShotNumber = 0;

            while (true)
            {
                if (input == "bang")
                {
                    if (numbers.Count == 0)
                    {
                        Console.WriteLine("nobody left to shoot! last one was {0}", lastShotNumber);
                        break;
                    }
                    double average = numbers.Average();
                    for (int cnt = 0; cnt < numbers.Count; cnt++)
                    {
                        if (numbers[cnt] < average)
                        {
                            lastShotNumber = numbers[cnt];
                            numbers.RemoveAt(cnt);
                            Console.WriteLine("shot " + lastShotNumber);
                            break;
                        }
                        else if (numbers.Count == 1)
                        {
                            lastShotNumber = numbers[0];
                            numbers.RemoveAt(0);
                            Console.WriteLine("shot " + lastShotNumber);
                            break;
                        }
                    }

                    for (int cnt = 0; cnt < numbers.Count; cnt++)
                    {
                        numbers[cnt]--;
                    }
                }
                else if (input == "stop")
                {
                    if (numbers.Count == 0)
                    {
                        Console.WriteLine("you shot them all. last one was {0}", lastShotNumber);
                        break;
                    }
                    else
                    {
                        Console.WriteLine("survivors: {0}", string.Join(" ", numbers));
                        break;
                    }
                }
                else
                {
                    int number = int.Parse(input);
                    numbers.Insert(0, number);
                }
                input = Console.ReadLine();
            }
        }
    }
}
