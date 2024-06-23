using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Assign3ques4
{
    public class Customer
    {
        private int customerId;
        private string name;
        private int age;
        private string phone;
        private string city;

        public Customer()
        {
            customerId = 0;
            name = "Unknown";
            age = 0;
            phone = "Unknown";
            city = "Unknown";
        }

        public Customer(int customerId, string name, int age, string phone, string city)
        {
            this.customerId = customerId;
            this.name = name;
            this.age = age;
            this.phone = phone;
            this.city = city;
        }

        public void DisplayCustomer()
        {
            Console.WriteLine($"Customer ID: {customerId}");
            Console.WriteLine($"Name: {name}");
            Console.WriteLine($"Age: {age}");
            Console.WriteLine($"Phone: {phone}");
            Console.WriteLine($"City: {city}");
        }
        public static void DisplayCustomer(Customer customer)
        {
            customer.DisplayCustomer();
        }

        ~Customer()
        {
            Console.WriteLine($"Customer object with ID {customerId} is destroyed.");
        }

        public static void Main(string[] args)
        {
           
            Customer customer1 = new Customer();
            Customer customer2 = new Customer(1, "Samyuktha", 48, "7654987602", "India");

            customer1.DisplayCustomer();
            Console.WriteLine();

            customer2.DisplayCustomer();
            Console.WriteLine();

            Console.ReadLine();
        }
    }
}

