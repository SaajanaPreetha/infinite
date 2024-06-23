using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Assign3ques2
{
    public class Student
    {
        private int rollNo;
        private string name;
        private string studentClass;
        private string semester;
        private string branch;
        private int[] marks = new int[5];

        public Student(int rollNo, string name, string studentClass, string semester, string branch)
        {
            this.rollNo = rollNo;
            this.name = name;
            this.studentClass = studentClass;
            this.semester = semester;
            this.branch = branch;
        }

        public void GetMarks()
        {
            Console.WriteLine("Enter marks for 5 subjects:");
            for (int i = 0; i < 5; i++)
            {
                Console.Write($"Subject {i + 1}: ");
                marks[i] = Convert.ToInt32(Console.ReadLine());
            }
        }

        public void DisplayResult()
        {
            bool failed = false;
            double sum = 0;

            foreach (var mark in marks)
            {
                sum += mark;
                if (mark < 35)
                {
                    failed = true;
                    break;
                }
            }

            double average = sum / 5;

            if (failed || average < 50)
            {
                Console.WriteLine("Result: Failed");
            }
            else
            {
                Console.WriteLine("Result: Passed");
            }
        }

        public void DisplayData()
        {
            Console.WriteLine($"Roll No: {rollNo}");
            Console.WriteLine($"Name: {name}");
            Console.WriteLine($"Class: {studentClass}");
            Console.WriteLine($"Semester: {semester}");
            Console.WriteLine($"Branch: {branch}");
            Console.WriteLine("Marks:");
            for (int i = 0; i < 5; i++)
            {
                Console.WriteLine($"Subject {i + 1}: {marks[i]}");
            }
        }

        public static void Main(string[] args)
        {
            Student student1 = new Student(1, "Samuel", "10th", "First", "General");

            student1.GetMarks();

            student1.DisplayData();

            student1.DisplayResult();
            Console.ReadLine();
        }
    }
}
