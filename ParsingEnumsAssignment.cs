using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ParsingEnumsAssignment
{
    // Define an enum to represent the days of the week
    public enum DaysOfWeek
    {
        Sunday,
        Monday,
        Tuesday,
        Wednesday,
        Thursday,
        Friday,
        Saturday
    }

    // Main program class
    class Program
    {
        // Entry point of the console application
        static void Main(string[] args)
        {
            // Prompt the user to enter the current day of the week
            Console.WriteLine("Please enter the current day of the week:");

            // Read the user's input from the console
            string userInput = Console.ReadLine();

            try
            {
                // Try to parse the user's input into the DaysOfWeek enum
                // The 'true' argument makes the parsing case-insensitive
                DaysOfWeek currentDay = (DaysOfWeek)Enum.Parse(typeof(DaysOfWeek), userInput, true);

                // If parsing succeeds, print the parsed enum value
                Console.WriteLine($"You entered: {currentDay}");
            }
            catch (Exception)
            {
                // If parsing fails, print an error message
                Console.WriteLine("Please enter an actual day of the week.");
            }

            // Keep the console window open until a key is pressed
            Console.WriteLine("Press any key to exit...");
            Console.ReadKey();
        }
    }
}
