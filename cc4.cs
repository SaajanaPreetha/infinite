using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp5
{
    class Program
    {
        static void Main()
        {
            int x;
            int product;
            Console.WriteLine("Enter a number");
            x = Convert.ToInt32(Console.ReadLine()); 
            product = x * 1;
            Console.WriteLine("The result is : {0} x {1} = {2}", x, 1, product);
            product  = x * 2;
            Console.WriteLine("             : {0} x {1} = {2}", x, 2, product);
            product  = x * 3;
            Console.WriteLine("             : {0} x {1} = {2}", x, 3, product);
            product  = x * 4;
            Console.WriteLine("             : {0} x {1} = {2}", x, 4, product);
            product = x * 5;
            Console.WriteLine("             : {0} x {1} = {2}", x, 5, product);
            product = x * 6;
            Console.WriteLine("             : {0} x {1} = {2}", x, 6, product);
            product = x * 7;
            Console.WriteLine("             : {0} x {1} = {2}", x, 7, product);
            product = x * 8;
            Console.WriteLine("             : {0} x {1} = {2}", x, 8, product);
            product = x * 9;
            Console.WriteLine("             : {0} x {1} = {2}", x, 9, product);
            product = x * 10;
            Console.WriteLine("             : {0} x {1} = {2}", x, 10, product);

            Console.ReadLine();

        }
        
        

    }
}

