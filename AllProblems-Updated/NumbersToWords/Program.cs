using System;

namespace NumbersToWords
{
    class Program
    {

        static void Main()
        {
            int n = int.Parse(Console.ReadLine());
            for (int i = 0; i < n; i++)
            {
                int numbers = int.Parse(Console.ReadLine());
                Console.WriteLine(Letterize(numbers));
            }
        }

        static string Letterize(int numbers)
        {
            if (numbers > 999)
            {
                return "too large";
            }
            if (numbers < -999)
            {
                return "too small";
            }
            if (-99 < numbers && numbers < 100)
            {
                return null;
            }

            int firstDigit = Math.Abs(numbers / 100);

            string result = string.Empty;
            if (numbers < 0)
            {
                result = "minus ";
            }
            switch (firstDigit)
            {
                case 1:
                    result += "one-hundred";
                    break;
                case 2:
                    result += "two-hundred";
                    break;
                case 3:
                    result += "three-hundred";
                    break;
                case 4:
                    result += "four-hundred";
                    break;
                case 5:
                    result += "five-hundred";
                    break;
                case 6:
                    result += "six-hundred";
                    break;
                case 7:
                    result += "seven-hundred";
                    break;
                case 8:
                    result += "eight-hundred";
                    break;
                case 9:
                    result += "nine-hundred";
                    break;
            }
            int twoSecondDigits = Math.Abs(numbers % 100);
            if (twoSecondDigits < 20)
            {
                switch (twoSecondDigits)
                {
                    case 1:
                        result += " and one";
                        break;
                    case 2:
                        result += " and two";
                        break;
                    case 3:
                        result += " and three";
                        break;
                    case 4:
                        result += " and four";
                        break;
                    case 5:
                        result += " and five";
                        break;
                    case 6:
                        result += " and six";
                        break;
                    case 7:
                        result += " and seven";
                        break;
                    case 8:
                        result += " and eight";
                        break;
                    case 9:
                        result += " and nine";
                        break;
                    case 10:
                        result += " and ten";
                        break;
                    case 11:
                        result += " and eleven";
                        break;
                    case 12:
                        result += " and twelve";
                        break;
                    case 13:
                        result += " and thirteen";
                        break;
                    case 14:
                        result += " and fourteen";
                        break;
                    case 15:
                        result += " and fifteen";
                        break;
                    case 16:
                        result += " and sixteen";
                        break;
                    case 17:
                        result += " and seventeen";
                        break;
                    case 18:
                        result += " and eighteen";
                        break;
                    case 19:
                        result += " and nineteen";
                        break;
                }
                return result;
            }
            else
            {
                int secondDigit = Math.Abs(numbers % 100 / 10);
                switch (secondDigit)
                {
                    case 2:
                        result += " and twenty";
                        break;
                    case 3:
                        result += " and thirty";
                        break;
                    case 4:
                        result += " and fourty";
                        break;
                    case 5:
                        result += " and fifty";
                        break;
                    case 6:
                        result += " and sixty";
                        break;
                    case 7:
                        result += " and seventy";
                        break;
                    case 8:
                        result += " and eighty";
                        break;
                    case 9:
                        result += " and ninety";
                        break;
                }

                int thirdDigit = Math.Abs(numbers % 10);

                switch (thirdDigit)
                {
                    case 1:
                        result += " one";
                        break;
                    case 2:
                        result += " two";
                        break;
                    case 3:
                        result += " three";
                        break;
                    case 4:
                        result += " four";
                        break;
                    case 5:
                        result += " five";
                        break;
                    case 6:
                        result += " six";
                        break;
                    case 7:
                        result += " seven";
                        break;
                    case 8:
                        result += " eight";
                        break;
                    case 9:
                        result += " nine";
                        break;
                }
                return result;
            }
        }
    }
}
