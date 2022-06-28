using System;
/* Question :Write a program that prints three numbers in three virtual columns on the console.
 * Each column should have a width of 10 characters and the numbers should be left aligned.
 * The first number should be an integer in hexadecimal; 
 * the second should be fractional positive;
 * and the third – a negative fraction. 
 * The last two numbers have to be rounded to the second decimal place.
 *
 */
namespace Exercise4_Number_Printing
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int firstNumber = 0x20;
            float secondNumber = 3.14f;
            float thirdNumber = -1.001f;

            Console.WriteLine("{0:0000000000 }---{1:0000000000.####}---{2:0000000000.####}", firstNumber,secondNumber,thirdNumber);
        }
    }
}
