using System;
using System.Linq;
using System.Collections.Generic;

namespace P04.Students
{
    internal class Program
    {
        static void Main(string[] args)
        {
            List<Student> students = new List<Student>();

            int n = int.Parse(Console.ReadLine());
            for (int i = 1; i <= n; i++)
            {
                string[] studentArgs = Console.ReadLine()
                    .Split(' ', StringSplitOptions.RemoveEmptyEntries)
                    .ToArray();

                string currStudentFirstName = studentArgs[0];
                string currStudentLastName = studentArgs[1];
                double currStudentGrade = double.Parse(studentArgs[2]);

                Student currStudent =
                    new Student(currStudentFirstName, currStudentLastName, currStudentGrade);

                students.Add(currStudent);
            }

            //Can be ommitted
            students = students
                .OrderByDescending(s => s.Grade)
                .ToList();

            foreach (Student student in students)
            {
                Console.WriteLine(student);
            }
        }
    }

    class Student
    {
        public Student(string firstName, string lastName, double grade)
        {
            //Always called when new Student is being created
            this.FirstName = firstName;
            this.LastName = lastName;
            this.Grade = grade;
        }

        public string FirstName { get; set; }

        public string LastName { get; set; }

        public double Grade { get; set; }

        public override string ToString()
        {
            //Console.WriteLine() -> This method is being invoked
            return $"{this.FirstName} {this.LastName}: {this.Grade:f2}";
        }
    }
}
