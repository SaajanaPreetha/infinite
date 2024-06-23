using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp3
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter a number");
            int x = Convert.ToInt32(Console.ReadLine());
            if(x > 0)
            {
                Console.WriteLine("Number is positive");
            }
            else if(x < 0)
            {
                Console.WriteLine("Number is negative");
            }
            else
            {
                Console.WriteLine("Number is zero");
            }
            Console.ReadLine();
        }
    }
}
