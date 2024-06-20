using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp9
{
    class Program
    {
        static void Main()
        {
            Console.WriteLine("Enter the first number");
            int x = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("Enter the second number");
            int y = Convert.ToInt32(Console.ReadLine());

            int sum = x + y;

            if (x == y)
            {
                Console.WriteLine("Result: " + 3 * sum);
            }
            else
            {
                Console.WriteLine("Result: " + sum);
            }
            Console.ReadLine();
        }
    }
}
