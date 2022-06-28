using System;
/* Question : Write a program that reads an integer number n from the console and prints all numbers in the range [1…n],
 * each on a separate line.
 *
 */
namespace Exercise10_RangePrinter
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Please enter (n) :");
            int n = int.Parse(Console.ReadLine());

            for(int i = 1; i <= n; i++)
            {
                Console.WriteLine(i);
            }
        }
    }
}
