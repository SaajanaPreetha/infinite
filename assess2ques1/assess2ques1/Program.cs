using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace assess2ques1
{
    abstract class Student
    {
        // Properties
        public string Name { get; set; }
        public int StudentId { get; set; }
        public double Grade { get; set; }

        // Constructor
        public Student(string name, int studentId, double grade)
        {
            Name = name;
            StudentId = studentId;
            Grade = grade;
        }

        // Abstract method to check if student passed
        public abstract bool IsPassed(double grade);
    }

    // Subclass Undergraduate inheriting from Student
    class Undergraduate : Student
    {
        // Constructor calling base class constructor
        public Undergraduate(string name, int studentId, double grade)
            : base(name, studentId, grade)
        {
        }

        // Override IsPassed method for Undergraduate
        public override bool IsPassed(double grade)
        {
            return grade > 70.0;
        }
    }

    // Subclass Graduate inheriting from Student
    class Graduate : Student
    {
        // Constructor calling base class constructor
        public Graduate(string name, int studentId, double grade)
            : base(name, studentId, grade)
        {
        }

        // Override IsPassed method for Graduate
        public override bool IsPassed(double grade)
        {
            return grade > 80.0;
        }
    }

    class Program
    {
        static void Main()
        {
            // Creating objects of Undergraduate and Graduate
            Undergraduate undergrad = new Undergraduate("Premitha", 102534, 74);
            Graduate grad = new Graduate("Swathi", 102546, 86);

            // Testing IsPassed method for Undergraduate
            Console.WriteLine($"{undergrad.Name} passed the course: {undergrad.IsPassed(undergrad.Grade)}");
            Console.ReadLine();

            // Testing IsPassed method for Graduate
            Console.WriteLine($"{grad.Name} passed the course: {grad.IsPassed(grad.Grade)}");
            Console.ReadLine();
        }
    }
}
