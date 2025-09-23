using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PolymorphismAssignment
{
    // Define an interface called IQuittable
    public interface IQuittable
    {
        // Declare a method signature for Quit with no return type
        void Quit();
    }

    // Define an Employee class that implements the IQuittable interface
    public class Employee : IQuittable
    {
        // Properties to hold employee details
        public string FirstName { get; set; }
        public string LastName { get; set; }

        // Constructor to initialize employee details
        public Employee(string firstName, string lastName)
        {
            FirstName = firstName;
            LastName = lastName;
        }

        // Implement the Quit method from the IQuittable interface
        public void Quit()
        {
            // Display a message when the employee quits
            Console.WriteLine($"{FirstName} {LastName} has quit the job.");
        }
    }

    // Main program class
    class Program
    {
        static void Main(string[] args)
        {
            // Create an Employee object
            Employee emp = new Employee("John", "Sisk");

            // Use polymorphism to assign the Employee object to an IQuittable interface reference
            IQuittable quitter = emp;

            // Call the Quit method using the interface reference
            quitter.Quit();

            // Keep the console window open until a key is pressed
            Console.WriteLine("Press any key to exit...");
            Console.ReadKey();
        }
    }
}


