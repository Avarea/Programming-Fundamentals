using System;
using System.Collections.Generic;
using System.Linq;

namespace _01AverageStudentGrades
{
    class Program
    {
        static void Main()
        {
            Dictionary<string, List<double>> gradesDictionary = new Dictionary<string, List<double>>();

            int students = int.Parse(Console.ReadLine());

            for (int i = 1; i <= students; i++)
            {
                string[] input = Console.ReadLine()?.Split(' ');

                string name = input[0];
                double grade = double.Parse(input[1]);

                if (!gradesDictionary.ContainsKey(name))
                {
                    gradesDictionary.Add(name, new List<double>());
                }
                gradesDictionary[name].Add(grade);
            }

            foreach (var studentsData in gradesDictionary)
            {
                string name = studentsData.Key;
                List<double> grades = studentsData.Value;
                double average = grades.Average();

                Console.Write("{0} -> ", name);
                foreach (var grade in grades)
                {
                    Console.Write("{0:f2} ", grade);   
                }
                Console.WriteLine("(avg: {0:f2})", average);
            }
        }
    }
}
