using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace assess2ques1
{
    abstract class Student
    {
        public string Name { get; set; }
        public int StudentId { get; set; }
        public double Grade { get; set; }


        public Student(string name, int studentId, double grade)
        {
            Name = name;
            StudentId = studentId;
            Grade = grade;
        }

        public abstract bool IsPassed(double grade);
    }

    class Undergraduate : Student
    {
        public Undergraduate(string name, int studentId, double grade)
            : base(name, studentId, grade)
        {
        }
        public override bool IsPassed(double grade)
        {
            return grade > 70.0;
        }
    }

    class Graduate : Student
    {
        public Graduate(string name, int studentId, double grade)
            : base(name, studentId, grade)
        {
        }
        public override bool IsPassed(double grade)
        {
            return grade > 80.0;
        }
    }

    class Program
    {
        static void Main()
        {
            Undergraduate undergrad = new Undergraduate("Premitha", 102534, 74);
            Graduate grad = new Graduate("Swathi", 102546, 86);

            Console.WriteLine($"{undergrad.Name} passed the course: {undergrad.IsPassed(undergrad.Grade)}");
            Console.ReadLine();

            Console.WriteLine($"{grad.Name} passed the course: {grad.IsPassed(grad.Grade)}");
            Console.ReadLine();
        }
    }
}
