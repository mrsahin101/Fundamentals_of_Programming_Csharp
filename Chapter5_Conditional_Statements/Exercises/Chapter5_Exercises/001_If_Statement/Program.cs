using System;
/* Question :Write an if-statement that takes two integer variables
 * and exchanges their values if the first one is greater than the second one.
 */
namespace _001_If_Statement
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
            if(firstNumber > secondNumber)
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
