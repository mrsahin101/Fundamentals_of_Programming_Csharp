using System;
/* Question:
 * Write an expression that looks for a given integer if its third digit (right to left) is 7.
 */
namespace Exercise3_DigitCheck
{
    internal class Program
    {
        static void Main(string[] args)
        {
            /* Lets say our number is 753.
             * so if we divide it by 100 we get 7 ( unles its smaller than 100 we always get bigger than 0. gotta check for that 
             * aswell)
             * if we add 3 to it and its divisible to 10 without remainder than its 7
             */
            for(; ; )
            {
                string input = Console.ReadLine();
                if (int.TryParse(input, out int result))
                {
                    if (((result / 100) != 0) && (((result / 100) + 3)  % 10 == 0))
                        Console.WriteLine("Yes 3rd digit is 7!");
                    else
                        Console.WriteLine("I am sorry! 3rd digit either doesn't exist or different from 7");
                }
                else
                    Console.WriteLine("Invalid Input");
            }
        }
    }
}
