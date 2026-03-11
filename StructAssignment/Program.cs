using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StructAssignment
{
    // Define a struct called Number
    public struct Number
    {
        // Declare a property called Amount of type decimal
        public decimal Amount { get; set; }
    }

    class Program
    {
        static void Main(string[] args)
        {
            // Create an instance of the Number struct
            Number myNumber = new Number();

            // Assign a decimal value to the Amount property
            myNumber.Amount = 250.75m;

            // Print the value of Amount to the console
            Console.WriteLine("The amount is: " + myNumber.Amount);

            // Keep the console window open until a key is pressed
            Console.WriteLine("\nPress any key to exit...");
            Console.ReadKey();
        }
    }
}

