using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace assign2ques7
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter a word:");
            string word = Console.ReadLine();
            char[] charArray = word.ToCharArray();
            Array.Reverse(charArray);
            string reverseWord = new string(charArray);
            Console.WriteLine($"The reverse of '{word}' is: {reverseWord}");
            Console.ReadLine();
        }
    }
}
