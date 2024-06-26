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
            ValidateNumber(12); 
            ValidateNumber(-5); 
        }
        catch (NegativeNumberException ex)
        {
            Console.WriteLine(ex.Message);
            Console.ReadLine();
        }
        catch (Exception ex)
        {
            Console.WriteLine($"An unexpected error occurred: {ex.Message}");
            Console.ReadLine();
        }
    }
}
