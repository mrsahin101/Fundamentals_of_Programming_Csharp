using System;
/* Question:
 * Write a Boolean expression that checks whether a given integer is divisible by both 5 and 7, without a remainder.
 */
namespace Exercise2_Divisible
{
    internal class Program
    {
        static void Main(string[] args)
        {
            for(; ; )
            {
                string input = Console.ReadLine();
                if (int.TryParse(input, out int result))
                {
                    if (result % 5 == 0 && result % 7 == 0)
                        Console.WriteLine("Divisible");
                    else
                        Console.WriteLine("Not Divisible");
                }
                else
                    Console.WriteLine("Invalid Input");
            }
        }
    }
}
