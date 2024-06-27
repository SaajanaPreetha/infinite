using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Assign4ques2
{
    class Lettercount
    {
        static void Main()
        {
            Console.WriteLine("Enter a string");
            string a = Console.ReadLine();

            Console.WriteLine("Enter the letter to count");
            char b = Console.ReadKey().KeyChar;

            int count = 0;

            foreach (char ch in a)
            {
                if (currentChar == letterToCount)
                {
                    count++;
                }
            }

            Console.WriteLine($"\nThe letter '{b}' appears {count} times in the word '{a}'.");
        }
    }
}
