using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;

namespace assess4ques1
{
    class Program
    {
        static void Main()
        {
            string filePath = "test.txt";

            Console.WriteLine("Enter text to append:");
            string inputText = Console.ReadLine();

            try
            {
                using (StreamWriter writer = new StreamWriter(filePath, true))
                {
                    writer.WriteLine(inputText); 
                }

                Console.WriteLine("Text appended to file successfully.");
            }
            catch (Exception ex)
            {
                Console.WriteLine($"An error occurred: {ex.Message}");
            }
            Console.ReadLine();
        }
    }
}
