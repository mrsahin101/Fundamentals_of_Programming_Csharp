﻿using System;
/* Question :Write a program that asks for a digit (0-9),
 * and depending on the input, shows the digit as a word (in English). 
 * Use a switch statement.
 */
namespace _005_Digit_Pronunciation
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter a digit (0-9)");
            int digit = int.Parse( Console.ReadLine());

            switch(digit)
            {
                case 0:
                    Console.WriteLine("Zero");
                    break;
                case 1:
                    Console.WriteLine("One");
                    break;
                case 2:
                    Console.WriteLine("Two");
                    break;
                case 3:
                    Console.WriteLine("Three");
                    break;
                case 4:
                    Console.WriteLine("Four");
                    break;
                case 5:
                    Console.WriteLine("Five");
                    break;
                case 6:
                    Console.WriteLine("Six");
                    break;
                case 7:
                    Console.WriteLine("Seven");
                    break;
                case 8:
                    Console.WriteLine("Eight");
                    break;
                case 9:
                    Console.WriteLine("Nine");
                    break;
                default:
                    Console.WriteLine("Invalid Input");
                    break;
            }

        }
    }
}
