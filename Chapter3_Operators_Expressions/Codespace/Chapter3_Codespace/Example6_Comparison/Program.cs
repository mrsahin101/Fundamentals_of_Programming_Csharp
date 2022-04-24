using System;

namespace Example6_Comparison
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int x = 10, y = 5;
            Console.WriteLine(" x > y : " + (x > y));
            /* Console Outout:
             * x > y : True
             */

            Console.WriteLine(" x < y : " + (x < y));
            /* Console Outout:
             * x < y : False
             */

            Console.WriteLine(" x >= y : " + (x >= y));
            /* Console Outout:
             * x >= y : True
             */

            Console.WriteLine(" x <= y : " + (x <= y));
            /* Console Outout:
             * x <= y : False
             */

            Console.WriteLine(" x == y : " + (x == y));
            /* Console Outout:
             *  x == y : False
             */

            Console.WriteLine(" x != y : " + (x != y));
            /* Console Outout:
             * x != y : True
             */

        }
    }
}
