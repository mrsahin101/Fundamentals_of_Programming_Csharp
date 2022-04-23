using System;

namespace Example1_Operators
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int number = 7 + 9;
            Console.WriteLine(number);
            /* Console Output:
             * 16
             */

            string firstName = "Elon";
            string lastName = "Musk";
            string fullName = firstName + " " + lastName;
            Console.WriteLine(fullName);
            /* Console Output:
             * Elon Musk
             */
        }
    }
}
