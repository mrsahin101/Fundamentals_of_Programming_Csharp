using System;

namespace Example7_Assignments
{
    internal class Program
    {
        static void Main(string[] args)
        {
            /* SIMPLE ASSIGNMENT OPERATIONS */
            int x = 6;
            string helloString = "Hello string.";
            int y = x;

            /* CASCADE ASSIGNMENT OPERATIONS */
            int a, b, c;
            a = b = c =25;

            /* COMPOUND ASSINGMENT OPERATIONS */
            int d = 2;
            int e = 4;

            d *= e; // This is pretty much same as d = d * e;
            Console.WriteLine(d);
            /* Console Output:
             * 8 
             */

            int k = 6;
            int l = 4;
            Console.WriteLine(l *= 2);
            /* Console Output:
             * 8 
             */

            int m = l = 3;
            Console.WriteLine(m);
            /* Console Output:
             * 3
             */

            Console.WriteLine(k |= 1);
            /* Console Output:
             * 7
             */

            Console.WriteLine(k += 3);
            /* Console Output:
             * 10
             */

            Console.WriteLine(k /= 2);
            /* Console Output:
             * 5
             */
        }
    }
}
