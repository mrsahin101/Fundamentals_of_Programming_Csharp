using System;

namespace _011_ReadLine
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Please enter your first name :");
            string firstName = Console.ReadLine();

            Console.Write("Please enter your last name : ");
            string lastName = Console.ReadLine();

            Console.WriteLine("Hello, {0} {1}!",firstName,lastName);
            /* Output :
             * Please enter your first name : John
             * Please enter your last name  : Doe
             * Hello, John Doe!
             */
        }
    }
}
