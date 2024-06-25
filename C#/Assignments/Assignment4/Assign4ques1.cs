using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Assign4ques1
{
    public class Program
    {
        private string FirstName;
        private string LastName;
        public Program(string firstName, string lastName)
        {
            FirstName = firstName;
            LastName = lastName;
        }
        public static void Display(string firstName, string lastName)
        {
            Console.WriteLine(firstName.ToUpper());
            Console.WriteLine(lastName.ToUpper());
        }

        public static void Main(string[] args)
        {
            Program program = new Program("Saajana", "Preetha");
            Display(program.FirstName, program.LastName);
            Console.ReadLine();
        }
    }
}
