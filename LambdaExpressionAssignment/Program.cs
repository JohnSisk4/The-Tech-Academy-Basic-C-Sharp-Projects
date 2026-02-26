using System;                           
using System.Collections.Generic;       
using System.Linq;                      
using System.Text;                      
using System.Threading.Tasks;          
namespace LambdaExpressionAssignment
{
    // Define the Employee class with three properties
    class Employee
    {
        public int Id { get; set; }          // Unique identifier for each employee
        public string FirstName { get; set; } // Employee's first name
        public string LastName { get; set; }  // Employee's last name
    }

    class Program
    {
        static void Main(string[] args)
        {
            // Create a list of employees with at least 10 entries
            // Note: At least two employees must have the first name "Joe"
            List<Employee> employees = new List<Employee>()
            {
                new Employee(){ Id = 1, FirstName = "Joe", LastName = "Smith" },
                new Employee(){ Id = 2, FirstName = "Jane", LastName = "Doe" },
                new Employee(){ Id = 3, FirstName = "Joe", LastName = "Johnson" },
                new Employee(){ Id = 4, FirstName = "Mary", LastName = "Brown" },
                new Employee(){ Id = 5, FirstName = "Chris", LastName = "Davis" },
                new Employee(){ Id = 6, FirstName = "Anna", LastName = "Wilson" },
                new Employee(){ Id = 7, FirstName = "Mark", LastName = "Taylor" },
                new Employee(){ Id = 8, FirstName = "Lucy", LastName = "Anderson" },
                new Employee(){ Id = 9, FirstName = "Paul", LastName = "Thomas" },
                new Employee(){ Id = 10, FirstName = "Emma", LastName = "White" }
            };

            // -------------------------------
            // 1. Using foreach loop to find all employees named "Joe"
            // -------------------------------
            List<Employee> joesForeach = new List<Employee>(); // Create a new list to store results

            foreach (Employee emp in employees) // Loop through each employee in the list
            {
                if (emp.FirstName == "Joe")     // Check if the employee's first name is "Joe"
                {
                    joesForeach.Add(emp);       // If true, add to the new list
                }
            }

            // Display results from foreach loop
            Console.WriteLine("Employees named Joe (using foreach):");
            foreach (Employee joe in joesForeach)
            {
                Console.WriteLine($"Id: {joe.Id}, Name: {joe.FirstName} {joe.LastName}");
            }

            Console.WriteLine(); // Blank line for readability

            // -------------------------------
            // 2. Using lambda expression to find all employees named "Joe"
            // -------------------------------
            List<Employee> joesLambda = employees.Where(emp => emp.FirstName == "Joe").ToList();

            // Display results from lambda expression
            Console.WriteLine("Employees named Joe (using lambda):");
            foreach (Employee joe in joesLambda)
            {
                Console.WriteLine($"Id: {joe.Id}, Name: {joe.FirstName} {joe.LastName}");
            }

            Console.WriteLine(); // Blank line for readability

            // -------------------------------
            // 3. Using lambda expression to find employees with Id > 5
            // -------------------------------
            List<Employee> idGreaterThanFive = employees.Where(emp => emp.Id > 5).ToList();

            // Display results
            Console.WriteLine("Employees with Id greater than 5:");
            foreach (Employee emp in idGreaterThanFive)
            {
                Console.WriteLine($"Id: {emp.Id}, Name: {emp.FirstName} {emp.LastName}");
            }

            // Keep console window open until user presses a key
            Console.WriteLine("\nPress any key to exit...");
            Console.ReadKey();
        }
    }
}
