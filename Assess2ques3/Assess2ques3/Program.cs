using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

public class NegativeNumberException : Exception
{
    public NegativeNumberException()
        : base("Error: The number cannot be negative.")
    {
    }
}

class Program
{
    // Method to validate if number is negative
    static void ValidateNumber(int number)
    {
        if (number < 0)
        {
            throw new NegativeNumberException();
        }
        else
        {
            Console.WriteLine($"Number {number} is valid.");
        }
    }

    static void Main()
    {
        try
        {
            // Test cases with negative and non-negative numbers
            ValidateNumber(12); // Will throw NegativeNumberException
            ValidateNumber(-5); // Valid number
        }
        catch (NegativeNumberException ex)
        {
            Console.WriteLine(ex.Message);
            Console.ReadLine();
            // Handle the exception (e.g., log it, notify user, etc.)
        }
        catch (Exception ex)
        {
            Console.WriteLine($"An unexpected error occurred: {ex.Message}");
            Console.ReadLine();
        }
    }
}
