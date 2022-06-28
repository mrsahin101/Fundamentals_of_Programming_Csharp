using System;
/* Question : Write a program that reads five integer numbers and prints their sum.
 * If an invalid number is entered the program should prompt the user to enter another number.
 */

namespace Exercise7_SumCalculation
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string input;

            int[] number = new int[5];
            for (int i = 0; i < 5; i++)
            {
                bas:
                Console.Write((i + 1) + ".Number :");
                input = Console.ReadLine();
                if (int.TryParse(input, out number[i]))
                {

                }
                else
                {
                    Console.WriteLine("Please try again!");
                    goto bas;
                }
                    
            }
            int sum = 0;
            for(int i = 0; i < 5; i++)
            {
                sum += number[i];
            }
            Console.WriteLine("Sum of numbers : " +  sum);
        }
    }
}
