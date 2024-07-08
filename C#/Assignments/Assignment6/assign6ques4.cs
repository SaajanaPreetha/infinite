using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace assign6soln4
{
    class Program
    {
        const decimal TotalFare = 1000;

        static void Main()
        {
            Console.WriteLine("Enter age:");
            if (int.TryParse(Console.ReadLine(), out int age))
            {
                string result = CalculateConcession(age);
                Console.WriteLine(result);
            }
            else
            {
                Console.WriteLine("Invalid age input.");
            }
            Console.ReadLine();
        }

        static string CalculateConcession(int age)
        {
            if (age <= 5)
            {
                return "Little Champs - Free Ticket";
            }
            else if (age > 60)
            {
                decimal discountedFare = TotalFare * 0.7m; 
                return $"Senior Citizen - Calculated Fare: {discountedFare:C}";
            }
            else
            {
                return $"Ticket Booked - Fare: {TotalFare:C}";
            }
        }
    }
}
