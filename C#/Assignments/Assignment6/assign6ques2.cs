using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Assign6ques2
{
    class Program
    {
        static void Main()
        {
            Console.WriteLine("Enter a list of words you want");
            string input = Console.ReadLine();

            string[] words = input.Split(new char[] { ' ' }, StringSplitOptions.RemoveEmptyEntries);

            List<string> filteredWords = new List<string>();

            foreach (string word in words)
            {
                
                if (word.Length > 0 && word[0] == 'a' && word[word.Length - 1] == 'm')
                {
                    filteredWords.Add(word);
                }
            }

            Console.WriteLine("\nWords starting with 'a' and ending with 'm':");
            foreach (string word in filteredWords)
            {
                Console.WriteLine(word);
            }
            Console.ReadLine();
        }
    }
}
