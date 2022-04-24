using System;

namespace Example5_Bitwise
{
    internal class Program
    {
        static void Main(string[] args)
        {
            byte a = 3;     // 0000 0011 = 3
            byte b = 5;     // 0000 0101 = 5

            Console.WriteLine(a | b);
            /* Console Output
             * 7 (if we wanna write it in binary 0000 0111)
             */

            Console.WriteLine(a & b);
            /* Console Output
             * 1 (if we wanna write it in binary 0000 0001)
             */

            Console.WriteLine(a ^ b);
            /* Console Output
             * 6 (if we wanna write it in binary 0000 0110)
             */

            Console.WriteLine(~a & b);
            /* Console Output
             * 4 (if we wanna write it in binary 0000 0100)
             */

            Console.WriteLine(a << 1);
            /* Console Output
             * 6 (if we wanna write it in binary 0000 0110)
             */

            Console.WriteLine(a << 2);
            /* Console Output
             * 12 (if we wanna write it in binary 0000 1100)
             */

            Console.WriteLine(a >> 1);
            /* Console Output
             * 1 (if we wanna write it in binary 0000 0001)
             */
        }
    }
}
