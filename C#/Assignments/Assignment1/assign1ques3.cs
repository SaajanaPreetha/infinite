using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace week1assignment3
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Enter a number");
            int x = Convert.ToInt32(Console.ReadLine());

            Console.Write("Enter another number");
            int y = Convert.ToInt32(Console.ReadLine());

            int sum = x + y;
            Console.WriteLine("addition is {0}", sum);

            int difference = x - y;
            Console.WriteLine("Difference is {0}", difference);

            int multiplication = x * y;
            Console.WriteLine("Product is {0}" , multiplication);

            int division = x / y;
            Console.WriteLine("Divide product is {0}", division);

            Console.ReadLine();

        }
        
    }
}
