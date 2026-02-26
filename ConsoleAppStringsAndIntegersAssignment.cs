using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleAppStringsAndIntegersAssignment
{
    class Program
    {
        static void Main(string[] args)

        {
            // Create a list of integers to work with
            List<int> numbers = new List<int>() { 10, 25, 77, 43, 5001, 99661, 69 };

            // Ask the user for a number to divide each list item by
            Console.WriteLine("Enter a number to divide each integer in the list by:");

            // Read the user input as a string
            string userInput = Console.ReadLine();

            try
            {
                // Convert the user input to an integer
                // This may throw a FormatException if the user enters a string
                int divisor = Convert.ToInt32(userInput);

                // Loop through each number in the list
                foreach (int number in numbers)
                {
                    // Divide the number by the user-entered divisor
                    // This may throw a DivideByZeroException if divisor is zero
                    int result = number / divisor;

                    // Display the result to the screen
                    Console.WriteLine($"{number} divided by {divisor} = {result}");
                }
            }
            catch (FormatException ex)
            {
                // This block runs if the user enters something that is not a number
                Console.WriteLine("ERROR: You must enter a valid whole number.");
                Console.WriteLine($"System message: {ex.Message}");
            }
            catch (DivideByZeroException ex)
            {
                // This block runs if the user enters zero
                Console.WriteLine("ERROR: You cannot divide by zero.");
                Console.WriteLine($"System message: {ex.Message}");
            }
            catch (Exception ex)
            {
                // This block catches any other unexpected errors
                Console.WriteLine("An unexpected error occurred.");
                Console.WriteLine($"System message: {ex.Message}");
            }

            // This line runs whether an exception happened or not
            Console.WriteLine("\nProgram has exited the try/catch block and continued execution.");

            // Keep the console window open
            Console.WriteLine("Press Enter to close the program.");
            Console.ReadLine();
        }
    }
}
