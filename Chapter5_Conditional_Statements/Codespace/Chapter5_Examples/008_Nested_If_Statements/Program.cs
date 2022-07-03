using System;

namespace _008_Nested_If_Statements
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int first = 5;
            int second = 3;

            if(first == second)
            {
                Console.WriteLine("These two numbers are eqaul!");
            }
            else
            {
                if(first > second)
                {
                    Console.WriteLine("The first number is greater!");
                }
                else
                {
                    Console.WriteLine("The second number is greater!");
                }
            }
            /* Console Output : The first number is greater!
             */
        }
    }
}
