using System;
using System.Collections.Generic;
using System.Linq;

namespace AverageStudentGrades
{
    class Program
    {
        static void Main()
        {
            Dictionary<string, List<double>> grades = new Dictionary<string, List<double>>();

            int count = int.Parse(Console.ReadLine());
            for (int cnt = 0; cnt < count; cnt++)
            {
                string[] studentGrades = Console.ReadLine()?.Split(' ');
                string name = studentGrades[0];
                double grade = double.Parse(studentGrades[1]);

                if (!grades.ContainsKey(name))
                {
                    List<double> list = new List<double>();
                    grades.Add(name, list);
                }
                grades[name].Add(grade);
            }

            foreach (KeyValuePair<string, List<double>> item in grades)
            {
                string name = item.Key;
                List<double> grade = item.Value;
                double average = grade.Average();

                Console.Write("{0} -> ", name);
                foreach (double data in grade)
                {
                    Console.Write("{0:f2} ", data);
                }
                Console.WriteLine("(avg: {0:f2})", average);
            }
        }
    }
}
