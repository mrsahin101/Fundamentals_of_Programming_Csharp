using System;

namespace Example3_Precision
{
    internal class Program
    {
        static void Main(string[] args)
        {
            /*Declare some variables */
            float floatPI = 3.141592653589793228f;
            double doublePI = 3.141592653589793228;

            /* Print result on console */
            Console.WriteLine("Float PI is : " + floatPI);
            Console.WriteLine("Double PI is : " + doublePI);

            /*Console Output:
             * Float PI is : 3,1415927
             * Double PI is : 3,141592653589793 
             */

            /*Conclusion : Double has much more precision compare to float. If we need much more precision
             * compare to float we use it. otherwise using float is better. Cuz double has bigger foot-print on memory
             */
        }
    }
}
