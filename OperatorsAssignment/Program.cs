using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OperatorsAssignment
{
    class Program
    {
        static void Main(string[] args)
        {
            // Create the first Employee object and assign values.
            Employee emp1 = new Employee()
            {
                Id = 1,
                FirstName = "John",
                LastName = "Smith"
            };

            // Create the second Employee object and assign values.
            Employee emp2 = new Employee()
            {
                Id = 1,
                FirstName = "Sarah",
                LastName = "Jones"
            };

            // Compare the two Employee objects using the overloaded == operator.
            // This will compare their Id values.
            if (emp1 == emp2)
            {
                Console.WriteLine("The two employees are equal (same Id).");
            }
            else
            {
                Console.WriteLine("The two employees are NOT equal (different Ids).");
            }

            // Pause the console so the user can read the output.
            Console.ReadLine();
        }
    }
}

