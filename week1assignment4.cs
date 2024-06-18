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
            int x, y, temp;
            Console.WriteLine("Enter a number");
            x = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Enter another number");
            y = Convert.ToInt32(Console.ReadLine());
            temp = x;
            x = y;
            y = temp;
            Console.WriteLine("First number is {0}",x);
            Console.WriteLine("Second number is {0}",y);
            Console.ReadLine();
        }
    }
}
