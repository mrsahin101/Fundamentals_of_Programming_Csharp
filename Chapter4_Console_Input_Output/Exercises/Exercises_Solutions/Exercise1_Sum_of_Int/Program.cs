using System;
/* Question : Write a program that reads from the console three numbers of type int and prints their sum. 
 */
namespace Exercise1_Sum_of_Int
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.Write("First Number :");
            int numberOne = int.Parse(Console.ReadLine());

            Console.Write("Second Number :");
            int numberTwo = int.Parse(Console.ReadLine());

            Console.Write("Third Number :");
            int numberThree = int.Parse(Console.ReadLine());

            Console.WriteLine("Sum of this numbers is : " + (numberOne + numberTwo + numberThree));
        }
    }
}
