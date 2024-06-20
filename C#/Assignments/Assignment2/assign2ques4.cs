using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace assign2ques4
{
    class Program
    {
        static void Main()
        {
            int[] marks = new int[10];
            int total = 0;
            double average;
            int min = int.MaxValue;
            int max = int.MinValue;

            for (int i = 0; i < marks.Length; i++)
            {
                Console.Write($"Enter mark {i + 1}: ");
                marks[i] = Convert.ToInt32(Console.ReadLine());
                total += marks[i];

                if (marks[i] < min)
                    min = marks[i];

                if (marks[i] > max)
                    max = marks[i];
            }

            average = (double)total / marks.Length;

            Console.WriteLine($"Total marks: {total}");
            Console.WriteLine($"Average marks: {average:F2}");
            Console.WriteLine($"Minimum marks: {min}");
            Console.WriteLine($"Maximum marks: {max}");

            Array.Sort(marks);
            Console.WriteLine("Marks in ascending order:");
            PrintMarks(marks);

            Array.Reverse(marks);
            Console.WriteLine("Marks in descending order:");
            PrintMarks(marks);

            Console.ReadLine();
        }

        static void PrintMarks(int[] marks)
        {
            foreach (var mark in marks)
            {
                Console.Write(mark + " ");
            }
            Console.WriteLine();
        }
        
    }
}
