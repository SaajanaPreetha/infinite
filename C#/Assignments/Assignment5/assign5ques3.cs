using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Assign5ques3
{
    public class Employee
    {
        public int Empid { get; set; }
        public string Empname { get; set; }
        public float Salary { get; set; }

        public Employee(int empid, string empname, float salary)
        {
            Empid = empid;
            Empname = empname;
            Salary = salary;
        }

        public virtual void Display()
        {
            Console.WriteLine($"Employee ID: {Empid}");
            Console.WriteLine($"Employee Name: {Empname}");
            Console.WriteLine($"Salary: {Salary}");
        }
    }

    public class ParttimeEmployee : Employee
    {
        public float Wages { get; set; }

        public ParttimeEmployee(int empid, string empname, float salary, float wages)
            : base(empid, empname, salary)
        {
            Wages = wages;
        }

        public override void Display()
        {
            base.Display();
            Console.WriteLine($"Wages: {Wages}");
        }
    }

    public class Test
    {
        public static void Main()
        {
            Console.WriteLine("Enter details for Part-time Employee");
            Console.Write("Employee ID");
            int empid = Convert.ToInt32(Console.ReadLine());
            Console.Write("Employee Name ");
            string empname = Console.ReadLine();
            Console.Write("Salary ");
            float salary = Convert.ToSingle(Console.ReadLine());
            Console.Write("Wages ");
            float wages = Convert.ToSingle(Console.ReadLine());

            ParttimeEmployee partTimeEmp = new ParttimeEmployee(empid, empname, salary, wages);

            Console.WriteLine(" Part-time Employee Details ");
            partTimeEmp.Display();
            Console.ReadLine();
        }
    }
}
  
