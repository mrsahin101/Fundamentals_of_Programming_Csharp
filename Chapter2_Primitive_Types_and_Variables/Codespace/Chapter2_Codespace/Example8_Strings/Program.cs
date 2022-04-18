using System;

namespace Example8_Strings
{
    internal class Program
    {
        static void Main(string[] args)
        {
            /* Declare some variables */
            string firstName = "John";
            string lastName = "Smith";

            /* Concatenation of 2 string */
            string fullName = firstName + " " + lastName;

            /* Printing strings out on the console*/
            Console.WriteLine("Hello " + firstName + "!");
            Console.WriteLine("Your full name is " + fullName + ".");
            /* Console output
             * Hello John!
             * Your full name is John Smith.
             */

        }
    }
}
