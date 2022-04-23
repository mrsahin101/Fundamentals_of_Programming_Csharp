using System;

namespace Example2_Arithmetical_Operators
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int squarePerimeter = 17;
            double squareSide = squarePerimeter / 4.0;
            double squareArea = squareSide * squareSide;
            
            Console.WriteLine(squareSide);
            /* Console Output 
             * 4,25
             */
            Console.WriteLine(squareArea);
            /* Console Output 
             * 18,0625
             */

            int firstNumber = 5;
            int secondNumber = 4;
            Console.WriteLine(firstNumber + secondNumber);
            /* Console Output 
             * 9
             */
            Console.WriteLine(firstNumber + (secondNumber++));
            /* Console Output 
             * 9 
             */
            Console.WriteLine(firstNumber + secondNumber);
            /* Console Output 
             * 10 
             */

            Console.WriteLine(firstNumber + (++secondNumber));
            /* Console Output 
             * 11
             */

            Console.WriteLine(firstNumber + secondNumber);
            /* Console Output 
             * 11
             */
            Console.WriteLine(14 / firstNumber);
            /* Console Output 
             * 2
             */
            Console.WriteLine(14 % firstNumber);
            /* Console Output 
             * 4
             */
            int one = 1;
            int zero = 0;
            //Console.WriteLine(one / zero);
            /* Console Output:
             * Unhandled exception. System.DivideByZeroException: Attempted to divide by zero.
             */

            double dMinusOne = -1.0;
            double dZero = 0.0;
            Console.WriteLine(dMinusOne / zero);
            /* Console Output :
             * -? (Which means -Infinity or Negative Infinity)
             */
            Console.WriteLine(one / dZero);
            /* Console Output:
             * ? (Which means Infinity or Positive Infinity)
             */
        }
    }
}
