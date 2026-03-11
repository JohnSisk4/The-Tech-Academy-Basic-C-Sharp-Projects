using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DateTimeAssignment
{
    class Program
    {
        static void Main(string[] args)
        
            {
                // Print the current date and time to the console
                // DateTime.Now retrieves the system's current local date and time
                Console.WriteLine("Current date and time: " + DateTime.Now);

                // Ask the user for a number
                // This number will represent how many hours to add to the current time
                Console.Write("\nEnter a number of hours to add: ");
                string userInput = Console.ReadLine(); // Read the user's input as a string

                // Convert the user's input into an integer
                // int.Parse will throw an error if the input is not a valid number
                int hoursToAdd = int.Parse(userInput);

                // Calculate the future time by adding X hours to the current time
                // DateTime.AddHours returns a new DateTime object with the added hours
                DateTime futureTime = DateTime.Now.AddHours(hoursToAdd);

                // Print the result to the console
                Console.WriteLine("\nIn " + hoursToAdd + " hours, the time will be: " + futureTime);

                // Pause the console so the user can read the output before the window closes
                Console.WriteLine("\nPress any key to exit...");
                Console.ReadKey();
            }
        }
    }
