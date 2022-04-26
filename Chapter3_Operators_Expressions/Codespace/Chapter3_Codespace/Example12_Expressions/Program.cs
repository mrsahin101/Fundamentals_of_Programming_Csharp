using System;

namespace Example12_Expressions
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int r = (150-20) / 2 + 5;
            Console.WriteLine(r);
            /* Console Output:
             * 70
             */

            /* Expression for calculating the surface of the circle */
            double surface = Math.PI * r * r;
            Console.WriteLine(surface);
            /* Console Output:
             * 15393,804002589986
             */

            /* Expression for calculating the perimeter of the circle */
            double perimeter = 2 * Math.PI * r;
            Console.WriteLine(perimeter);
            /* Console Output:
             * 439,822971502571
             */

            /* SIDE EFFECTS OF EXPRESSIONS */
            int a = 5;
            int b = ++a;

            Console.WriteLine(a);
            /* Console Output:
             * 6
             */
            Console.WriteLine(b);
            /* Console Output:
             * 6
             */

            double d = 1/2;
            Console.WriteLine(d);
            /* Console Output:
             * 0  // This happens because 1/2 is integer operation. first we calculate expression then we assign it to left.
             */

            double half = (double)1 / 2;
            /* Console Output:
             * 0,5
             */

            /* DIVISION BY ZERO */
            int num = 1;
            double denum = 0;           // This is equivalent to 0.0 (real number)
            int zeroInt = (int)denum;   // This is 0 (integer number)
            
            Console.WriteLine(num / denum);
            /* Console Output:
             * ?
             */

            Console.WriteLine(denum / denum);
            /* Console Output:
             * NaN
             */

            //Console.WriteLine(zeroInt / zeroInt);
            /* Console Output:
             * Unhandled exception. System.DivideByZeroException: Attempted to divide by zero.
             */

            /* USING BRACKETS to MAKE CODE CLEAR */
            double incorrect = (double)((1 + 2) / 4);
            Console.WriteLine(incorrect);
            /* Console Output:
             * 0
             */

            double correct = ((double)(1 + 2))/4;
            Console.WriteLine(correct);
            /* Console Output:
             * 0,75
             */

            Console.WriteLine("2 + 3 = " + 2 + 3);
            /* Console Output:
             * 2 + 3 = 23
             */

            Console.WriteLine("2 + 3 = " + (2 + 3));
            /* Console Output:
             * 2 + 3 = 5
             */
        }
    }
}
