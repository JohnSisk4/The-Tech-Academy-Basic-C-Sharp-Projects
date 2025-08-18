using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MethodClassAssignment
{
    // This class contains a method that performs a math operation
    public class MathOperations
    {
        // This method takes two integers as parameters
        // It multiplies the first integer by 2 and displays the second integer
        public void PerformOperation(int number1, int number2)
        {
            int result = number1 * 2; // Multiply the first number by 2
            Console.WriteLine("Result of math operation on first number: " + result); // Display result
            Console.WriteLine("Second number: " + number2); // Display the second number
        }
    }

    class Program
    {
        static void Main(string[] args)
        {
            // Instantiate the MathOperations class
            MathOperations mathOps = new MathOperations();

            // Call the method using positional arguments
            mathOps.PerformOperation(5, 10); // Pass 5 and 10 as arguments

            // Call the method using named arguments
            mathOps.PerformOperation(number1: 7, number2: 20); // Specify parameter names

            // Keep the console window open until a key is pressed
            Console.WriteLine("Press any key to exit...");
            Console.ReadKey();
        }
    }
}

