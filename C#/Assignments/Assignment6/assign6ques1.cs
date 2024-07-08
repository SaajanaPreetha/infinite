using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Assign6ques1
{
    class Squareofnumbers
    {
        static void Main()
        {
            Console.WriteLine("Input required numbers");
            string input = Console.ReadLine();

            string[] numberStrings = input.Split(' ');

            Console.WriteLine("\nNumbers and their squares where square > 20:");
            foreach (string numberStr in numberStrings)
            {
                if (int.TryParse(numberStr, out int number))
                {
                    int square = number * number;
                    if (square > 20)
                    {
                        Console.WriteLine($"Number: {number}, Square: {square}");
                        Console.ReadLine();
                    }
                }
                else
                {
                    Console.WriteLine($"Invalid input: '{numberStr}'. Skipping.");
                    Console.ReadLine();
                }
            }
        }
    }
}
