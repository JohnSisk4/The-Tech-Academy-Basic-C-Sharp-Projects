using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;



namespace OperatorsAssignment
    {
        // The Employee class represents a worker with an Id, FirstName, and LastName.
        public class Employee
        {
            // Property to store the employee's unique identifier.
            public int Id { get; set; }

            // Property to store the employee's first name.
            public string FirstName { get; set; }

            // Property to store the employee's last name.
            public string LastName { get; set; }

            // Overloading the == operator to compare two Employee objects by their Id.
            public static bool operator ==(Employee emp1, Employee emp2)
            {
                // If both objects are null, they are considered equal.
                if (ReferenceEquals(emp1, null) && ReferenceEquals(emp2, null))
                    return true;

                // If one is null and the other is not, they are not equal.
                if (ReferenceEquals(emp1, null) || ReferenceEquals(emp2, null))
                    return false;

                // Compare the Id properties of both Employee objects.
                return emp1.Id == emp2.Id;
            }

            // Overloading the != operator because comparison operators must be overloaded in pairs.
            public static bool operator !=(Employee emp1, Employee emp2)
            {
                // Return the opposite of the == operator.
                return !(emp1 == emp2);
            }

            // Overriding Equals to match the behavior of the == operator.
            public override bool Equals(object obj)
            {
                // Attempt to cast the object to an Employee.
                Employee other = obj as Employee;

                // If the cast fails, return false.
                if (other == null)
                    return false;

                // Compare Id values.
                return this.Id == other.Id;
            }

            // Overriding GetHashCode to ensure consistency with Equals.
            public override int GetHashCode()
            {
                // Use Id as the hash code since equality is based on Id.
                return Id.GetHashCode();
            }
        }
    }


