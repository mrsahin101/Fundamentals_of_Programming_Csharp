using System;
/* Question:
 * Write a program that takes as input a four-digit number in format abcd (e.g. 2011) and performs the following actions:
 - Calculates the sum of the digits (in our example 2+0+1+1 = 4).
 - Prints on the console the number in reversed order: dcba (in our example 1102).
 - Puts the last digit in the first position: dabc (in our example 1201).
 - Exchanges the second and the third digits: acbd (in our example 2101).
 */
namespace Exercise10_Calculator
{
    internal class Program
    {
        static void Main(string[] args)
        {
            byte firstDigit = 0;
            byte secondDigit = 0;
            byte thirdDigit = 0;
            byte fourthDigit = 0;
            string temporary;
            for(; ; )
            {
                Console.Write("Enter 4-digit Number : ");
                string inputValue = Console.ReadLine();
                
                if(inputValue.Length != 4)
                    Console.WriteLine("Error! Please Enter 4 digit number!");
                else
                {
                    if (int.TryParse(inputValue, out int value))
                    {
                        firstDigit = byte.Parse(inputValue[0].ToString());
                        secondDigit = byte.Parse(inputValue[1].ToString());
                        thirdDigit = byte.Parse(inputValue[2].ToString());
                        fourthDigit = byte.Parse(inputValue[3].ToString());
                        Console.WriteLine("Sum  of Digits : " + (firstDigit + secondDigit + thirdDigit + fourthDigit));
                        temporary = fourthDigit.ToString() + thirdDigit.ToString() + secondDigit.ToString() + firstDigit.ToString();
                        Console.WriteLine("Reversed order : " + temporary);
                        temporary = fourthDigit.ToString() + firstDigit.ToString() + secondDigit.ToString() + thirdDigit.ToString();
                        Console.WriteLine("Last Digit to first Digit : " + temporary);
                        temporary = firstDigit.ToString() + thirdDigit.ToString() + secondDigit.ToString() + fourthDigit.ToString();
                        Console.WriteLine("Swapped second and third digits : " + temporary);
                    }
                    else
                        Console.WriteLine("Please enter integer value!");
                }
                Console.WriteLine();
                Console.WriteLine();
            }
        }
    }
}
