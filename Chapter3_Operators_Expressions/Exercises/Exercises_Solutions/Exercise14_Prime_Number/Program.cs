using System;
/* Question : Write a program that checks if a given number n (1 < n < 100) is a prime number 
 * (i.e. it is divisible without remainder only to itself and 1).
 */
namespace Exercise14_Prime_Number
{
    internal class Program
    {
        static void Main(string[] args)
        {
            bool status = true;
            for(; ; )
            {
                Console.Write("Please enter value of n :");
                string input = Console.ReadLine();

                if (int.TryParse(input, out int result) && (result > 1 && result < 100))
                {
                    for(int i = 2; i < ((result / 2) +1); i++)
                    {
                        if (result % i == 0)
                        {
                            Console.WriteLine("This is not Prime Number");
                            status = false;
                            break;
                        }
                    }
                    if (status)
                        Console.WriteLine("This is Prime Number");
                }
                else
                    Console.WriteLine("Please enter parsable number");
                status = true;
            }
        }
    }
}
