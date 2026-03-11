using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ParametersAssignment
{
    // Define a generic Employee class that accepts a type parameter T
    public class Employee<T>
    {
        // Declare a property called "Things" which is a list of type T
        public List<T> Things { get; set; }
    }

    class Program
    {
        static void Main(string[] args)
        {
            // Instantiate an Employee object with type string
            Employee<string> stringEmployee = new Employee<string>();
            // Assign a list of strings to the Things property
            stringEmployee.Things = new List<string> { "Report", "Laptop", "Notebook" };

            // Instantiate an Employee object with type int
            Employee<int> intEmployee = new Employee<int>();
            // Assign a list of integers to the Things property
            intEmployee.Things = new List<int> { 101, 202, 303 };

            // Print all string items from stringEmployee.Things
            Console.WriteLine("String Employee Things:");
            foreach (string item in stringEmployee.Things)
            {
                // Output each string item to the console
                Console.WriteLine(item);
            }

            // Print all integer items from intEmployee.Things
            Console.WriteLine("\nInt Employee Things:");
            foreach (int item in intEmployee.Things)
            {
                // Output each integer item to the console
                Console.WriteLine(item);
            }

            // Keep the console window open until a key is pressed
            Console.WriteLine("\nPress any key to exit...");
            Console.ReadKey();
        }
    }
}
