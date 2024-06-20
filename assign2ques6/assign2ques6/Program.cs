using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace assign2ques6
{
    class Program
    {
        static void Main()
        {
            {
                Console.WriteLine("Enter a word:");
                string word = Console.ReadLine();
                int length = word.Length;
                Console.WriteLine($"The length of '{word}' is: {length}");
                Console.ReadLine();
            }
        }
    }
}
