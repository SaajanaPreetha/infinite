using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Assign4ques5
{
    public class Doctor
    {
        private int regnNo;
        private string name;
        private decimal feesCharged;

        public int RegnNo
        {
            get { return regnNo; }
            set { regnNo = value; }
        }

        public string Name
        {
            get { return name; }
            set { name = value; }
        }

        public decimal FeesCharged
        {
            get { return feesCharged; }
            set { feesCharged = value; }
        }

        public Doctor(int regnNo, string name, decimal feesCharged)
        {
            RegnNo = regnNo;
            Name = name;
            FeesCharged = feesCharged;
        }

        public void Display()
        {
            Console.WriteLine($"Doctor Details:");
            Console.WriteLine($"Registration Number: {RegnNo}");
            Console.WriteLine($"Name: {Name}");
            Console.WriteLine($"Fees Charged: {FeesCharged:C}"); // Display as currency
        }

        public static void Main(string[] args)
        {
            Doctor doctor = new Doctor(654723, "Dr.Samuel", 2100m);

            doctor.Display();
            Console.ReadLine();

        }
    }
}
