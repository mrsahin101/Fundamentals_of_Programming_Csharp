using System;

namespace Example3_Logical_Operators
{
    internal class Program
    {
        static void Main(string[] args)
        {
            bool a = true;
            bool b = false;
            Console.WriteLine(a && b);
            /* Console Output:
             * False
             */

            Console.WriteLine(a || b);
            /* Console Output:
             * True
             */

            Console.WriteLine(!b);
            /* Console Output:
             * True
             */

            Console.WriteLine(b || true);
            /* Console Output:
             * True
             */

            Console.WriteLine((5 > 7) ^ (a == b));
            /* Console Output:
             * False
             */

        }
    }
}
