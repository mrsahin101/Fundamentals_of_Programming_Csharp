using System;

namespace Example9_Type_Conversion
{
    internal class Program
    {
        static void Main(string[] args)
        {
            /* IMPLICIT CONVERSION */
            int myInt = 5;
            Console.WriteLine(myInt);
            /* Console Output:
             * 5
             */
            long myLong = myInt;
            Console.WriteLine(myLong);
            /* Console Output:
             * 5
             */

            Console.WriteLine((myLong + myInt) + " type: "+ (myLong + myInt).GetType().ToString());
            /* Console Output:
             * 10 type: System.Int64
             */
            /* Basicly here what happened is that myInt is converted to long type. Calculations performed then result converted to
             * string type to output on the console 
             */
        }
    }
}
