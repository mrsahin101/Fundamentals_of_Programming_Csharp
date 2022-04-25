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

            /* EXPLICIT CONVERSION */
            double myDouble = 5.1d;
            Console.WriteLine(myDouble);
            /* Console Output.
             * 5,1
             */

            long mylong = (long)myDouble;
            Console.WriteLine(mylong);
            /* Console Output.
             * 5
             */

            myDouble = 5e9d;
            Console.WriteLine(myDouble);
            /* Console Output.
             * 5000000000
             */

            int myInteger = (int)myDouble;
            Console.WriteLine(myInteger);
            /* Console Output.
             * -2147483648
             */

            Console.WriteLine(int.MinValue);
            /* Console Output.
             * -2147483648
             */
            /* This happens because the myDouble variable value is bigger than int range so it gets minimum value of integer.
             * It's not always possible to predict what value of a variable will be after scope overflow! Therefore use sufficent
             * large types and be careful to switching smaller types.
             */
        }
    }
}
