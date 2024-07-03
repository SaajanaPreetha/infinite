using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Assess3ques1
{
    public class Cricket
    {
        public void PointsCalculation(int no_of_matches)
        {
            int[] scores = new int[no_of_matches];
            int sum  = 0;
            double average = 0.0;

            for (int i = 0; i < no_of_matches; i++)
            {
                Console.WriteLine($"Enter the score for match number {i + 1} ");
                scores[i] = Convert.ToInt32(Console.ReadLine());
                sum += scores[i];
            }

            if (no_of_matches > 0)
            {
                average = (double)sum / no_of_matches;
            }

            Console.WriteLine($"Total points scored: {sum}");
            Console.WriteLine($"Average points scored per match: {average}");
        }
    }

    class Program
    {
        static void Main()
        {
            Console.WriteLine("Enter the total number of matches: ");
            int numMatches = Convert.ToInt32(Console.ReadLine());

            Cricket cricket = new Cricket();
            cricket.PointsCalculation(numMatches);
            Console.ReadLine();
        }
    }
}
