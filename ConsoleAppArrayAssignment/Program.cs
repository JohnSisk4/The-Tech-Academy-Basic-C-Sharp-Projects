using System;
using System.Collections.Generic;


namespace ConsoleAppArrayAssignment
{
 
class Program
        {
            static void Main()
            {
                // Create a one-dimensional array of strings
                string[] stringArray = { "Apple", "Banana", "Cherry", "Date", "Elderberry", "Strawberry", "Blueberry", "Pear", "Orange" };

                Console.WriteLine("Select an index (0 to 9) to view a fruit from the array:");
                string input = Console.ReadLine(); // Get user input
                int index;

                // Try to parse user input and check if index is valid
                if (int.TryParse(input, out index) && index >= 0 && index < stringArray.Length)
                {
                    Console.WriteLine($"Fruit at index {index}: {stringArray[index]}");
                }
                else
                {
                    Console.WriteLine("Invalid index. Please select an index between 0 and 9.");
                }

                // Create a one-dimensional array of integers
                int[] intArray = { 10, 20, 30, 40, 50, 60, 70, 80, 90, 100};

                Console.WriteLine("\nSelect an index (0 to 4) to view a number from the integer array:");
                input = Console.ReadLine(); // Get new input

                // Validate index again
                if (int.TryParse(input, out index) && index >= 0 && index < intArray.Length)
                {
                    Console.WriteLine($"Integer at index {index}: {intArray[index]}");
                }
                else
                {
                    Console.WriteLine("Invalid index. Please select an index between 0 and 4.");
                }

                // Create a list of strings
                List<string> stringList = new List<string> { "Lion", "Tiger", "Elephant", "Giraffe", "Zebra" };

                Console.WriteLine("\nSelect an index (0 to 4) to view an animal from the list:");
                input = Console.ReadLine(); // Get new input

                // Validate index for the list
                if (int.TryParse(input, out index) && index >= 0 && index < stringList.Count)
                {
                    Console.WriteLine($"Animal at index {index}: {stringList[index]}");
                }
                else
                {
                    Console.WriteLine("Invalid index. Please select an index between 0 and 4.");
                }

                Console.WriteLine("\nPress any key to exit.");
                Console.ReadKey(); // Keep the console window open
            }
        }
}

