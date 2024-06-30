using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Assign5ques4
{
    public interface IStudent
    {
        int StudentId { get; set; }
        string Name { get; set; }

        void ShowDetails();
    }

    public class Dayscholar : IStudent
    {
        public int StudentId { get; set; }
        public string Name { get; set; }

        public void ShowDetails()
        {
            Console.WriteLine($"Dayscholar Details");
            Console.WriteLine($"Student ID: {StudentId}");
            Console.WriteLine($"Name: {Name}");
            Console.WriteLine($"Type: Dayscholar");
        }
    }

    public class Resident : IStudent
    {
        public int StudentId { get; set; }
        public string Name { get; set; }

        public void ShowDetails()
        {
            Console.WriteLine($"Resident Details");
            Console.WriteLine($"Student ID: {StudentId}");
            Console.WriteLine($"Name: {Name}");
            Console.WriteLine($"Type: Resident");
        }
    }

    public class Test
    {
        public static void Main()
        {
            IStudent dayscholar = new Dayscholar
            {
                StudentId = 12,
                Name = " Swati "
            };

            IStudent resident = new Resident
            {
                StudentId = 15,
                Name = " Sanjana "
            };

            dayscholar.ShowDetails();
            Console.WriteLine();
            resident.ShowDetails();
            Console.ReadLine();
        }
    }
}
