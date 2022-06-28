using System;
/* Question : Write a program that reads two numbers from the console and prints the greater of them.
 * Solve the problem without using conditional statements.
 *
 */

namespace Exercise6_FindGreater
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.Write("First number :");
            int firstNumber = int.Parse(Console.ReadLine());

            Console.Write("Second number :");
            int secondNumber = int.Parse(Console.ReadLine());

            Console.WriteLine(Math.Max(firstNumber, secondNumber));
        }
    }
}
