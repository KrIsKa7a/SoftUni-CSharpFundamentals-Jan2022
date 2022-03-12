using System;
using System.Linq;
using System.Collections.Generic;
using System.Runtime.InteropServices;

namespace P06.Courses
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //Key           Value
            //CourseName -> List<StudentNames>
            Dictionary<string, List<string>> courseInfo =
                new Dictionary<string, List<string>>();

            string command;
            while ((command = Console.ReadLine()) != "end")
            {
                string[] courseArgs = command
                    .Split(" : ", StringSplitOptions.RemoveEmptyEntries)
                    .ToArray();

                string courseName = courseArgs[0];
                string studentName = courseArgs[1];

                if (!courseInfo.ContainsKey(courseName))
                {
                    courseInfo[courseName] = new List<string>();
                }

                //Returns List of students for the given courseName
                courseInfo[courseName].Add(studentName);
            }

            PrintCoursesInfo(courseInfo);
        }

        static void PrintCoursesInfo(Dictionary<string, List<string>> courseInfo)
        {
            foreach (var kvp in courseInfo)
            {
                string courseName = kvp.Key;
                List<string> students = kvp.Value;

                Console.WriteLine($"{courseName}: {students.Count}");
                foreach (string studentName in students)
                {
                    Console.WriteLine($"-- {studentName}");
                }
            }
        }
    }
}
