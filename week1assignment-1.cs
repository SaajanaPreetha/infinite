using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace assignment_1
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Enter the first number");
            int x = Convert.ToInt32(Console.ReadLine());

            Console.Write("Enter the second number");
            int y = Convert.ToInt32(Console.ReadLine());

            if (x==y)
            {
                Console.WriteLine("The two integers are equal");
            }
            else
            {
                Console.WriteLine("The two integers are not equal");
            }

            Console.ReadLine();
        }
    }
}
