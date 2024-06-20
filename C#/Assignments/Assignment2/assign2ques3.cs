using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Assign2ques3
{
    class Program
    {
        static void Main()
        {
            Console.WriteLine("Enter the number of elements you want in the array:");
            int n = Convert.ToInt32(Console.ReadLine());

            int[] array = new int[n];

            for (int i = 0; i < n; i++)
            {
                Console.WriteLine($"Enter element {i + 1}:");
                array[i] = Convert.ToInt32(Console.ReadLine());
            }

            double average = array.Average();
            int min = array.Min();
            int max = array.Max();

            Console.WriteLine("Array elements:");
            Console.WriteLine($"Average value of array elements: {average}");
            Console.WriteLine($"Minimum value in array: {min}");
            Console.WriteLine($"Maximum value in array: {max}");

            Console.ReadLine();
        }
    }
}
