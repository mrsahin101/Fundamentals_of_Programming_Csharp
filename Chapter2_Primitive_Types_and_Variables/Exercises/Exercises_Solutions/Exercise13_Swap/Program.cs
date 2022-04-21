using System;
/* Question:
 * Declare two variables of type int. Assign to them values 5 and 10 respectively.
 * Exchange (swap) their values and print them
 */
namespace Exercise13_Swap
{
    internal class Program
    {
        static void Main(string[] args)
        {
            byte firstNumber = 5;
            byte secondNumber = 10;
            byte temporaryContainer = 0;
            Console.WriteLine("Before swapping; firstNumber -> " + firstNumber + " secondNumber -> " + secondNumber);
            temporaryContainer = firstNumber;
            firstNumber = secondNumber;
            secondNumber = temporaryContainer;
            Console.WriteLine("After swapping; firstNumber -> " + firstNumber + " secondNumber -> " + secondNumber);
            /* Console Output : 
             * Before swapping; firstNumber -> 5 secondNumber -> 10
             * After swapping; firstNumber -> 10 secondNumber -> 5
             */


            /* There is another cool way to implement this swap with simple multiplication and divison trick
             * firstNumber = firstNumber * Second Number;  // firstnumber = 5*10 = 50;
             * secondNumber = firstNumber / secondNumber;  // secondNumber = 50/10 = 5;
             * firstNumber = firstNumber / secondNumber;   // firstNumber = 50/5 = 10;
             */
        }
    }
}
