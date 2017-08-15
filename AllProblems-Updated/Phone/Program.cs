using System;

namespace Phone
{
    class Program
    {
        static string[] numbers;
        static string[] names;

        static void Main()
        {
           numbers = Console.ReadLine()?.Split(' ');
           names = Console.ReadLine()?.Split(' ');
            string[] inputTokens = Console.ReadLine().Split(' ');

            while (inputTokens[0] != "done")
            {
                string command = inputTokens[0];
                string argument = inputTokens[1];
                string name;
                string telephoneNumber;
                string output;

                if (IsNumber(argument))
                {
                    name = GetEntry(argument);
                    telephoneNumber = argument;
                    output = name;
                }
                else
                {
                    name = argument;
                    telephoneNumber = GetEntry(argument);
                    output = telephoneNumber;
                }
                int digitSum = GetDigitSum(telephoneNumber);
                if (command == "call")
                {
                    Console.WriteLine("calling {0}...", output);
                    if (digitSum % 2 == 1)
                    {
                        Console.WriteLine("no answer");
                    }
                    else
                    {
                        int minutes = digitSum / 60;
                        int seconds = digitSum % 60;
                        Console.WriteLine("call ended. duration: {0}:{1}", minutes.ToString().PadLeft(2, '0'), seconds.ToString().PadLeft(2, '0'));
                    }
                }
                else if(command == "message")
                {
                    Console.WriteLine("sending sms to {0}...", output);
                    if (digitSum % 2 == 1)
                    {
                        Console.WriteLine("busy");
                    }
                    else
                    {
                        Console.WriteLine("meet me there");
                    }
                }
                inputTokens = Console.ReadLine().Split(' ');
            }
        }

        static int GetDigitSum(string telephoneNumber)
        {
            int sum = 0;
            for (int cnt = 0; cnt < telephoneNumber.Length; cnt++)
            {
                if (IsDigit(telephoneNumber[cnt]))
                {
                    sum += telephoneNumber[cnt] - '0';
                }
            }
            return sum;
        }

        static string GetEntry(string input)
        {
            for (int cnt = 0; cnt < numbers.Length; cnt++)
            {
                if (names[cnt] == input)
                {
                    return numbers[cnt];
                }
                else if (numbers[cnt] == input)
                {
                    return names[cnt];
                }
            }
            return string.Empty;
        }

        static bool IsNumber(string input)
        {
            for (int cnt = 0; cnt < input.Length; cnt++)
            {
                if (IsDigit(input[cnt]))
                {
                    return true;
                }
            }
            return false;
        }

        static bool IsDigit(char symbol)
        {
            if (symbol >= '0' && symbol <= '9')
            {
                return true;
            }
            return false;
        }
    }
}
