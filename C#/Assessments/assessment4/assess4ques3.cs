using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace assess4ques3
{
    class Employee
    {
        public int EmployeeID { get; set; }
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public string Title { get; set; }
        public string DOB { get; set; }
        public string DOJ { get; set; }
        public string City { get; set; }

        public Employee(int id, string firstName, string lastName, string title, string dob, string doj, string city)
        {
            EmployeeID = id;
            FirstName = firstName;
            LastName = lastName;
            Title = title;
            DOB = dob;
            DOJ = doj;
            City = city;
        }
    }
    class Program
    {
        static void Main()
        {
            List<Employee> empList = new List<Employee>();

      
            empList.Add(new Employee(1001, "Malcolm", "Daruwalla", "Manager", "16/11/1984", "8/6/2011", "Mumbai"));
            empList.Add(new Employee(1002, "Asdin", "Dhalla", "AsstManager", "20/08/1984", "7/7/2012", "Mumbai"));
            empList.Add(new Employee(1003, "Madhavi", "Oza", "Consultant", "14/11/1987", "12/4/2015", "Pune"));
            empList.Add(new Employee(1004, "Saba", "Shaikh", "SE", "3/6/1990", "2/2/2016", "Pune"));
            empList.Add(new Employee(1005, "Nazia", "Shaikh", "SE", "8/3/1991", "2/2/2016", "Mumbai"));
            empList.Add(new Employee(1006, "Amit", "Pathak", "Consultant", "7/11/1989", "8/8/2014", "Chennai"));
            empList.Add(new Employee(1007, "Vijay", "Natrajan", "Consultant", "2/12/1989", "1/6/2015", "Mumbai"));
            empList.Add(new Employee(1008, "Rahul", "Dubey", "Associate", "11/11/1993", "6/11/2014", "Chennai"));
            empList.Add(new Employee(1009, "Suresh", "Mistry", "Associate", "12/8/1992", "3/12/2014", "Chennai"));
            empList.Add(new Employee(1010, "Sumit", "Shah", "Manager", "12/4/1991", "2/1/2016", "Pune"));

            Console.WriteLine("\n Display details of all employees: ");
            DisplayEmployees(empList);

            Console.WriteLine("\n Display details of employees whose location is not Mumbai: ");
            var employeesNotInMumbai = empList.Where(emp => emp.City != "Mumbai");
            DisplayEmployees(employeesNotInMumbai.ToList());

            Console.WriteLine("\n Display details of employees whose title is AsstManager: ");
            var asstManagers = empList.Where(emp => emp.Title == "AsstManager");
            DisplayEmployees(asstManagers.ToList());

            Console.WriteLine("\n Display details of employees whose last name starts with 'S': ");
            var employeesWithLastNameS = empList.Where(emp => emp.LastName.StartsWith("S"));
            DisplayEmployees(employeesWithLastNameS.ToList());

            Console.ReadLine();
        }


        static void DisplayEmployees(List<Employee> employees)
        {
            foreach (var emp in employees)
            {
                Console.WriteLine($"EmployeeID: {emp.EmployeeID}, FirstName: {emp.FirstName}, LastName: {emp.LastName}, Title: {emp.Title}, DOB: {emp.DOB}, DOJ: {emp.DOJ}, City: {emp.City}");
            }
        }
    }
}
