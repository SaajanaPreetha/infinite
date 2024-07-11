using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace assign6ques3
{
    class Employee
    {
        public int EmpId { get; set; }
        public string EmpName { get; set; }
        public string EmpCity { get; set; }
        public decimal EmpSalary { get; set; }
    }

    class Program
    {
        static void Main()
        {
            List<Employee> employees = new List<Employee>();

            PopulateEmployees(employees);
            Console.ReadLine();

            Console.WriteLine("All Employees:");
            DisplayEmployees(employees);
            Console.ReadLine();

            Console.WriteLine("\nEmployees with Salary > 45000:");
            DisplayEmployees(FilterBySalary(employees, 45000));
            Console.ReadLine();

            Console.WriteLine("\nEmployees in Bangalore:");
            DisplayEmployees(FilterByCity(employees, "Bangalore"));
            Console.ReadLine();

            Console.WriteLine("\nEmployees by Name (Ascending Order):");
            DisplayEmployees(SortByNameAscending(employees));
            Console.ReadLine();
        }
        
        static void PopulateEmployees(List<Employee> employees)
        {

            Console.Write("Enter number of employees: ");
            if (int.TryParse(Console.ReadLine(), out int numberOfEmployees))
            {
                for (int i = 1; i <= numberOfEmployees; i++)
                {
                    Console.WriteLine($"Enter details for Employee {i}:");
                    employees.Add(new Employee
                    {
                        EmpId = i,
                        EmpName = ReadInput("Name"),
                        EmpCity = ReadInput("City"),
                        EmpSalary = ReadSalary()
                    });
                }
            }
            else
            {
                Console.WriteLine("Invalid input. Exiting.");
            }
        }

        static string ReadInput(string prompt)
        {
            Console.Write($"{prompt}: ");
            return Console.ReadLine();
        }

        static decimal ReadSalary()
        {
            Console.Write("Salary: ");
            if (decimal.TryParse(Console.ReadLine(), out decimal salary))
            {
                return salary;
            }
            else
            {
                Console.WriteLine("Invalid salary. Setting to 0.");
                return 0;
            }
        }

        static void DisplayEmployees(List<Employee> employees)
        {
            foreach (var emp in employees)
            {
                Console.WriteLine($"EmpId: {emp.EmpId}, EmpName: {emp.EmpName}, EmpCity: {emp.EmpCity}, EmpSalary: {emp.EmpSalary}");
            }
        }

        static List<Employee> FilterBySalary(List<Employee> employees, decimal minSalary)
        {
            List<Employee> filteredEmployees = new List<Employee>();
            foreach (var emp in employees)
            {
                if (emp.EmpSalary > minSalary)
                {
                    filteredEmployees.Add(emp);
                }
            }
            return filteredEmployees;
        }

        static List<Employee> FilterByCity(List<Employee> employees, string city)
        {
            List<Employee> filteredEmployees = new List<Employee>();
            foreach (var emp in employees)
            {
                if (emp.EmpCity.Equals(city, StringComparison.OrdinalIgnoreCase))
                {
                    filteredEmployees.Add(emp);
                }
            }
            return filteredEmployees;
        }

        static List<Employee> SortByNameAscending(List<Employee> employees)
        {
            // Bubble sort implementation for simplicity
            for (int i = 0; i < employees.Count - 1; i++)
            {
                for (int j = 0; j < employees.Count - 1 - i; j++)
                {
                    if (string.Compare(employees[j].EmpName, employees[j + 1].EmpName) > 0)
                    {
                        // Swap employees
                        Employee temp = employees[j];
                        employees[j] = employees[j + 1];
                        employees[j + 1] = temp;
                    }
                }
            }
            return employees;
        }
    }
}

