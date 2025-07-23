using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ShippingQuoteBranchingAssignment
{
    class Program
    {
        static void Main(string[] args)
        {
            // Greet the user with a welcome message
            Console.WriteLine("Welcome to Package Express. Please follow the instructions below.");

            // Prompt user for package weight
            Console.WriteLine("Please enter the package weight:");
            int weight = Convert.ToInt32(Console.ReadLine());

            // Check if weight exceeds the limit
            if (weight > 50)
            {
                Console.WriteLine("Package too heavy to be shipped via Package Express. Have a good day.");
                return; // End program if too heavy
            }

            // Prompt user for package width
            Console.WriteLine("Please enter the package width:");
            int width = Convert.ToInt32(Console.ReadLine());

            // Prompt user for package height
            Console.WriteLine("Please enter the package height:");
            int height = Convert.ToInt32(Console.ReadLine());

            // Prompt user for package length
            Console.WriteLine("Please enter the package length:");
            int length = Convert.ToInt32(Console.ReadLine());

            // Check if the sum of dimensions exceeds the limit
            int dimensionTotal = width + height + length;
            if (dimensionTotal > 50)
            {
                Console.WriteLine("Package too big to be shipped via Package Express.");
                return; // End program if too large
            }

            // Calculate the shipping quote
            int volume = width * height * length;      // Calculate the volume of the package
            decimal quote = (volume * weight) / 100m;  // Multiply volume by weight and divide by 100 (use decimal for currency)

            // Display the final shipping quote to the user
            Console.WriteLine("Your estimated total for shipping this package is: $" + quote.ToString("F2"));
            Console.WriteLine("Thank you!");
        }
    }
}
