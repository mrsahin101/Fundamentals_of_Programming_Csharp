using System;
/* Question
 * Write an expression that checks whether an integer is odd or even.
 */
namespace Exercise1_Odd_Even
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string input = Console.ReadLine();
            if (int.TryParse(input, out int result))
            {
                if (result % 2 == 0)
                    Console.WriteLine("Even");
                else
                    Console.WriteLine("Odd");
            }
            else
                Console.WriteLine("Invalid Input");
        }
    }
}
