using System;
/* Question :Write a program that finds the biggest of three integers, using nested if statements.
 */
namespace _003_Find_The_Biggest
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int firstNumber = 10;
            int secondNumber = 20;
            int thirdNumber = 30;

            if(firstNumber > secondNumber)
            {
                if (firstNumber > thirdNumber)
                    Console.WriteLine("Biggest number is first number");
                else if (firstNumber == thirdNumber)
                    Console.WriteLine("Biggest number is first number and third number");
                else
                    Console.WriteLine("Biggest number is third number");
            }
            else if (firstNumber == secondNumber)
            {
                if (firstNumber > thirdNumber)
                    Console.WriteLine("Biggest number is first number and second number");
                else if (firstNumber == thirdNumber)
                    Console.WriteLine("They are all equal");
                else
                    Console.WriteLine("Biggest number is third number");
            }
            else
            {
                if (secondNumber > thirdNumber)
                    Console.WriteLine("Biggest number is first number and second number");
                else if (secondNumber == thirdNumber)
                    Console.WriteLine("Biggest number is second and third numbers.");
                else
                    Console.WriteLine("Biggest number is third number");
            }
        }
    }
}
