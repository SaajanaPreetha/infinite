using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Scholarshipcalculation
{
    public class Scholarship
    {
        public decimal Merit(int marks, decimal fees)
        {
            decimal scholarshipAmount = 0;

            if (marks >= 70 && marks <= 80)
            {
                scholarshipAmount = 0.2m * fees; 
            }
            else if (marks > 80 && marks <= 90)
            {
                scholarshipAmount = 0.3m * fees; 
            }
            else if (marks > 90)
            {
                scholarshipAmount = 0.5m * fees; 
            }

            return scholarshipAmount;
        }

        public static void Main(string[] args)
        {
            Scholarship scholarship = new Scholarship();
            int marks = 72;
            decimal fees = 1000; 

            decimal scholarshipAmount = scholarship.Merit(marks, fees);
            Console.WriteLine($"Scholarship amount for marks {marks} and fees {fees}: {scholarshipAmount}");
            Console.ReadLine();
        }
    }
}
