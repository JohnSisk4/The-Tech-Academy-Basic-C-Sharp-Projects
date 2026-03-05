using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;

namespace InputAssignment
{
    class Program
    {
         static void Main(string[] args)
            {
                // Ask the user for a number
                Console.Write("Please enter a number: ");

                // Read the user's input as a string
                string userInput = Console.ReadLine();

                // Define the file path where the number will be stored
                // This creates a file named "numberLog.txt" in the same folder as the program
                string filePath = "numberLog.txt";

                // Write the user's input to the text file
                // File.WriteAllText creates the file if it doesn't exist, or overwrites it if it does
                File.WriteAllText(filePath, userInput);

                // Read the contents of the text file back into a string
                string fileContents = File.ReadAllText(filePath);

                // Print the contents of the file back to the user
                Console.WriteLine("\nThe number you entered was saved and read back from the file:");
                Console.WriteLine(fileContents);

                // Pause the console so the user can see the output before the window closes
                Console.WriteLine("\nPress any key to exit...");
                Console.ReadKey();
            }
        }
    }
