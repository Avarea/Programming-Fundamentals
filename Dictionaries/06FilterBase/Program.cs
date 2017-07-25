using System;
using System.Collections.Generic;

namespace _06FilterBase
{
    class Program
    {
        static void Main()
        {
            Dictionary<string, int> emplyeesAges = new Dictionary<string, int>();
            Dictionary<string, double> emplyeesSalary = new Dictionary<string, double>();
            Dictionary<string, string> employeesPosition = new Dictionary<string, string>();

            string[] token = Console.ReadLine().Split(new char[] {' ', '-', '>'}, StringSplitOptions.RemoveEmptyEntries);
            while (token[0] != "filter")
            {
                string name = token[0];
                string value = token[1];
                int age;
                double salary;

                if (int.TryParse(value, out age))
                {
                    emplyeesAges[name] = age;
                }
                else if (double.TryParse(value, out salary))
                {
                    emplyeesSalary[name] = salary;
                }
                else
                {
                    employeesPosition[name] = value;
                }

                token = Console.ReadLine().Split(new char[] { ' ', '-', '>' }, StringSplitOptions.RemoveEmptyEntries);
            }
            string condition = Console.ReadLine().ToLower();

            if (condition == "position")
            {
                foreach (KeyValuePair<string, string> employee in employeesPosition)
                {
                    Console.WriteLine($"Name: {employee.Key}");
                    Console.WriteLine($"Position: {employee.Value}");
                    Console.WriteLine(new string('=', 20));
                }
            }
            else if (condition == "age")
            {
                foreach (KeyValuePair<string, int> employee in emplyeesAges)
                {
                    Console.WriteLine($"Name: {employee.Key}");
                    Console.WriteLine($"Age: {employee.Value}");
                    Console.WriteLine(new string('=', 20));
                }
            }
            else
            {
                foreach (KeyValuePair<string, double> employee in emplyeesSalary)
                {
                    Console.WriteLine($"Name: {employee.Key}");
                    Console.WriteLine($"Salary: {employee.Value:f2}");
                    Console.WriteLine(new string('=', 20));
                }
            }
        }
    }
}
