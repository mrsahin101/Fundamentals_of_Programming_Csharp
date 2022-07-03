using System;
/* Question :Write a program that shows the sign (+ or -) of the product of three real numbers,
 * without calculating it. Use a sequence of if operators. 
 */
namespace _002_Sign_of_Calculation
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter Two number");
            Console.Write("First number :");
            int firstNumber = int.Parse(Console.ReadLine());

            Console.Write("Second number :");
            int secondNumber = int.Parse(Console.ReadLine());
            Console.WriteLine();

            int temporaryNumber;
            if (firstNumber > secondNumber)
            {
                temporaryNumber = firstNumber;
                firstNumber = secondNumber;
                secondNumber = temporaryNumber;
                Console.WriteLine("Exchanged!");
            }
            Console.WriteLine("First number : {0}", firstNumber);
            Console.WriteLine("Second number : {0}", secondNumber);
        }
    }
}
