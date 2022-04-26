using System;

namespace Example10_DataLoss
{
    internal class Program
    {
        static void Main(string[] args)
        {
            long myLong = long.MaxValue;

            int myInt = (int)myLong;

            Console.WriteLine(myLong);
            /* Console Output:
             * 9223372036854775807
             */
            Console.WriteLine(myInt);
            /* Console Output:
             * -1
             */

            float heightInMeters = 1.74f;               /* Explicit Conversion */
            double maxHeight = heightInMeters;          /* Implicit Conversion */
            double minHeight = (double)heightInMeters;  /* Explicit Conversion */
            float actualHeight = (float)maxHeight;      /* Explicit Conversion */

            // float maxHeightFloat = maxHeight;        /* Compilation Error   */

            /* Overflow Exceptions During casting */
            double d = 5e9d;
            Console.WriteLine(d);
            /* Console Output:
             * 5000000000
             */
            int i = checked((int)d);
            Console.WriteLine(i);
            /* Console Output:
             * Unhandled exception. System.OverflowException: Arithmetic operation resulted in an overflow.
             */
        }
    }
}
