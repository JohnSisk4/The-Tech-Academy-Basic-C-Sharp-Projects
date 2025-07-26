using System;
using System.Collections.Generic;
using System.Linq;
using System.Text; // Required for using stringBuilder
using System.Threading.Tasks;

namespace StringAssignment
{
    class Program
    {
        static void Main(string[] args)
        {

            // PART 1: Concatenate three strings
             string firstName = "John";
             string middleName = "J.";
             string lastName = "Sisk";

            // Combine all three strings into a full name
            string fullName = firstName + " " + middleName + " " + lastName;
            Console.WriteLine("Full Name: " + fullName);

            // PART 2: Convert a string to uppercase
            string welcomeMessage = "Welcome to your C# console app!";
            string uppercaseMessage = welcomeMessage.ToUpper(); // Convert message to uppercase
            Console.WriteLine("Uppercase Message: " + uppercaseMessage);

            // PART 3: Use StringBuilder to create a paragraph
            StringBuilder paragraph = new StringBuilder(); // Initialize StringBuilder object

            paragraph.Append("This is the first sentence in the paragraph. "); // Add first sentence
            paragraph.Append("Now we add a second sentence to give it more body. "); // Second sentence
            paragraph.Append("Finally, we wrap it up with a closing thought."); // Third sentence

            Console.WriteLine("Paragraph using StringBuilder:");
            Console.WriteLine(paragraph.ToString()); // Output the final paragraph
        }
    }

}
