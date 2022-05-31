using System;
/* We are given a number n and a position p.
 * Write a sequence of operations that prints the value of the bit on the position p in the number (0 or 1).
 * Example: n=35, p=5 -> 1. Another example: n=35, p=6 -> 0.
 */
namespace Exercise11_Find_the_Bit
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int n;
            int p;
            int indexer = 0;
            for(; ; )
            {
                Console.Write("Please enter value of n : ");
                string inputN = Console.ReadLine();
                if (int.TryParse(inputN, out n))
                {
                    Console.Write("Please enter value of p :");
                    string bitP = Console.ReadLine();
                    if (int.TryParse(bitP, out p))
                    {
                        indexer = 1 << p;
                        if ((n & indexer) != 0)
                            Console.WriteLine("1");
                        else
                            Console.WriteLine("0");
                    }
                    else
                        Console.WriteLine("p has to be Integer and greater than 0");

                }
                else
                    Console.WriteLine("Please enter Integer value for n\n");

            }
        }

    }
}
