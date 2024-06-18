using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp4
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter a number");
            string input = Console.ReadLine();

            for (int i = 0; i < 4; i++)
            {
                if (i > 0)
                {
                    Console.WriteLine(" ");
                }

                Console.WriteLine(input);
            }
            Console.WriteLine();

            for (int i = 0; i < 4; i++)
            {
                Console.WriteLine(input);
            }
            Console.WriteLine();
        }
     
    }
}
