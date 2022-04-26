using System;

namespace Example11_String_Conversion
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int a = 5;
            int b = 7;

            string sum = "Sum = " + (a + b);
            Console.WriteLine(sum);
            /* Console Output :
             * Sum = 12
             */

            String incorrect = "Sum = " + a + b;
            Console.WriteLine(incorrect);
            /* Console Output :
             * Sum = 57   // This happens because it takes literally 5 and 7 then concatenating them together.
             */

            Console.WriteLine("Perimeter = " + 2 * (a + b) + ".Area = " + (a * b) + ".");
            /* Console Output :
             * Perimeter = 24.Area = 35.
             */
        }
    }
}
