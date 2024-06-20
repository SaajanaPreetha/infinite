using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace assign2ques8
{
    class Program
    {
        static void Main()
        {
            Console.WriteLine("Enter the first word:");
            string word1 = Console.ReadLine();

            Console.WriteLine("Enter the second word:");
            string word2 = Console.ReadLine();

            bool areSame = (word1 == word2);

            if (areSame)
            {
                Console.WriteLine($"The words '{word1}' and '{word2}' are the same.");
            }
            else
            {
                Console.WriteLine($"The words '{word1}' and '{word2}' are not the same.");
            }
            Console.ReadLine();
        }
    }
}
